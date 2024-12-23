using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Visual
{
    public partial class FrmÖğrenci : Form
    {
        string dbName = "otomasyon.db";
        public string name = " ";
        public int id = 0;
        public int idInfoBack = 0;
        public string nameInfoBack = " ";
        public FrmÖğrenci()
        {
            InitializeComponent();
        }
        public void loadAvg()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);

                    cmd.CommandText = "SELECT v.studentId, v.dersAdı, v.vizeNot, f.finalNot, o.ödevNot, ot.ortalama " +
                        "FROM vize v JOIN final f ON v.studentId = f.studentId AND v.dersAdı = f.dersAdı " +
                        "JOIN ödev o ON v.studentId = o.studentId AND v.dersAdı = o.dersAdı  " +
                        "LEFT JOIN ortalama ot ON v.studentId = ot.studentId AND v.dersAdı = ot.dersAdı  " +
                        "WHERE v.studentId = @studentId";
                    cmd.Parameters.AddWithValue("@studentId", lblStudentNoData.Text);

                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt); 
                    dataGridView1.DataSource = dt;  
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void FrmÖğrenci_Load(object sender, EventArgs e)
        {
            if (idInfoBack == 0)
            {
                lblStudentNameData.Text = name;
                lblStudentNoData.Text = id.ToString();
            }

            else
            {
                lblStudentNameData.Text = nameInfoBack;
                lblStudentNoData.Text = idInfoBack.ToString();
            }
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            loadAvg();
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmŞifreDeğiştirme sifreDegistirmeSayfası = new FrmŞifreDeğiştirme();
            sifreDegistirmeSayfası.Show();
            this.Hide();
        }

        private void btnListAvg_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();

                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "SELECT * FROM students WHERE name = @name AND studentId = @studentId";
                    command.Parameters.AddWithValue("@name", lblStudentNameData.Text);
                    command.Parameters.AddWithValue("@studentId", lblStudentNoData.Text);

                    FrmSınıfOrtalaması ortalamaSayfasi = new FrmSınıfOrtalaması();
                    ortalamaSayfasi.idInfo = int.Parse(lblStudentNoData.Text);
                    ortalamaSayfasi.nameInfo = lblStudentNameData.Text;
                    ortalamaSayfasi.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Bağlantısında Hata: " + ex.Message);
                }
            }
        }
    }
}
