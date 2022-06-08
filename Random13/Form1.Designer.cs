namespace CurrencyModel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numEuro = new System.Windows.Forms.NumericUpDown();
            this.numDollar = new System.Windows.Forms.NumericUpDown();
            this.numTimeStep = new System.Windows.Forms.NumericUpDown();
            this.btn_StartStop = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerDays = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Euro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dollar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Timer step (ms)";
            // 
            // numEuro
            // 
            this.numEuro.DecimalPlaces = 4;
            this.numEuro.Location = new System.Drawing.Point(55, 30);
            this.numEuro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numEuro.Name = "numEuro";
            this.numEuro.Size = new System.Drawing.Size(120, 20);
            this.numEuro.TabIndex = 4;
            this.numEuro.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numDollar
            // 
            this.numDollar.DecimalPlaces = 4;
            this.numDollar.Location = new System.Drawing.Point(55, 57);
            this.numDollar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDollar.Name = "numDollar";
            this.numDollar.Size = new System.Drawing.Size(120, 20);
            this.numDollar.TabIndex = 5;
            this.numDollar.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numTimeStep
            // 
            this.numTimeStep.DecimalPlaces = 1;
            this.numTimeStep.Location = new System.Drawing.Point(265, 30);
            this.numTimeStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeStep.Name = "numTimeStep";
            this.numTimeStep.Size = new System.Drawing.Size(120, 20);
            this.numTimeStep.TabIndex = 6;
            this.numTimeStep.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btn_StartStop
            // 
            this.btn_StartStop.Location = new System.Drawing.Point(418, 30);
            this.btn_StartStop.Name = "btn_StartStop";
            this.btn_StartStop.Size = new System.Drawing.Size(121, 47);
            this.btn_StartStop.TabIndex = 7;
            this.btn_StartStop.Text = "Start";
            this.btn_StartStop.UseVisualStyleBackColor = true;
            this.btn_StartStop.Click += new System.EventHandler(this.btn_StartStop_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, 83);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "C";
            series1.Legend = "Legend1";
            series1.Name = "Euro";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "C";
            series2.Legend = "Legend1";
            series2.Name = "$";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(985, 576);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // timerDays
            // 
            this.timerDays.Tick += new System.EventHandler(this.timerDays_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_StartStop);
            this.Controls.Add(this.numTimeStep);
            this.Controls.Add(this.numDollar);
            this.Controls.Add(this.numEuro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEuro;
        private System.Windows.Forms.NumericUpDown numDollar;
        private System.Windows.Forms.NumericUpDown numTimeStep;
        private System.Windows.Forms.Button btn_StartStop;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timerDays;
    }
}

