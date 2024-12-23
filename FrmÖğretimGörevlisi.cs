using MindFusion.Charting.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmÖğretimGörevlisi : Form
    {
        public string dbName = "otomasyon.db";
        public string name = " ";
        public int id = 0;
        public int idInfoBack = 0;
        public string nameInfoBack = " ";
        public FrmÖğretimGörevlisi()
        {
            InitializeComponent();
        }


        public void ortalamaHesap()
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {

                    connection.Open();
                    int vize = 0, final = 0, odev = 0, dersId = 0, ortalamaId = 0;
                    SQLiteCommand cmd = new SQLiteCommand(connection);

                    cmd.CommandText = "SELECT vizeNot, dersAdı FROM vize WHERE studentId = @studentId AND dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object vizeResult = cmd.ExecuteScalar();
                    if (vizeResult != null) { vize = Convert.ToInt32(vizeResult); }

                    cmd.CommandText = "SELECT finalNot," +
                        " dersAdı FROM final WHERE studentId = @studentId AND dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object finalResult = cmd.ExecuteScalar();
                    if (finalResult != null) { final = Convert.ToInt32(finalResult); }

                    cmd.CommandText = "SELECT ödevNot, dersAdı FROM ödev WHERE studentId = @studentId AND dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object odevResult = cmd.ExecuteScalar();
                    if (odevResult != null) { odev = Convert.ToInt32(odevResult); }

                    double ortalama = (vize * 0.4) + (final * 0.5) + (odev * 0.1);

                    cmd.CommandText = "SELECT ortalama FROM ortalama WHERE studentId = @studentId AND dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object ortalamaResult = cmd.ExecuteScalar();

                    cmd.CommandText = "SELECT finalId FROM final WHERE studentId = @studentId AND dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object finalId = cmd.ExecuteScalar() ;
                    if (finalId != null) { ortalamaId = Convert.ToInt32(finalId); dersId = Convert.ToInt32(finalId) - int.Parse(txtFinalStudentNo.Text); }

                    if (ortalamaResult != null)
                    {
                        cmd.CommandText = "UPDATE ortalama SET ortalama = @ortalama WHERE studentId = @studentId AND dersAdı = @dersAdı";
                        cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                        cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                        cmd.Parameters.AddWithValue("@ortalama", ortalama);
                        cmd.ExecuteNonQuery();
                    } 
                    else
                    {
                        cmd.CommandText = "INSERT INTO ortalama(ortalamaId, studentId, dersId, dersAdı, ortalama) VALUES (@ortalamaId, @studentId, @dersId, @dersAdı, @ortalama)";
                        cmd.Parameters.AddWithValue("@ortalamaId", ortalamaId);
                        cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                        cmd.Parameters.AddWithValue("@dersId", dersId);
                        cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                        cmd.Parameters.AddWithValue("@ortalama", ortalama);
                        cmd.ExecuteNonQuery();
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FrmÖğretimGörevlisi_Load(object sender, EventArgs e)
        {
            if(idInfoBack == 0)
            {
                lblTeacherNameData.Text = name;
                lblTeacherNoData.Text = id.ToString();
            }

            else 
            {
                lblTeacherNameData.Text = nameInfoBack;
                lblTeacherNoData.Text = idInfoBack.ToString();
            }

            cmbVizeExamInfo.Items.Add("vize");
            cmbFinalExamInfo.Items.Add("final");
            cmbOdevExamInfo.Items.Add("ödev");

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
                            cmbVizeLessonInfo.Items.Add(dersAdı);
                            cmbFinalLessonInfo.Items.Add(dersAdı);
                            cmbOdevLessonInfo.Items.Add(dersAdı);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            FrmŞifreDeğiştirme sifreDegistirmeSayfası = new FrmŞifreDeğiştirme();
            sifreDegistirmeSayfası.Show();
            this.Hide();
        }

        private void btnAnnouncmentAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);
                    command.CommandText = "INSERT INTO announcments(teacherName,header,contents) VALUES(@teacherName,@header,@contents)";
                    command.Parameters.AddWithValue("@teacherName", lblTeacherNameData.Text);
                    command.Parameters.AddWithValue("@header", txtHeader.Text);
                    command.Parameters.AddWithValue("@contents", rtxComments.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Duyurunuz Başarılı Bir Şekilde Eklenmiştir ..:");
                    connection.Close();
                    Islemler.clearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAnnouncmentDelete_Click(object sender, EventArgs e)
        {
            FrmDuyuruSilme duyuruSilmeSayfasi = new FrmDuyuruSilme();
            duyuruSilmeSayfasi.idInfo = int.Parse(lblTeacherNoData.Text);
            duyuruSilmeSayfasi.nameInfo = lblTeacherNameData.Text;
            duyuruSilmeSayfasi.Show();
            this.Hide();
        }

        private void btnAnnouncmentUpdate_Click(object sender, EventArgs e)
        {
            FrmDuyuruGüncelleme duyuruGüncellemeSayfası = new FrmDuyuruGüncelleme();
            duyuruGüncellemeSayfası.idInfo = int.Parse(lblTeacherNoData.Text);
            duyuruGüncellemeSayfası.nameInfo = lblTeacherNameData.Text;
            duyuruGüncellemeSayfası.Show();
            this.Hide();
        }
        
        private void btnVizeExamAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    int studentId = int.Parse(txtVizeStudentNo.Text);
                    int vizeId = 0;
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);

                    command.CommandText = "SELECT dersId FROM lessons WHERE dersAdı = @dersAdı";
                    command.Parameters.AddWithValue("@dersAdı", cmbVizeLessonInfo.Text);
                    object dersId = command.ExecuteScalar();
                    if (dersId != null) { vizeId = Convert.ToInt32(dersId) + studentId; }

                    command.CommandText = "INSERT INTO vize(vizeId,studentId,dersId,dersAdı,vizeNot) VALUES(@vizeId,@studentId,@dersId,@dersAdı,@vizeNot)";
                    command.Parameters.AddWithValue("@vizeId", vizeId.ToString());
                    command.Parameters.AddWithValue("@studentId", txtVizeStudentNo.Text);
                    command.Parameters.AddWithValue("@dersAdı", cmbVizeLessonInfo.Text);
                    command.Parameters.AddWithValue("@dersId", dersId.ToString());
                    command.Parameters.AddWithValue("@vizeNot", txtVizeExamScore.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Vize Not Bilgisi Başarılı Bir Şekilde Eklenmiştir ..:");

                    connection.Close();
                    Islemler.clearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVizeExamUpdate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    int studentId = int.Parse(txtVizeStudentNo.Text);
                    int vizeId = 0;
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "SELECT dersId FROM lessons WHERE dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@dersAdı", cmbVizeLessonInfo.Text);
                    object dersId = cmd.ExecuteScalar();
                    if (dersId != null) { vizeId = Convert.ToInt32(dersId) + studentId; }

                    cmd.CommandText = "UPDATE vize SET vizeNot = @vizeNot WHERE studentId = @studentId and vizeId = @vizeId";
                    cmd.Parameters.AddWithValue("@studentId", txtVizeStudentNo.Text);
                    cmd.Parameters.AddWithValue("@vizeId", vizeId.ToString());
                    cmd.Parameters.AddWithValue("@vizeNot", txtVizeExamScore.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Vize Notu Başarıyla Güncellendi");
                    connection.Close();
                    Islemler.clearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnFinalExamAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    int studentId = int.Parse(txtFinalStudentNo.Text);
                    int finalId = 0;
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);

                    command.CommandText = "SELECT dersId FROM lessons WHERE dersAdı = @dersAdı";
                    command.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object dersId = command.ExecuteScalar();
                    if (dersId != null) { finalId = Convert.ToInt32(dersId) + studentId; }

                    command.CommandText = "INSERT INTO final(finalId,studentId,dersId,dersAdı,finalNot) VALUES(@finalId,@studentId,@dersId,@dersAdı,@finalNot)";
                    command.Parameters.AddWithValue("@finalId", finalId.ToString());
                    command.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    command.Parameters.AddWithValue("@dersId", dersId.ToString());
                    command.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    command.Parameters.AddWithValue("@finalNot", txtFinalExamScore.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Final Not Bilgisi Başarılı Bir Şekilde Eklenmiştir ..:");

                    connection.Close();
                    ortalamaHesap();
                    Islemler.clearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnFinalExamUpdate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    int studentId = int.Parse(txtFinalStudentNo.Text);
                    int finalId = 0;
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "SELECT dersId FROM lessons WHERE dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@dersAdı", cmbFinalLessonInfo.Text);
                    object dersId = cmd.ExecuteScalar();
                    if (dersId != null) { finalId = Convert.ToInt32(dersId) + studentId; }

                    cmd.CommandText = "UPDATE final SET finalNot = @finalNot WHERE studentId = @studentId and finalId = @finalId";
                    cmd.Parameters.AddWithValue("@studentId", txtFinalStudentNo.Text);
                    cmd.Parameters.AddWithValue("@finalId", finalId.ToString());
                    cmd.Parameters.AddWithValue("@finalNot", txtFinalExamScore.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Final Notu Başarıyla Güncellendi");

                    connection.Close();
                    ortalamaHesap();
                    Islemler.clearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOdevExamAdd_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    int studentId = int.Parse(txtOdevStudentNo.Text);
                    int odevId = 0;
                    connection.Open();
                    SQLiteCommand command = new SQLiteCommand(connection);

                    command.CommandText = "SELECT dersId FROM lessons WHERE dersAdı = @dersAdı";
                    command.Parameters.AddWithValue("@dersAdı", cmbOdevLessonInfo.Text);
                    object dersId = command.ExecuteScalar();
                    if (dersId != null) { odevId = Convert.ToInt32(dersId) + studentId; }

                    command.CommandText = "INSERT INTO ödev(odevId,studentId,dersId,dersAdı,ödevNot) VALUES(@odevId,@studentId,@dersId,@dersAdı,@ödevNot)";
                    command.Parameters.AddWithValue("@odevId", odevId.ToString());
                    command.Parameters.AddWithValue("@studentId", txtOdevStudentNo.Text);
                    command.Parameters.AddWithValue("@dersId", dersId.ToString());
                    command.Parameters.AddWithValue("@dersAdı", cmbOdevLessonInfo.Text);
                    command.Parameters.AddWithValue("@ödevNot", txtOdevExamScore.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Ödev Not Bilgisi Başarılı Bir Şekilde Eklenmiştir ..:");

                    connection.Close();
                    Islemler.clearForm(this);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOdevExamUpdate_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    int studentId = int.Parse(txtOdevStudentNo.Text);
                    int odevId = 0;
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "SELECT dersId FROM lessons WHERE dersAdı = @dersAdı";
                    cmd.Parameters.AddWithValue("@dersAdı", cmbOdevLessonInfo.Text);
                    object dersId = cmd.ExecuteScalar();
                    if (dersId != null) { odevId = Convert.ToInt32(dersId) + studentId; }

                    cmd.CommandText = "UPDATE ödev SET ödevNot = @ödevNot WHERE studentId = @studentId and odevId = @odevId";
                    cmd.Parameters.AddWithValue("@studentId", txtOdevStudentNo.Text);
                    cmd.Parameters.AddWithValue("@odevId", odevId.ToString());
                    cmd.Parameters.AddWithValue("@ödevNot", txtOdevExamScore.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ödev Notu Başarıyla Güncellendi");

                    connection.Close();
                    Islemler.clearForm(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
