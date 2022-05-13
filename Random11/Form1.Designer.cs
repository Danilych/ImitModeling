namespace Random8
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnTrialsStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTrialsAmount = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbChi = new System.Windows.Forms.RichTextBox();
            this.lbVariance = new System.Windows.Forms.Label();
            this.lbAverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMathExpect = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMathVariance = new System.Windows.Forms.NumericUpDown();
            this.chartNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrialsAmount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMathExpect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMathVariance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrialsStart
            // 
            this.btnTrialsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrialsStart.Location = new System.Drawing.Point(16, 214);
            this.btnTrialsStart.Name = "btnTrialsStart";
            this.btnTrialsStart.Size = new System.Drawing.Size(75, 30);
            this.btnTrialsStart.TabIndex = 3;
            this.btnTrialsStart.Text = "Начать";
            this.btnTrialsStart.UseVisualStyleBackColor = true;
            this.btnTrialsStart.Click += new System.EventHandler(this.btnTrialsStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество испытаний";
            // 
            // nudTrialsAmount
            // 
            this.nudTrialsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTrialsAmount.Location = new System.Drawing.Point(16, 35);
            this.nudTrialsAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTrialsAmount.Name = "nudTrialsAmount";
            this.nudTrialsAmount.Size = new System.Drawing.Size(120, 26);
            this.nudTrialsAmount.TabIndex = 1;
            this.nudTrialsAmount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lbChi);
            this.panel1.Controls.Add(this.lbVariance);
            this.panel1.Controls.Add(this.lbAverage);
            this.panel1.Location = new System.Drawing.Point(218, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 125);
            this.panel1.TabIndex = 1;
            // 
            // lbChi
            // 
            this.lbChi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChi.BackColor = System.Drawing.Color.Gainsboro;
            this.lbChi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbChi.Location = new System.Drawing.Point(15, 79);
            this.lbChi.Multiline = false;
            this.lbChi.Name = "lbChi";
            this.lbChi.ReadOnly = true;
            this.lbChi.Size = new System.Drawing.Size(288, 26);
            this.lbChi.TabIndex = 2;
            this.lbChi.Text = "Chi-squared: ";
            // 
            // lbVariance
            // 
            this.lbVariance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVariance.Location = new System.Drawing.Point(15, 44);
            this.lbVariance.Name = "lbVariance";
            this.lbVariance.Size = new System.Drawing.Size(292, 23);
            this.lbVariance.TabIndex = 1;
            this.lbVariance.Text = "Variance:";
            this.lbVariance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAverage
            // 
            this.lbAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAverage.Location = new System.Drawing.Point(15, 11);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(288, 23);
            this.lbAverage.TabIndex = 0;
            this.lbAverage.Text = "Average: ";
            this.lbAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Мат. ожидание";
            // 
            // nudMathExpect
            // 
            this.nudMathExpect.DecimalPlaces = 3;
            this.nudMathExpect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudMathExpect.Location = new System.Drawing.Point(17, 88);
            this.nudMathExpect.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMathExpect.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.nudMathExpect.Name = "nudMathExpect";
            this.nudMathExpect.Size = new System.Drawing.Size(120, 26);
            this.nudMathExpect.TabIndex = 4;
            this.nudMathExpect.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дисперсия";
            // 
            // nudMathVariance
            // 
            this.nudMathVariance.DecimalPlaces = 3;
            this.nudMathVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudMathVariance.Location = new System.Drawing.Point(17, 140);
            this.nudMathVariance.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMathVariance.Name = "nudMathVariance";
            this.nudMathVariance.Size = new System.Drawing.Size(120, 26);
            this.nudMathVariance.TabIndex = 6;
            this.nudMathVariance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chartNormal
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Format = "##.###";
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chartNormal.ChartAreas.Add(chartArea1);
            this.chartNormal.Location = new System.Drawing.Point(218, 12);
            this.chartNormal.Name = "chartNormal";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "LabelStyle=Bottom";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Label = "#VAL{N2}";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartNormal.Series.Add(series1);
            this.chartNormal.Series.Add(series2);
            this.chartNormal.Size = new System.Drawing.Size(653, 337);
            this.chartNormal.TabIndex = 8;
            this.chartNormal.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 492);
            this.Controls.Add(this.chartNormal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMathVariance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMathExpect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTrialsStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTrialsAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Случайные события";
            ((System.ComponentModel.ISupportInitialize)(this.nudTrialsAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMathExpect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMathVariance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTrialsStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTrialsAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox lbChi;
        private System.Windows.Forms.Label lbVariance;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMathExpect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMathVariance;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNormal;
    }
}

