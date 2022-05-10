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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbAnswerEventOne = new System.Windows.Forms.Label();
            this.btnEventOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudOChanceOneEvent = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.lbAnswerBallEight = new System.Windows.Forms.Label();
            this.btnBallEight = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbTrialsLog = new System.Windows.Forms.Label();
            this.btnTrialsStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTrialsAmount = new System.Windows.Forms.NumericUpDown();
            this.dgvProbData = new System.Windows.Forms.DataGridView();
            this.Chance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cTrialsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOChanceOneEvent)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrialsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbData)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTrialsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbAnswerEventOne);
            this.tabPage1.Controls.Add(this.btnEventOne);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nudOChanceOneEvent);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Одно событие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbAnswerEventOne
            // 
            this.lbAnswerEventOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAnswerEventOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnswerEventOne.Location = new System.Drawing.Point(27, 188);
            this.lbAnswerEventOne.Name = "lbAnswerEventOne";
            this.lbAnswerEventOne.Size = new System.Drawing.Size(400, 51);
            this.lbAnswerEventOne.TabIndex = 4;
            this.lbAnswerEventOne.Text = "Ответ";
            this.lbAnswerEventOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEventOne
            // 
            this.btnEventOne.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEventOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEventOne.Location = new System.Drawing.Point(282, 100);
            this.btnEventOne.Name = "btnEventOne";
            this.btnEventOne.Size = new System.Drawing.Size(145, 26);
            this.btnEventOne.TabIndex = 3;
            this.btnEventOne.Text = "Ответ";
            this.btnEventOne.UseVisualStyleBackColor = true;
            this.btnEventOne.Click += new System.EventHandler(this.btnEventOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Шанс, %";
            // 
            // nudOChanceOneEvent
            // 
            this.nudOChanceOneEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudOChanceOneEvent.Location = new System.Drawing.Point(27, 100);
            this.nudOChanceOneEvent.Name = "nudOChanceOneEvent";
            this.nudOChanceOneEvent.Size = new System.Drawing.Size(49, 26);
            this.nudOChanceOneEvent.TabIndex = 1;
            this.nudOChanceOneEvent.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(27, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Идти в университет?";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lbAnswerBallEight);
            this.tabPage2.Controls.Add(this.btnBallEight);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Группа событий";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Магический шар 8";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAnswerBallEight
            // 
            this.lbAnswerBallEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnswerBallEight.Location = new System.Drawing.Point(6, 161);
            this.lbAnswerBallEight.Name = "lbAnswerBallEight";
            this.lbAnswerBallEight.Size = new System.Drawing.Size(340, 127);
            this.lbAnswerBallEight.TabIndex = 7;
            this.lbAnswerBallEight.Text = "Пока не ясно, попробуй снова";
            // 
            // btnBallEight
            // 
            this.btnBallEight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBallEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBallEight.Location = new System.Drawing.Point(281, 109);
            this.btnBallEight.Name = "btnBallEight";
            this.btnBallEight.Size = new System.Drawing.Size(145, 26);
            this.btnBallEight.TabIndex = 6;
            this.btnBallEight.Text = "Ответ";
            this.btnBallEight.UseVisualStyleBackColor = true;
            this.btnBallEight.Click += new System.EventHandler(this.btnBallEight_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(26, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 26);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Идти в университет?";
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
            this.tabPage4.Controls.Add(this.cTrialsChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(452, 311);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "График экспериментов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cTrialsChart
            // 
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Частота";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.cTrialsChart.ChartAreas.Add(chartArea1);
            this.cTrialsChart.Location = new System.Drawing.Point(3, 3);
            this.cTrialsChart.Name = "cTrialsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.Label = "#PERCENT{N3}";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.cTrialsChart.Series.Add(series1);
            this.cTrialsChart.Size = new System.Drawing.Size(446, 305);
            this.cTrialsChart.TabIndex = 0;
            this.cTrialsChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Случайные события";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOChanceOneEvent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTrialsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbData)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTrialsChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbAnswerEventOne;
        private System.Windows.Forms.Button btnEventOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudOChanceOneEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbAnswerBallEight;
        private System.Windows.Forms.Button btnBallEight;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvProbData;
        private System.Windows.Forms.Label lbTrialsLog;
        private System.Windows.Forms.Button btnTrialsStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTrialsAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chance;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart cTrialsChart;
    }
}

