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
            this.lbTrialsLog = new System.Windows.Forms.Label();
            this.btnTrialsStart = new System.Windows.Forms.Button();
            this.dgvProbData = new System.Windows.Forms.DataGridView();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTrialsLog
            // 
            this.lbTrialsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrialsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTrialsLog.Location = new System.Drawing.Point(391, 280);
            this.lbTrialsLog.Name = "lbTrialsLog";
            this.lbTrialsLog.Size = new System.Drawing.Size(185, 200);
            this.lbTrialsLog.TabIndex = 4;
            this.lbTrialsLog.Text = "Ожидание старта";
            // 
            // btnTrialsStart
            // 
            this.btnTrialsStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrialsStart.Location = new System.Drawing.Point(391, 12);
            this.btnTrialsStart.Name = "btnTrialsStart";
            this.btnTrialsStart.Size = new System.Drawing.Size(185, 30);
            this.btnTrialsStart.TabIndex = 3;
            this.btnTrialsStart.Text = "Начать чемпионат";
            this.btnTrialsStart.UseVisualStyleBackColor = true;
            this.btnTrialsStart.Click += new System.EventHandler(this.btnTrialsStart_Click);
            // 
            // dgvProbData
            // 
            this.dgvProbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProbData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmGoals,
            this.clmPoints});
            this.dgvProbData.Location = new System.Drawing.Point(12, 12);
            this.dgvProbData.Name = "dgvProbData";
            this.dgvProbData.Size = new System.Drawing.Size(344, 468);
            this.dgvProbData.TabIndex = 0;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Название команды";
            this.clmName.Name = "clmName";
            this.clmName.Width = 150;
            // 
            // clmGoals
            // 
            this.clmGoals.HeaderText = "Среднее количество голов";
            this.clmGoals.Name = "clmGoals";
            // 
            // clmPoints
            // 
            this.clmPoints.HeaderText = "Очки";
            this.clmPoints.Name = "clmPoints";
            this.clmPoints.ReadOnly = true;
            this.clmPoints.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 492);
            this.Controls.Add(this.lbTrialsLog);
            this.Controls.Add(this.btnTrialsStart);
            this.Controls.Add(this.dgvProbData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Футбольный менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProbData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvProbData;
        private System.Windows.Forms.Label lbTrialsLog;
        private System.Windows.Forms.Button btnTrialsStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPoints;
    }
}

