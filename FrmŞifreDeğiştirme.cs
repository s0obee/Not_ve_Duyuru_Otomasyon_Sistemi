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
    public partial class FrmŞifreDeğiştirme : Form
    {
        public FrmŞifreDeğiştirme()
        {
            InitializeComponent();
        }
        public string dbName = "otomasyon.db";
        private void btnPasswordUpdate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);

                    if (string.IsNullOrWhiteSpace(txtNewPassword.Text)) 
                    {
                        MessageBox.Show("Yeni Şifre Kısmı Boş Bırakılamaz..!");
                        return;
                    }
                      
                    if (txtEmail.Text.EndsWith("@ogrenci.karabuk.edu.tr"))
                    {
                        if (txtNewPassword.Text == txtNewPasswordAgain.Text)
                        {
                            cmd.CommandText = "UPDATE students SET password = @newPassword WHERE email = @email AND password = @oldPassword";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@newPassword", txtNewPassword.Text);
                            cmd.Parameters.AddWithValue("@oldPassword", txtOldPassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Şifre Başarıyla Güncellendi. Lütfen Yeni Şifreniz ile Tekrardan Giriş Yapınız.");
                            connection.Close();

                            FrmÖğrenciGiriş öğrenciGiriş = new FrmÖğrenciGiriş();
                            this.Hide();
                            öğrenciGiriş.Show();
                        }
                        else { MessageBox.Show("Yeni Şifre Birbiriyle Uyuşmuyor..!"); }
                    }

                    else if (txtEmail.Text.EndsWith("@karabuk.edu.tr"))
                    {
                        if (txtNewPassword.Text == txtNewPasswordAgain.Text)
                        {
                            cmd.CommandText = "UPDATE teachers SET password = @newPassword WHERE email = @email AND password = @oldPassword";
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@newPassword", txtNewPassword.Text);
                            cmd.Parameters.AddWithValue("@oldPassword", txtOldPassword.Text);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Şifre Başarıyla Güncellendi. Lütfen Yeni Şifreniz ile Tekrardan Giriş Yapınız.");
                            connection.Close();

                            FrmÖğretimGörevlisiGiriş öğretimGörevlisiGiriş = new FrmÖğretimGörevlisiGiriş();
                            this.Hide();
                            öğretimGörevlisiGiriş.Show();
                        }
                        else { MessageBox.Show("Yeni Şifre Birbiriyle Uyuşmuyor..!"); }
                    }
                    else { MessageBox.Show("Hatalı Bilgi Girişi ..!"); }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
