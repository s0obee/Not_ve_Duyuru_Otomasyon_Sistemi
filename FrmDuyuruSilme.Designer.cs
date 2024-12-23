namespace Visual
{
    partial class FrmDuyuruSilme
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
            this.btnAnnouncmentDelete = new System.Windows.Forms.Button();
            this.lblAnnouncmentHeader = new System.Windows.Forms.Label();
            this.cmbHeader = new System.Windows.Forms.ComboBox();
            this.lblTeacherNoData = new System.Windows.Forms.Label();
            this.lblTeacherNo = new System.Windows.Forms.Label();
            this.lblTeacherNameData = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAnnouncmentDelete
            // 
            this.btnAnnouncmentDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnnouncmentDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnnouncmentDelete.Location = new System.Drawing.Point(45, 191);
            this.btnAnnouncmentDelete.Name = "btnAnnouncmentDelete";
            this.btnAnnouncmentDelete.Size = new System.Drawing.Size(247, 31);
            this.btnAnnouncmentDelete.TabIndex = 20;
            this.btnAnnouncmentDelete.Text = "Sil";
            this.btnAnnouncmentDelete.UseVisualStyleBackColor = false;
            this.btnAnnouncmentDelete.Click += new System.EventHandler(this.btnAnnouncmentDelete_Click);
            // 
            // lblAnnouncmentHeader
            // 
            this.lblAnnouncmentHeader.AutoSize = true;
            this.lblAnnouncmentHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncmentHeader.ForeColor = System.Drawing.Color.Black;
            this.lblAnnouncmentHeader.Location = new System.Drawing.Point(41, 134);
            this.lblAnnouncmentHeader.Name = "lblAnnouncmentHeader";
            this.lblAnnouncmentHeader.Size = new System.Drawing.Size(123, 19);
            this.lblAnnouncmentHeader.TabIndex = 21;
            this.lblAnnouncmentHeader.Text = "Duyuru Başlığı ..:";
            // 
            // cmbHeader
            // 
            this.cmbHeader.FormattingEnabled = true;
            this.cmbHeader.Location = new System.Drawing.Point(171, 131);
            this.cmbHeader.Name = "cmbHeader";
            this.cmbHeader.Size = new System.Drawing.Size(121, 21);
            this.cmbHeader.TabIndex = 22;
            // 
            // lblTeacherNoData
            // 
            this.lblTeacherNoData.AutoSize = true;
            this.lblTeacherNoData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNoData.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherNoData.Location = new System.Drawing.Point(230, 21);
            this.lblTeacherNoData.Name = "lblTeacherNoData";
            this.lblTeacherNoData.Size = new System.Drawing.Size(73, 19);
            this.lblTeacherNoData.TabIndex = 25;
            this.lblTeacherNoData.Text = "00000000";
            // 
            // lblTeacherNo
            // 
            this.lblTeacherNo.AutoSize = true;
            this.lblTeacherNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNo.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherNo.Location = new System.Drawing.Point(12, 21);
            this.lblTeacherNo.Name = "lblTeacherNo";
            this.lblTeacherNo.Size = new System.Drawing.Size(212, 19);
            this.lblTeacherNo.TabIndex = 24;
            this.lblTeacherNo.Text = "Öğretim Görevlisi Numarası ..:";
            // 
            // lblTeacherNameData
            // 
            this.lblTeacherNameData.AutoSize = true;
            this.lblTeacherNameData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNameData.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherNameData.Location = new System.Drawing.Point(205, 50);
            this.lblTeacherNameData.Name = "lblTeacherNameData";
            this.lblTeacherNameData.Size = new System.Drawing.Size(73, 19);
            this.lblTeacherNameData.TabIndex = 27;
            this.lblTeacherNameData.Text = "00000000";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherName.Location = new System.Drawing.Point(12, 50);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(174, 19);
            this.lblTeacherName.TabIndex = 26;
            this.lblTeacherName.Text = "Öğretim Görevlisi İsmi ..:";
            // 
            // FrmDuyuruSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(327, 315);
            this.Controls.Add(this.lblTeacherNameData);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacherNoData);
            this.Controls.Add(this.lblTeacherNo);
            this.Controls.Add(this.cmbHeader);
            this.Controls.Add(this.lblAnnouncmentHeader);
            this.Controls.Add(this.btnAnnouncmentDelete);
            this.Name = "FrmDuyuruSilme";
            this.Text = "FrmDuyuruSilme";
            this.Load += new System.EventHandler(this.FrmDuyuruSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnouncmentDelete;
        private System.Windows.Forms.Label lblAnnouncmentHeader;
        private System.Windows.Forms.ComboBox cmbHeader;
        private System.Windows.Forms.Label lblTeacherNoData;
        private System.Windows.Forms.Label lblTeacherNo;
        private System.Windows.Forms.Label lblTeacherNameData;
        private System.Windows.Forms.Label lblTeacherName;
    }
}