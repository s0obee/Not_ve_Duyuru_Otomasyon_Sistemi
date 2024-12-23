using System;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace Visual
{
    public partial class FrmAnasayfa : Form
    {
        public string dbName = "otomasyon.db";
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        public void manageDatabase()
        {
            if (!File.Exists(dbName))
            {
                SQLiteConnection.CreateFile(dbName);
                using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
                {
                    connection.Open();

                    SQLiteCommand cmd = new SQLiteCommand(connection);
                    cmd.CommandText = "CREATE TABLE students(studentId INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, password TEXT NOT NULL, name TEXT NOT NULL, age INTEGER, PRIMARY KEY(studentId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE teachers(teacherId INTEGER NOT NULL UNIQUE, email TEXT NOT NULL UNIQUE, password TEXT NOT NULL, name TEXT NOT NULL, title TEXT, PRIMARY KEY(teacherId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE lessons(dersId INTEGER NOT NULL UNIQUE, dersAdı TEXT NOT NULL, teacherId INTEGER NOT NULL, FOREIGN KEY(teacherId) REFERENCES teachers(teacherId), PRIMARY KEY(dersId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE vize(vizeId INTEGER UNIQUE, studentId INTEGER NOT NULL, dersId INTEGER NOT NULL,  dersAdı TEXT NOT NULL, vizeNot INTEGER NOT NULL, FOREIGN KEY(studentId) REFERENCES students(studentId), FOREIGN KEY(dersAdı) REFERENCES lessons(dersAdı), FOREIGN KEY(dersId) REFERENCES lessons(dersId),  PRIMARY KEY(vizeId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE final(finalId INTEGER UNIQUE, studentId INTEGER NOT NULL, dersId INTEGER NOT NULL, dersAdı TEXT NOT NULL, finalNot INTEGER NOT NULL, FOREIGN KEY(studentId) REFERENCES students(studentId), FOREIGN KEY(dersAdı) REFERENCES lessons(dersAdı), FOREIGN KEY(dersId) REFERENCES lessons(dersId),  PRIMARY KEY(finalId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE ödev(odevId INTEGER UNIQUE, studentId INTEGER NOT NULL, dersId INTEGER NOT NULL,  dersAdı TEXT NOT NULL, ödevNot INTEGER NOT NULL, FOREIGN KEY(studentId) REFERENCES students(studentId), FOREIGN KEY(dersAdı) REFERENCES lessons(dersAdı), FOREIGN KEY(dersId) REFERENCES lessons(dersId),  PRIMARY KEY(odevId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE ortalama(ortalamaId INTEGER UNIQUE, studentId INTEGER NOT NULL, dersId INTEGER NOT NULL,  dersAdı TEXT NOT NULL, ortalama INTEGER NOT NULL, FOREIGN KEY(studentId) REFERENCES students(studentId), FOREIGN KEY(dersAdı) REFERENCES lessons(dersAdı), FOREIGN KEY(dersId) REFERENCES lessons(dersId), PRIMARY KEY(ortalamaId));";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE TABLE announcments(duyuruId INTEGER UNIQUE, teacherName TEXT NOT NULL , header TEXT NOT NULL, contents VARCHAR(50) NOT NULL, FOREIGN KEY(teacherName) REFERENCES teachers(name), PRIMARY KEY(duyuruId AUTOINCREMENT));";
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }

            }
        }

        private void loadAnnouncements()
        {
            string dbName = "otomasyon.db";

            using (SQLiteConnection connection = new SQLiteConnection(@"Data Source = " + dbName))
            {
                try
                {
                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("SELECT teacherName, header, contents FROM announcments", connection); 
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

        private void customizeDataGridView()
        {
            dataGridView1.Columns["header"].HeaderText = "Başlık";
            dataGridView1.Columns["teacherName"].HeaderText = "Öğretmen";
            dataGridView1.Columns["header"].Width = 140;
            dataGridView1.Columns["teacherName"].Width = 100;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   // Satır seçim modunu ayarlar.
            dataGridView1.MultiSelect = false;  // Çoklu seçimini kapalı hale getirir.
        }

        private void FrmAnasayfa_Load(object sender, EventArgs e)
        {
            manageDatabase();
            loadAnnouncements();
            customizeDataGridView();
            rtbAbout.ScrollBars = RichTextBoxScrollBars.Vertical;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

       

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            FrmÖğretimGörevlisiGiriş ogretimGorevlisiGirisForm = new FrmÖğretimGörevlisiGiriş();
            ogretimGorevlisiGirisForm.Show();
            this.Hide();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            FrmÖğrenciGiriş ogrenciGirisForm = new FrmÖğrenciGiriş();
            ogrenciGirisForm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Geçerli bir satır seçiliyse
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string content = selectedRow.Cells["contents"].Value?.ToString();
                rtbAbout.Text = content ?? "İçerik bulunamadı";
            }
        }
    }
}
