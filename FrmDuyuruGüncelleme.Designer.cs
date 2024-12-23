namespace Visual
{
    partial class FrmDuyuruGüncelleme
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
            this.rtxComments = new System.Windows.Forms.RichTextBox();
            this.lblAnnouncment = new System.Windows.Forms.Label();
            this.lblAnnouncmentHeader = new System.Windows.Forms.Label();
            this.btnAnnouncmentUpdate = new System.Windows.Forms.Button();
            this.cmbUpdateAnnouncments = new System.Windows.Forms.ComboBox();
            this.txtAnnouncmentsHeader = new System.Windows.Forms.TextBox();
            this.lblTeacherNoData = new System.Windows.Forms.Label();
            this.lblTeacherNo = new System.Windows.Forms.Label();
            this.lblTeacherNameData = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtxComments
            // 
            this.rtxComments.Location = new System.Drawing.Point(212, 156);
            this.rtxComments.Name = "rtxComments";
            this.rtxComments.Size = new System.Drawing.Size(462, 143);
            this.rtxComments.TabIndex = 20;
            this.rtxComments.Text = "";
            // 
            // lblAnnouncment
            // 
            this.lblAnnouncment.AutoSize = true;
            this.lblAnnouncment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncment.ForeColor = System.Drawing.Color.Black;
            this.lblAnnouncment.Location = new System.Drawing.Point(126, 156);
            this.lblAnnouncment.Name = "lblAnnouncment";
            this.lblAnnouncment.Size = new System.Drawing.Size(80, 19);
            this.lblAnnouncment.TabIndex = 19;
            this.lblAnnouncment.Text = "Duyuru  ..:";
            // 
            // lblAnnouncmentHeader
            // 
            this.lblAnnouncmentHeader.AutoSize = true;
            this.lblAnnouncmentHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnnouncmentHeader.ForeColor = System.Drawing.Color.Black;
            this.lblAnnouncmentHeader.Location = new System.Drawing.Point(83, 117);
            this.lblAnnouncmentHeader.Name = "lblAnnouncmentHeader";
            this.lblAnnouncmentHeader.Size = new System.Drawing.Size(123, 19);
            this.lblAnnouncmentHeader.TabIndex = 17;
            this.lblAnnouncmentHeader.Text = "Duyuru Başlığı ..:";
            // 
            // btnAnnouncmentUpdate
            // 
            this.btnAnnouncmentUpdate.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAnnouncmentUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnnouncmentUpdate.Location = new System.Drawing.Point(87, 354);
            this.btnAnnouncmentUpdate.Name = "btnAnnouncmentUpdate";
            this.btnAnnouncmentUpdate.Size = new System.Drawing.Size(587, 31);
            this.btnAnnouncmentUpdate.TabIndex = 21;
            this.btnAnnouncmentUpdate.Text = "Güncelle";
            this.btnAnnouncmentUpdate.UseVisualStyleBackColor = false;
            this.btnAnnouncmentUpdate.Click += new System.EventHandler(this.btnAnnouncmentUpdate_Click);
            // 
            // cmbUpdateAnnouncments
            // 
            this.cmbUpdateAnnouncments.FormattingEnabled = true;
            this.cmbUpdateAnnouncments.Location = new System.Drawing.Point(213, 69);
            this.cmbUpdateAnnouncments.Name = "cmbUpdateAnnouncments";
            this.cmbUpdateAnnouncments.Size = new System.Drawing.Size(461, 21);
            this.cmbUpdateAnnouncments.TabIndex = 22;
            this.cmbUpdateAnnouncments.SelectedIndexChanged += new System.EventHandler(this.cmbUpdateAnnouncments_SelectedIndexChanged);
            // 
            // txtAnnouncmentsHeader
            // 
            this.txtAnnouncmentsHeader.Location = new System.Drawing.Point(213, 115);
            this.txtAnnouncmentsHeader.Name = "txtAnnouncmentsHeader";
            this.txtAnnouncmentsHeader.Size = new System.Drawing.Size(461, 20);
            this.txtAnnouncmentsHeader.TabIndex = 23;
            // 
            // lblTeacherNoData
            // 
            this.lblTeacherNoData.AutoSize = true;
            this.lblTeacherNoData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherNoData.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherNoData.Location = new System.Drawing.Point(303, 9);
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
            this.lblTeacherNo.Location = new System.Drawing.Point(85, 9);
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
            this.lblTeacherNameData.Location = new System.Drawing.Point(605, 9);
            this.lblTeacherNameData.Name = "lblTeacherNameData";
            this.lblTeacherNameData.Size = new System.Drawing.Size(73, 19);
            this.lblTeacherNameData.TabIndex = 29;
            this.lblTeacherNameData.Text = "00000000";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacherName.ForeColor = System.Drawing.Color.Black;
            this.lblTeacherName.Location = new System.Drawing.Point(412, 9);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(174, 19);
            this.lblTeacherName.TabIndex = 28;
            this.lblTeacherName.Text = "Öğretim Görevlisi İsmi ..:";
            // 
            // FrmDuyuruGüncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(780, 445);
            this.Controls.Add(this.lblTeacherNameData);
            this.Controls.Add(this.lblTeacherName);
            this.Controls.Add(this.lblTeacherNoData);
            this.Controls.Add(this.lblTeacherNo);
            this.Controls.Add(this.txtAnnouncmentsHeader);
            this.Controls.Add(this.cmbUpdateAnnouncments);
            this.Controls.Add(this.btnAnnouncmentUpdate);
            this.Controls.Add(this.rtxComments);
            this.Controls.Add(this.lblAnnouncment);
            this.Controls.Add(this.lblAnnouncmentHeader);
            this.Name = "FrmDuyuruGüncelleme";
            this.Text = "FrmDuyuruGüncelleme";
            this.Load += new System.EventHandler(this.FrmDuyuruGüncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxComments;
        private System.Windows.Forms.Label lblAnnouncment;
        private System.Windows.Forms.Label lblAnnouncmentHeader;
        private System.Windows.Forms.Button btnAnnouncmentUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateAnnouncments;
        private System.Windows.Forms.TextBox txtAnnouncmentsHeader;
        private System.Windows.Forms.Label lblTeacherNoData;
        private System.Windows.Forms.Label lblTeacherNo;
        private System.Windows.Forms.Label lblTeacherNameData;
        private System.Windows.Forms.Label lblTeacherName;
    }
}