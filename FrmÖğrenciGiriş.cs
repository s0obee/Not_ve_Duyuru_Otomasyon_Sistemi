using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Visual
{
    public partial class FrmÖğrenciGiriş : Form
    {
        public string dbName = "otomasyon.db";
        public FrmÖğrenciGiriş()
        {
            InitializeComponent();
        }

        private void FrmÖğrenciGiriş_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtStudentEmail.Text;
            string password = txtStudentPassword.Text;

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();

                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "SELECT * FROM students where email = @email AND password = @password";
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);

                    SQLiteDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        connection.Close();
                        MessageBox.Show("Hatalı Bilgi Girişi ..!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        reader.Read();
                        FrmÖğrenci ogrenciSayfasi = new FrmÖğrenci();
                        ogrenciSayfasi.name = reader.GetString(3);
                        ogrenciSayfasi.id = reader.GetInt32(0);
                        ogrenciSayfasi.Show();
                        this.Hide();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Bağlantısında Hata: " + ex.Message);
                }
            }

        }
    }
}
