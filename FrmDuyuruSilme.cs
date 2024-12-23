using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Visual
{
    public partial class FrmDuyuruSilme : Form
    {
        public string dbName = "otomasyon.db";
        public int idInfo;
        public string nameInfo;
        public FrmDuyuruSilme()
        {
            InitializeComponent();
        }

        public void selectAnnouncesFromDb()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "SELECT * FROM announcments WHERE teacherName = @teacherName";
                    cmd.Parameters.AddWithValue("@teacherName", nameInfo);
                    cmd.ExecuteNonQuery();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    cmbHeader.DataSource = ds.Tables[0];
                    cmbHeader.DisplayMember = "header";
                    cmbHeader.ValueMember = "duyuruId";
                    cmbHeader.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmDuyuruSilme_Load(object sender, EventArgs e)
        {
            lblTeacherNoData.Text = idInfo.ToString();
            lblTeacherNameData.Text = nameInfo;
            selectAnnouncesFromDb();
        }

        private void btnAnnouncmentDelete_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    if (cmbHeader.SelectedValue == null)
                    {
                        MessageBox.Show("Lütfen bir duyuru seçin!");
                        return;
                    }
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "DELETE FROM announcments WHERE duyuruId = @id";
                    cmd.Parameters.AddWithValue("@id", cmbHeader.SelectedValue);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Duyuru başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Silinecek duyuru bulunamadı.");
                    }
                    connection.Close();
                    this.Close();
                    FrmÖğretimGörevlisi frm = new FrmÖğretimGörevlisi();
                    frm.idInfoBack = idInfo;
                    frm.nameInfoBack = nameInfo;
                    frm.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
