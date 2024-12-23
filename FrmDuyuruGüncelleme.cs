using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Visual
{
    public partial class FrmDuyuruGüncelleme : Form
    {
        public string dbName = "otomasyon.db";
        public int idInfo;
        public string nameInfo;
        public FrmDuyuruGüncelleme()
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
                    cmbUpdateAnnouncments.DataSource = ds.Tables[0];
                    cmbUpdateAnnouncments.DisplayMember = "header";
                    cmbUpdateAnnouncments.ValueMember = "duyuruId";
                    cmbUpdateAnnouncments.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAnnouncmentUpdate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "UPDATE announcments SET header = @newheader, contents = @contents WHERE header = @header";
                    cmd.Parameters.AddWithValue("@header", cmbUpdateAnnouncments.Text);
                    cmd.Parameters.AddWithValue("@newheader", txtAnnouncmentsHeader.Text);
                    cmd.Parameters.AddWithValue("@contents", rtxComments.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Duyuru Başarıyla Güncellendi");
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

        private void FrmDuyuruGüncelleme_Load(object sender, EventArgs e)
        {
            lblTeacherNoData.Text = idInfo.ToString();
            lblTeacherNameData.Text = nameInfo;
            selectAnnouncesFromDb();
        }

        private void cmbUpdateAnnouncments_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        var selectedItem = (DataRowView)cmbUpdateAnnouncments.SelectedItem;
            if (selectedItem != null)
            {
                txtAnnouncmentsHeader.Text = selectedItem["header"].ToString();
                rtxComments.Text = selectedItem["contents"].ToString();
            }
        }
    }
}
