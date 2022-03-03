namespace CellLifeModel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textLog = new System.Windows.Forms.RichTextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.numTimer = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStep = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.timerDraw = new System.Windows.Forms.Timer(this.components);
            this.picAutomat = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timerCodeWaiting = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.labelGen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAutomat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textLog);
            this.groupBox1.Controls.Add(this.btnGen);
            this.groupBox1.Controls.Add(this.numRows);
            this.groupBox1.Controls.Add(this.numColumns);
            this.groupBox1.Controls.Add(this.numTimer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // textLog
            // 
            this.textLog.DetectUrls = false;
            this.textLog.Location = new System.Drawing.Point(6, 45);
            this.textLog.Name = "textLog";
            this.textLog.ReadOnly = true;
            this.textLog.Size = new System.Drawing.Size(200, 89);
            this.textLog.TabIndex = 3;
            this.textLog.Text = "Click generate for table generation";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(6, 193);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(200, 44);
            this.btnGen.TabIndex = 8;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(86, 167);
            this.numRows.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(120, 20);
            this.numRows.TabIndex = 7;
            this.numRows.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numColumns
            // 
            this.numColumns.Location = new System.Drawing.Point(86, 140);
            this.numColumns.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(120, 20);
            this.numColumns.TabIndex = 6;
            this.numColumns.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numTimer
            // 
            this.numTimer.Location = new System.Drawing.Point(86, 19);
            this.numTimer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numTimer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTimer.Name = "numTimer";
            this.numTimer.Size = new System.Drawing.Size(120, 20);
            this.numTimer.TabIndex = 5;
            this.numTimer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rows";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Timer Tick";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStep);
            this.groupBox2.Controls.Add(this.btnStartStop);
            this.groupBox2.Location = new System.Drawing.Point(12, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // btnStep
            // 
            this.btnStep.Enabled = false;
            this.btnStep.Location = new System.Drawing.Point(6, 48);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(200, 23);
            this.btnStep.TabIndex = 1;
            this.btnStep.Text = "Make Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Enabled = false;
            this.btnStartStop.Location = new System.Drawing.Point(6, 19);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(200, 23);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // timerDraw
            // 
            this.timerDraw.Tick += new System.EventHandler(this.timerDraw_Tick);
            // 
            // picAutomat
            // 
            this.picAutomat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picAutomat.BackColor = System.Drawing.Color.White;
            this.picAutomat.Location = new System.Drawing.Point(230, 12);
            this.picAutomat.Name = "picAutomat";
            this.picAutomat.Size = new System.Drawing.Size(542, 537);
            this.picAutomat.TabIndex = 2;
            this.picAutomat.TabStop = false;
            this.picAutomat.Paint += new System.Windows.Forms.PaintEventHandler(this.picAutomat_Paint);
            this.picAutomat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picAutomat_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 371);
            this.label5.MaximumSize = new System.Drawing.Size(212, 106);
            this.label5.MinimumSize = new System.Drawing.Size(212, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 106);
            this.label5.TabIndex = 3;
            this.label5.Text = "You can change cells at generation 0 by clicking on the picture after generation." +
    " Also you can resize the window to make it bigger.";
            // 
            // timerCodeWaiting
            // 
            this.timerCodeWaiting.Tick += new System.EventHandler(this.timerCodeWaiting_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 10;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(12, 470);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(89, 13);
            this.labelGen.TabIndex = 4;
            this.labelGen.Text = "Generation: none";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.labelGen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picAutomat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Cellular Automaton";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAutomat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.NumericUpDown numTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.Timer timerDraw;
        private System.Windows.Forms.PictureBox picAutomat;
        private System.Windows.Forms.RichTextBox textLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerCodeWaiting;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label labelGen;
    }
}

