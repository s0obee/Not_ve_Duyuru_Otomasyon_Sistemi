namespace Visual
{
    partial class FrmÖğretimGörevlisiGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmÖğretimGörevlisiGiriş));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblTeacherPassword = new System.Windows.Forms.Label();
            this.txtTeacherPassword = new System.Windows.Forms.TextBox();
            this.lblTeacherEmail = new System.Windows.Forms.Label();
            this.txtTeacherEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(390, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 194);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogIn.Location = new System.Drawing.Point(76, 193);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(261, 49);
            this.btnLogIn.TabIndex = 21;
            this.btnLogIn.Text = "Giriş";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(618, 26);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Karabük Üniversitesi Otomasyon Sistemi Öğretim Görevlisi Giriş Ekranı";
            // 
            // lblTeacherPassword
            // 
            this.lblTeacherPassword.AutoSize = true;
            this.lblTeacherPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherPassword.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherPassword.Location = new System.Drawing.Point(47, 149);
            this.lblTeacherPassword.Name = "lblTeacherPassword";
            this.lblTeacherPassword.Size = new System.Drawing.Size(178, 19);
            this.lblTeacherPassword.TabIndex = 17;
            this.lblTeacherPassword.Text = "Öğretim Görevlisi Şifre ..:";
            // 
            // txtTeacherPassword
            // 
            this.txtTeacherPassword.Location = new System.Drawing.Point(231, 148);
            this.txtTeacherPassword.Name = "txtTeacherPassword";
            this.txtTeacherPassword.PasswordChar = '*';
            this.txtTeacherPassword.Size = new System.Drawing.Size(140, 20);
            this.txtTeacherPassword.TabIndex = 18;
            // 
            // lblTeacherEmail
            // 
            this.lblTeacherEmail.AutoSize = true;
            this.lblTeacherEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherEmail.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherEmail.Location = new System.Drawing.Point(41, 112);
            this.lblTeacherEmail.Name = "lblTeacherEmail";
            this.lblTeacherEmail.Size = new System.Drawing.Size(184, 19);
            this.lblTeacherEmail.TabIndex = 19;
            this.lblTeacherEmail.Text = "Öğretim Görevlisi Email ..:";
            // 
            // txtTeacherEmail
            // 
            this.txtTeacherEmail.Location = new System.Drawing.Point(231, 111);
            this.txtTeacherEmail.Name = "txtTeacherEmail";
            this.txtTeacherEmail.Size = new System.Drawing.Size(140, 20);
            this.txtTeacherEmail.TabIndex = 20;
            // 
            // FrmÖğretimGörevlisiGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(636, 322);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtTeacherEmail);
            this.Controls.Add(this.lblTeacherEmail);
            this.Controls.Add(this.txtTeacherPassword);
            this.Controls.Add(this.lblTeacherPassword);
            this.Controls.Add(this.lblMessage);
            this.Name = "FrmÖğretimGörevlisiGiriş";
            this.Text = "Öğretim Görevlisi Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblTeacherPassword;
        private System.Windows.Forms.TextBox txtTeacherPassword;
        private System.Windows.Forms.Label lblTeacherEmail;
        private System.Windows.Forms.TextBox txtTeacherEmail;
    }
}