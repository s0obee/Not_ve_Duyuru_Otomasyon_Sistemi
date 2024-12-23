namespace Visual
{
    partial class FrmÖğrenci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖğrenci));
            this.lblMessage = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblStudentNoData = new System.Windows.Forms.Label();
            this.lblStudentNameData = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnListAvg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(491, 26);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Karabük Üniversitesi Otomasyon Sistemi Öğrenci Ekranı";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(728, 284);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnUpdatePassword);
            this.panel1.Controls.Add(this.lblWarning);
            this.panel1.Location = new System.Drawing.Point(14, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(917, 127);
            this.panel1.TabIndex = 12;
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.Color.Red;
            this.btnUpdatePassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdatePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdatePassword.Location = new System.Drawing.Point(330, 73);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(252, 49);
            this.btnUpdatePassword.TabIndex = 13;
            this.btnUpdatePassword.Text = "Şifrenizi Güncelleyiniz !";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(134, 28);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(654, 20);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "Eğer Sisteme İlk Girişinizse Lütfen Alttaki Butona Tıklayarak Şifrenizi Değiştiri" +
    "niz";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.Black;
            this.lblStudentNo.Location = new System.Drawing.Point(13, 47);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(147, 19);
            this.lblStudentNo.TabIndex = 13;
            this.lblStudentNo.Text = "Öğrenci Numarası ..:";
            // 
            // lblStudentNoData
            // 
            this.lblStudentNoData.AutoSize = true;
            this.lblStudentNoData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNoData.ForeColor = System.Drawing.Color.Black;
            this.lblStudentNoData.Location = new System.Drawing.Point(166, 47);
            this.lblStudentNoData.Name = "lblStudentNoData";
            this.lblStudentNoData.Size = new System.Drawing.Size(73, 19);
            this.lblStudentNoData.TabIndex = 23;
            this.lblStudentNoData.Text = "00000000";
            // 
            // lblStudentNameData
            // 
            this.lblStudentNameData.AutoSize = true;
            this.lblStudentNameData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNameData.ForeColor = System.Drawing.Color.Black;
            this.lblStudentNameData.Location = new System.Drawing.Point(417, 47);
            this.lblStudentNameData.Name = "lblStudentNameData";
            this.lblStudentNameData.Size = new System.Drawing.Size(73, 19);
            this.lblStudentNameData.TabIndex = 28;
            this.lblStudentNameData.Text = "00000000";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(302, 47);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 19);
            this.lblStudentName.TabIndex = 27;
            this.lblStudentName.Text = "Öğrenci İsmi ..:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(768, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // btnListAvg
            // 
            this.btnListAvg.BackColor = System.Drawing.Color.Red;
            this.btnListAvg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListAvg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListAvg.Location = new System.Drawing.Point(780, 217);
            this.btnListAvg.Name = "btnListAvg";
            this.btnListAvg.Size = new System.Drawing.Size(151, 85);
            this.btnListAvg.TabIndex = 31;
            this.btnListAvg.Text = "Not Ortalamasını Görünüz ";
            this.btnListAvg.UseVisualStyleBackColor = false;
            this.btnListAvg.Click += new System.EventHandler(this.btnListAvg_Click);
            // 
            // FrmÖğrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(957, 513);
            this.Controls.Add(this.btnListAvg);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblStudentNameData);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblStudentNoData);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMessage);
            this.Name = "FrmÖğrenci";
            this.Text = "Öğrenci Ekranı";
            this.Load += new System.EventHandler(this.FrmÖğrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblStudentNoData;
        private System.Windows.Forms.Label lblStudentNameData;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnListAvg;
    }
}