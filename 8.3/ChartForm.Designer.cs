namespace Lab8._3.EventsGeneration
{
	partial class ChartForm
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
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chartPanel = new System.Windows.Forms.Panel();
			this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
			this.SuspendLayout();
			// 
			// chartPanel
			// 
			this.chartPanel.Controls.Add(this.mainChart);
			this.chartPanel.Location = new System.Drawing.Point(12, 12);
			this.chartPanel.Name = "chartPanel";
			this.chartPanel.Size = new System.Drawing.Size(891, 535);
			this.chartPanel.TabIndex = 0;
			// 
			// mainChart
			// 
			chartArea1.AxisX.Maximum = 6D;
			chartArea1.AxisY.Maximum = 1D;
			chartArea1.Name = "ChartArea1";
			this.mainChart.ChartAreas.Add(chartArea1);
			this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainChart.Location = new System.Drawing.Point(0, 0);
			this.mainChart.Name = "mainChart";
			series1.ChartArea = "ChartArea1";
			series1.Name = "Series1";
			this.mainChart.Series.Add(series1);
			this.mainChart.Size = new System.Drawing.Size(891, 535);
			this.mainChart.TabIndex = 0;
			this.mainChart.Text = "chart1";
			// 
			// ChartForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 559);
			this.Controls.Add(this.chartPanel);
			this.Name = "ChartForm";
			this.Text = "ChartForm";
			this.chartPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel chartPanel;
		private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
	}
}