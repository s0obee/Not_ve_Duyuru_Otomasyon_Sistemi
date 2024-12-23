using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Visual
{
    public partial class FrmSınıfOrtalaması : Form
    {
        public int id;
        double vize = 0, final = 0, odev = 0, ortalama = 0;
        double totalClassAverage = 0;
        int studentCount = 0;

        public string dbName = "otomasyon.db";
        public int idInfo;
        public string nameInfo;

        public FrmSınıfOrtalaması()
        {
            InitializeComponent();
        }
        
        private DataTable FetchData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                connection.Open();
                string query = "SELECT vize.vizeNot, final.finalNot, ödev.ödevNot, ortalama.ortalama " +
                                "FROM vize " +
                                "INNER JOIN final ON vize.vizeId = final.finalId " +
                                "INNER JOIN ödev ON vize.vizeId = ödev.odevId " +
                                "INNER JOIN ortalama ON vize.vizeId = ortalama.ortalamaId " +
                                "WHERE vize.studentId = @studentId AND vize.dersAdı = @dersAdı";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", lblStudentNoData.Text);
                    command.Parameters.AddWithValue("@dersAdı", cmbLessonInfo.Text);

                    using (var adapter = new SQLiteDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }

            }
        }

        private void btnList_Click_1(object sender, EventArgs e)
        {
            ShowBarChart();
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            FrmÖğrenci frm = new FrmÖğrenci();
            frm.idInfoBack = idInfo;
            frm.nameInfoBack = nameInfo;
            this.Hide();
            frm.Show();
        }

        private void FrmSınıfOrtalaması_Load_1(object sender, EventArgs e)
        {
            lblStudentNoData.Text = idInfo.ToString();
            lblStudentNameData.Text = nameInfo;
            try
            {
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "SELECT dersAdı FROM lessons";
                    cmd.ExecuteNonQuery();
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string dersAdı = reader["dersAdı"].ToString();
                            cmbLessonInfo.Items.Add(dersAdı);
                        }
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dersler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double classAvg()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + dbName))
            {
                connection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = connection;
                    cmd.CommandText = "SELECT ortalama FROM ortalama WHERE dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@dersAdı", cmbLessonInfo.Text);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        double totalScore = 0;
                        int studentCount = 0;
                        while (reader.Read())
                        {
                            double avg = Convert.ToDouble(reader["ortalama"]);
                            totalScore += avg;
                            studentCount++;
                        }
                        return studentCount > 0 ? totalScore / studentCount : 0;
                    }
                }
            }
        }

        private void ShowBarChart()
        {
            DataTable dataTable = FetchData();

            if (dataTable.Rows.Count == 0 ||
                string.IsNullOrEmpty(dataTable.Rows[0]["vizeNot"].ToString()) ||
                string.IsNullOrEmpty(dataTable.Rows[0]["finalNot"].ToString()) ||
                string.IsNullOrEmpty(dataTable.Rows[0]["ödevNot"].ToString()))
            {
                MessageBox.Show("Vize, Final veya Ödev notlarından herhangi biri eksik. Sınıf ortalamasını göremezsiniz.",
                                "Eksik Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            double classAverage = classAvg();

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();

            
            ChartArea chartArea = new ChartArea
            {
                Name = "MainArea",
                AxisX = { Title = "Sınavlar" },
                AxisY = { Title = "Notlar" }
            };
            chart1.ChartAreas.Add(chartArea);

            
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Notlar",
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true  
            };

            
            series.Points.AddXY("Vize", Convert.ToDouble(dataTable.Rows[0]["vizeNot"]));
            series.Points.AddXY("Final", Convert.ToDouble(dataTable.Rows[0]["finalNot"]));
            series.Points.AddXY("Ödev", Convert.ToDouble(dataTable.Rows[0]["ödevNot"]));
            series.Points.AddXY("Ortalama", Convert.ToDouble(dataTable.Rows[0]["ortalama"]));
            series.Points.AddXY("Sınıf Ortalaması", classAverage);

            
            series.Points[0].Color = Color.Red; 
            series.Points[1].Color = Color.Blue; 
            series.Points[2].Color = Color.Green; 
            series.Points[3].Color = Color.Purple; 
            series.Points[4].Color = Color.Orange; 

            
            chart1.Series.Add(series);

            
            chart1.ChartAreas[0].AxisX.Interval = 1;  
        }
    }
}
