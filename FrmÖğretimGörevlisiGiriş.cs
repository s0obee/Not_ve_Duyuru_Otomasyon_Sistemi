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

namespace Visual
{
    public partial class FrmÖğretimGörevlisiGiriş : Form
    {
        public string dbName = "otomasyon.db";
        public FrmÖğretimGörevlisiGiriş()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtTeacherEmail.Text;
            string password = txtTeacherPassword.Text;

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();

                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "SELECT * FROM teachers where email = @email AND password = @password";
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
                        FrmÖğretimGörevlisi ogretimGörevlisiSayfasi = new FrmÖğretimGörevlisi();
                        ogretimGörevlisiSayfasi.name = reader.GetString(3);
                        ogretimGörevlisiSayfasi.id = reader.GetInt32(0);
                        ogretimGörevlisiSayfasi.Show();
                        reader.Close();
                        connection.Close();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı Bağlantısında Hata: " + ex.Message);
                }
            }
        }
    }
}
