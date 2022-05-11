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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbTrialsLog = new System.Windows.Forms.Label();
            this.btnTrialsStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTrialsAmount = new System.Windows.Forms.NumericUpDown();
            this.dgvProbData = new System.Windows.Forms.DataGridView();
            this.Chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cTrialsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbAverage = new System.Windows.Forms.Label();
            this.lbVariance = new System.Windows.Forms.Label();
            this.lbChi = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrialsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbData)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTrialsChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbTrialsLog);
            this.tabPage3.Controls.Add(this.btnTrialsStart);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.nudTrialsAmount);
            this.tabPage3.Controls.Add(this.dgvProbData);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(452, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Серия экспериментов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbTrialsLog
            // 
            this.lbTrialsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrialsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTrialsLog.Location = new System.Drawing.Point(155, 108);
            this.lbTrialsLog.Name = "lbTrialsLog";
            this.lbTrialsLog.Size = new System.Drawing.Size(294, 200);
            this.lbTrialsLog.TabIndex = 4;
            this.lbTrialsLog.Text = "Ожидание старта";
            // 
            // btnTrialsStart
            // 
            this.btnTrialsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrialsStart.Location = new System.Drawing.Point(155, 71);
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
            this.label2.Location = new System.Drawing.Point(151, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество испытаний";
            // 
            // nudTrialsAmount
            // 
            this.nudTrialsAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudTrialsAmount.Location = new System.Drawing.Point(155, 38);
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
            // dgvProbData
            // 
            this.dgvProbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chance});
            this.dgvProbData.Location = new System.Drawing.Point(3, 3);
            this.dgvProbData.Name = "dgvProbData";
            this.dgvProbData.Size = new System.Drawing.Size(142, 305);
            this.dgvProbData.TabIndex = 0;
            this.dgvProbData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProbData_CellValueChanged);
            // 
            // Chance
            // 
            this.Chance.HeaderText = "Шанс события, %";
            this.Chance.Name = "Chance";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.cTrialsChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(452, 442);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "График экспериментов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cTrialsChart
            // 
            this.cTrialsChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisY.Maximum = 1D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.AxisY.Title = "Частота";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.Name = "ChartArea1";
            this.cTrialsChart.ChartAreas.Add(chartArea2);
            this.cTrialsChart.Location = new System.Drawing.Point(3, 3);
            this.cTrialsChart.Name = "cTrialsChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.IsValueShownAsLabel = true;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Label = "#PERCENT{N3}";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.YValuesPerPoint = 2;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cTrialsChart.Series.Add(series2);
            this.cTrialsChart.Size = new System.Drawing.Size(446, 305);
            this.cTrialsChart.TabIndex = 0;
            this.cTrialsChart.Text = "chart1";
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
            this.panel1.Location = new System.Drawing.Point(3, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 125);
            this.panel1.TabIndex = 1;
            // 
            // lbAverage
            // 
            this.lbAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAverage.Location = new System.Drawing.Point(15, 11);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(409, 23);
            this.lbAverage.TabIndex = 0;
            this.lbAverage.Text = "Average: ";
            this.lbAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVariance
            // 
            this.lbVariance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbVariance.Location = new System.Drawing.Point(15, 44);
            this.lbVariance.Name = "lbVariance";
            this.lbVariance.Size = new System.Drawing.Size(413, 23);
            this.lbVariance.TabIndex = 1;
            this.lbVariance.Text = "Variance:";
            this.lbVariance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbChi.Size = new System.Drawing.Size(409, 26);
            this.lbChi.TabIndex = 2;
            this.lbChi.Text = "Chi-squared: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 492);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Случайные события";
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrialsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbData)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTrialsChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvProbData;
        private System.Windows.Forms.Label lbTrialsLog;
        private System.Windows.Forms.Button btnTrialsStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTrialsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTrialsChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox lbChi;
        private System.Windows.Forms.Label lbVariance;
        private System.Windows.Forms.Label lbAverage;
    }
}

