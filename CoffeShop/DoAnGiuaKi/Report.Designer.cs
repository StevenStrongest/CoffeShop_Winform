namespace DoAnGiuaKi
{
    partial class Report
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
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.ChartReport = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.ChartReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartReport
            // 
            this.ChartReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartReport.Legend.Name = "Default Legend";
            this.ChartReport.Location = new System.Drawing.Point(0, 0);
            this.ChartReport.Name = "ChartReport";
            this.ChartReport.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ChartReport.Size = new System.Drawing.Size(1143, 565);
            this.ChartReport.TabIndex = 0;
            chartTitle1.Text = "Món Ăn Bán Chạy";
            this.ChartReport.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // Report
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1143, 565);
            this.Controls.Add(this.ChartReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.ChartReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl ChartReport;
    }
}