namespace SPZ_lab_2.Forms
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.BooksByAuthorsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BooksByAuthorsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksByAuthorsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BooksByAuthorsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BooksByAuthorsChart.Legends.Add(legend1);
            this.BooksByAuthorsChart.Location = new System.Drawing.Point(96, 125);
            this.BooksByAuthorsChart.Name = "BooksByAuthorsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "BooksByAuthors";
            this.BooksByAuthorsChart.Series.Add(series1);
            this.BooksByAuthorsChart.Size = new System.Drawing.Size(300, 300);
            this.BooksByAuthorsChart.TabIndex = 0;
            this.BooksByAuthorsChart.Text = "chart1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 513);
            this.Controls.Add(this.BooksByAuthorsChart);
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.BooksByAuthorsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart BooksByAuthorsChart;
    }
}