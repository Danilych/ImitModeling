using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Qui12_ValueChanged(object sender, EventArgs e)
        {
            float minusQ = 0f;

            minusQ = (float)Qui12.Value;
            minusQ += (float)Qui13.Value;
            minusQ *= -1;

            Qui11.Value = (decimal)minusQ;
        }

        private void Qui13_ValueChanged(object sender, EventArgs e)
        {
            float minusQ = 0f;

            minusQ = (float)Qui12.Value;
            minusQ += (float)Qui13.Value;
            minusQ *= -1;

            Qui11.Value = (decimal)minusQ;
        }

        private void Qui21_ValueChanged(object sender, EventArgs e)
        {
            float minusQ = 0f;

            minusQ = (float)Qui21.Value;
            minusQ += (float)Qui23.Value;
            minusQ *= -1;

            Qui22.Value = (decimal)minusQ;
        }

        private void Qui23_ValueChanged(object sender, EventArgs e)
        {
            float minusQ = 0f;

            minusQ = (float)Qui21.Value;
            minusQ += (float)Qui23.Value;
            minusQ *= -1;

            Qui22.Value = (decimal)minusQ;
        }

        private void Qui31_ValueChanged(object sender, EventArgs e)
        {
            float minusQ = 0f;

            minusQ = (float)Qui31.Value;
            minusQ += (float)Qui32.Value;
            minusQ *= -1;

            Qui33.Value = (decimal)minusQ;
        }

        private void Qui32_ValueChanged(object sender, EventArgs e)
        {
            float minusQ = 0f;

            minusQ = (float)Qui31.Value;
            minusQ += (float)Qui32.Value;
            minusQ *= -1;

            Qui33.Value = (decimal)minusQ;
        }

        int currentState = 1;
        double currentTime = 0;

        bool firstLaunch = true;

        int N = 0;
        double days = 0;

        int[] eventFreq = new int[3];
        double[] eventFreqDiv = new double[3];

        Random rand;

        private void button1_Click(object sender, EventArgs e)
        {
            Qui12.Enabled = true;
            Qui13.Enabled = true;
            Qui21.Enabled = true;
            Qui23.Enabled = true;
            Qui31.Enabled = true;
            Qui32.Enabled = true;

            numInitState.Enabled = true;
            numTimer.Enabled = true;

            btnStep.Enabled = true;
            btnTimer.Enabled = true;
            btnReset.Enabled = false;

            lbCyrrentState.Text = "Weather: " + numInitState.Value.ToString();

            Color iconColor = Color.White;
            switch ((int)numInitState.Value)
            {
                case 1: iconColor = Color.Blue; break;
                case 2: iconColor = Color.Gray; break;
                case 3: iconColor = Color.Black; break;
            }
            weatherIcon.BackColor = iconColor;

            lbChangeTime.Text = "Change time(day): 0";

            currentState = (int)numInitState.Value - 1;
            currentTime = 0;

            firstLaunch = true;    

            for(int i = 0; i<3;i++)
            {
                eventFreq[i] = 0;
                eventFreqDiv[i] = 0;  
            }

            N = 0;
            days = 0;

            ResetFreqDataTable();
            chart1.Series[0].Points.Clear();
        }

        public void CalculateOneStep()
        {
            float[,] Q = new float[3,3];

            Q[0,0] = (float)Qui11.Value;
            Q[0,1] = (float)Qui12.Value;
            Q[0,2] = (float)Qui13.Value;
            Q[1,0] = (float)Qui21.Value;
            Q[1,1] = (float)Qui22.Value;
            Q[1,2] = (float)Qui23.Value;
            Q[2,0] = (float)Qui31.Value;
            Q[2,1] = (float)Qui32.Value;
            Q[2,2] = (float)Qui33.Value;

            

            double randA = rand.NextDouble();

            currentTime += Math.Log(randA) / (double)Q[currentState, currentState];

            double[] pChances = new double[3];

            for (int i = 0; i < 3; i++)
                if (i == currentState) pChances[i] = 0;
                else pChances[i] = -(Q[currentState, i] / Q[currentState, currentState]);

            int currentEventNumber = 0;

            for (int i = 0; i < 3; i++)
            {
                randA -= pChances[i];
                if (randA <= 0)
                {
                    currentEventNumber = i;
                    break;
                }
            }

            currentState = currentEventNumber;
        }

        public void CalculateFreqForCurrentState()
        {
            eventFreq[currentState] += 1;
        }

        public void CalculateFreqDiv()
        {
            for (int i = 0; i < 3; i++)
                eventFreqDiv[i] = (double)eventFreq[i] / (double)N;
        }

        public void WriteFreqDataTable()
        {
            if (dgvStatesFreq.Rows.Count == 0)
                dgvStatesFreq.Rows.Add();

            dgvStatesFreq.Rows[0].Cells[0].Value = "Frequency";
            dgvStatesFreq.Rows[0].Cells[1].Value = String.Format("{0:N3}", eventFreqDiv[0]);
            dgvStatesFreq.Rows[0].Cells[2].Value = String.Format("{0:N3}", eventFreqDiv[1]);
            dgvStatesFreq.Rows[0].Cells[3].Value = String.Format("{0:N3}", eventFreqDiv[2]);
        }

        public void ResetFreqDataTable()
        {
            if (dgvStatesFreq.Rows.Count == 0)
                dgvStatesFreq.Rows.Add();

            dgvStatesFreq.Rows[0].Cells[0].Value = "Frequency";
            dgvStatesFreq.Rows[0].Cells[1].Value = 0;
            dgvStatesFreq.Rows[0].Cells[2].Value = 0;
            dgvStatesFreq.Rows[0].Cells[3].Value = 0;
        }

        public void WriteChart()
        {
            chart1.Series[0].Points.Clear();

            for (int i = 0; i < 3; i++)
            {
                chart1.Series[0].Points.AddXY(i + 1, eventFreqDiv[i]);
            }
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;

            Qui12.Enabled = false;
            Qui13.Enabled = false;
            Qui21.Enabled = false;
            Qui23.Enabled = false;
            Qui31.Enabled = false;
            Qui32.Enabled = false;

            numInitState.Enabled = false;
           

            if (firstLaunch)
            {
                currentState = (int)numInitState.Value - 1;
                firstLaunch = false;
            }

            N++;
            CalculateOneStep();

            lbCyrrentState.Text = "Weather: " + (currentState+1).ToString();
            Color iconColor = Color.White;
            switch (currentState+1)
            {
                case 1: iconColor = Color.Blue; break;
                case 2: iconColor = Color.Gray; break;
                case 3: iconColor = Color.Black; break;
            }
            weatherIcon.BackColor = iconColor;

            lbChangeTime.Text = String.Format("Change time(day): {0:N2}", currentTime);//"Change time(day): " + ;

            CalculateFreqForCurrentState();
            CalculateFreqDiv();
            WriteFreqDataTable();
            WriteChart();
        }

        private void eventTimer_Tick(object sender, EventArgs e)
        {
            Qui12.Enabled = false;
            Qui13.Enabled = false;
            Qui21.Enabled = false;
            Qui23.Enabled = false;
            Qui31.Enabled = false;
            Qui32.Enabled = false;

            numInitState.Enabled = false;

            if (firstLaunch)
            {
                currentState = (int)numInitState.Value - 1;
                firstLaunch = false;
            }
            N++;
            CalculateOneStep();

            lbCyrrentState.Text = "Weather: " + (currentState + 1).ToString();
            Color iconColor = Color.White;
            switch (currentState + 1)
            {
                case 1: iconColor = Color.Blue; break;
                case 2: iconColor = Color.Gray; break;
                case 3: iconColor = Color.Black; break;
            }
            weatherIcon.BackColor = iconColor;

            lbChangeTime.Text = String.Format("Change time(day): {0:N2}", currentTime);//"Change time(day): " + ;

            CalculateFreqForCurrentState();
            CalculateFreqDiv();
            WriteFreqDataTable();
            WriteChart();
        }

        private void numTimer_ValueChanged(object sender, EventArgs e)
        {
            eventTimer.Interval = (int)numTimer.Value;
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            if(eventTimer.Enabled)
            {
                btnTimer.Text = "Start timer";
                eventTimer.Stop();

                btnStep.Enabled = true;
                btnReset.Enabled = true;

                numTimer.Enabled = true;
            }
            else
            {
                btnTimer.Text = "Stop timer";
                eventTimer.Start();

                btnStep.Enabled = false;
                btnReset.Enabled = false;

                numTimer.Enabled = false;
            }
        }

        private void btnLaunchExperiment_Click(object sender, EventArgs e)
        {
            currentState = (int)numInitState.Value - 1;
            currentTime = 0;

            for (int i = 0; i < 3; i++)
            {
                eventFreq[i] = 0;
                eventFreqDiv[i] = 0;
            }

            if (firstLaunch)
            {
                currentState = (int)numInitState.Value - 1;
                firstLaunch = false;
            }

            N = (int)numTrials.Value;
            days = (int)numDays.Value;

            for(int i = 0; i < N; i++)
            {
                while(currentTime < days)
                {
                    CalculateOneStep();
                }   
                CalculateFreqForCurrentState();
                currentTime = 0;
                currentState = (int)numInitState.Value - 1;
            }

            CalculateFreqDiv();
            WriteFreqDataTable();
            WriteChart();

            lbCyrrentState.Text = "Weather: " + (currentState + 1).ToString();
            Color iconColor = Color.White;
            switch (currentState + 1)
            {
                case 1: iconColor = Color.Blue; break;
                case 2: iconColor = Color.Gray; break;
                case 3: iconColor = Color.Black; break;
            }
            weatherIcon.BackColor = iconColor;

            lbChangeTime.Text = String.Format("Change time(day): {0:N2}", currentTime);//"Change time(day): " + ;

            btnReset.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random(Guid.NewGuid().GetHashCode());
        }
    }
}
