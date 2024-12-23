namespace Visual
{
    partial class FrmSınıfOrtalaması
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnList = new System.Windows.Forms.Button();
            this.cmbLessonInfo = new System.Windows.Forms.ComboBox();
            this.lblLessonInfo = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStudentNoData = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Button();
            this.lblStudentNameData = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Red;
            this.btnList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnList.Location = new System.Drawing.Point(677, 250);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(246, 43);
            this.btnList.TabIndex = 42;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click_1);
            // 
            // cmbLessonInfo
            // 
            this.cmbLessonInfo.FormattingEnabled = true;
            this.cmbLessonInfo.Location = new System.Drawing.Point(773, 141);
            this.cmbLessonInfo.Name = "cmbLessonInfo";
            this.cmbLessonInfo.Size = new System.Drawing.Size(150, 21);
            this.cmbLessonInfo.TabIndex = 41;
            // 
            // lblLessonInfo
            // 
            this.lblLessonInfo.AutoSize = true;
            this.lblLessonInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLessonInfo.ForeColor = System.Drawing.Color.Black;
            this.lblLessonInfo.Location = new System.Drawing.Point(673, 143);
            this.lblLessonInfo.Name = "lblLessonInfo";
            this.lblLessonInfo.Size = new System.Drawing.Size(82, 19);
            this.lblLessonInfo.TabIndex = 40;
            this.lblLessonInfo.Text = "Ders Adı ..:";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(29, 83);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(601, 427);
            this.chart1.TabIndex = 39;
            this.chart1.Text = "chart1";
            // 
            // lblStudentNoData
            // 
            this.lblStudentNoData.AutoSize = true;
            this.lblStudentNoData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNoData.ForeColor = System.Drawing.Color.Black;
            this.lblStudentNoData.Location = new System.Drawing.Point(178, 35);
            this.lblStudentNoData.Name = "lblStudentNoData";
            this.lblStudentNoData.Size = new System.Drawing.Size(73, 19);
            this.lblStudentNoData.TabIndex = 38;
            this.lblStudentNoData.Text = "00000000";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNo.ForeColor = System.Drawing.Color.Black;
            this.lblStudentNo.Location = new System.Drawing.Point(25, 35);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(147, 19);
            this.lblStudentNo.TabIndex = 37;
            this.lblStudentNo.Text = "Öğrenci Numarası ..:";
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.SpringGreen;
            this.lblBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBack.Location = new System.Drawing.Point(677, 467);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(246, 43);
            this.lblBack.TabIndex = 43;
            this.lblBack.Text = "Öğrenci Sayfasına Geri Dön";
            this.lblBack.UseVisualStyleBackColor = false;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // lblStudentNameData
            // 
            this.lblStudentNameData.AutoSize = true;
            this.lblStudentNameData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentNameData.ForeColor = System.Drawing.Color.Black;
            this.lblStudentNameData.Location = new System.Drawing.Point(388, 35);
            this.lblStudentNameData.Name = "lblStudentNameData";
            this.lblStudentNameData.Size = new System.Drawing.Size(73, 19);
            this.lblStudentNameData.TabIndex = 45;
            this.lblStudentNameData.Text = "00000000";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStudentName.ForeColor = System.Drawing.Color.Black;
            this.lblStudentName.Location = new System.Drawing.Point(273, 35);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(109, 19);
            this.lblStudentName.TabIndex = 44;
            this.lblStudentName.Text = "Öğrenci İsmi ..:";
            // 
            // FrmSınıfOrtalaması
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(948, 544);
            this.Controls.Add(this.lblStudentNameData);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.cmbLessonInfo);
            this.Controls.Add(this.lblLessonInfo);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblStudentNoData);
            this.Controls.Add(this.lblStudentNo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmSınıfOrtalaması";
            this.Text = "FrmSınıfOrtalaması";
            this.Load += new System.EventHandler(this.FrmSınıfOrtalaması_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox cmbLessonInfo;
        private System.Windows.Forms.Label lblLessonInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblStudentNoData;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Button lblBack;
        private System.Windows.Forms.Label lblStudentNameData;
        private System.Windows.Forms.Label lblStudentName;
    }
}