namespace Visual
{
    partial class FrmAnasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnasayfa));
            this.rtbAbout = new System.Windows.Forms.RichTextBox();
            this.lblAnnouncements = new System.Windows.Forms.Label();
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.pbKarabuk = new System.Windows.Forms.PictureBox();
            this.lblKarabukUniversity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbKarabuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAbout
            // 
            this.rtbAbout.Location = new System.Drawing.Point(12, 269);
            this.rtbAbout.Name = "rtbAbout";
            this.rtbAbout.Size = new System.Drawing.Size(293, 214);
            this.rtbAbout.TabIndex = 14;
            this.rtbAbout.Text = "";
            // 
            // lblAnnouncements
            // 
            this.lblAnnouncements.AutoSize = true;
            this.lblAnnouncements.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAnnouncements.Location = new System.Drawing.Point(124, 75);
            this.lblAnnouncements.Name = "lblAnnouncements";
            this.lblAnnouncements.Size = new System.Drawing.Size(78, 19);
            this.lblAnnouncements.TabIndex = 13;
            this.lblAnnouncements.Text = "Duyurular";
            // 
            // btnOgrenci
            // 
            this.btnOgrenci.BackColor = System.Drawing.Color.Red;
            this.btnOgrenci.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOgrenci.Location = new System.Drawing.Point(399, 362);
            this.btnOgrenci.Name = "btnOgrenci";
            this.btnOgrenci.Size = new System.Drawing.Size(147, 53);
            this.btnOgrenci.TabIndex = 11;
            this.btnOgrenci.Text = "Öğrenci Girişi";
            this.btnOgrenci.UseVisualStyleBackColor = false;
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.DarkBlue;
            this.btnTeacher.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeacher.Location = new System.Drawing.Point(399, 303);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(147, 53);
            this.btnTeacher.TabIndex = 10;
            this.btnTeacher.Text = "Öğretmen Girişi";
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // pbKarabuk
            // 
            this.pbKarabuk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pbKarabuk.Image = ((System.Drawing.Image)(resources.GetObject("pbKarabuk.Image")));
            this.pbKarabuk.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbKarabuk.InitialImage")));
            this.pbKarabuk.Location = new System.Drawing.Point(371, 75);
            this.pbKarabuk.Name = "pbKarabuk";
            this.pbKarabuk.Size = new System.Drawing.Size(203, 188);
            this.pbKarabuk.TabIndex = 9;
            this.pbKarabuk.TabStop = false;
            // 
            // lblKarabukUniversity
            // 
            this.lblKarabukUniversity.AutoSize = true;
            this.lblKarabukUniversity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarabukUniversity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKarabukUniversity.Location = new System.Drawing.Point(292, 28);
            this.lblKarabukUniversity.Name = "lblKarabukUniversity";
            this.lblKarabukUniversity.Size = new System.Drawing.Size(361, 26);
            this.lblKarabukUniversity.TabIndex = 8;
            this.lblKarabukUniversity.Text = "Karabük Üniversitesi Otomasyon Sistemi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(293, 152);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(626, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 372);
            this.panel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Not ..:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 108);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eğer ilk girişiniz ise\r\nlütfen şifre kısmına \r\nnumaralarınızı giriniz ..!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 132);
            this.label3.TabIndex = 2;
            this.label3.Text = "Herhangi bir sıkıntıda \r\nbu adres üzerinden mail \r\natabilirsiniz. \r\ninfo@karabuk." +
    "edu.tr";
            // 
            // FrmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(938, 495);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rtbAbout);
            this.Controls.Add(this.lblAnnouncements);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.pbKarabuk);
            this.Controls.Add(this.lblKarabukUniversity);
            this.Name = "FrmAnasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.FrmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKarabuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbAbout;
        private System.Windows.Forms.Label lblAnnouncements;
        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.PictureBox pbKarabuk;
        private System.Windows.Forms.Label lblKarabukUniversity;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

