using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrialsStart_Click(object sender, EventArgs e)
        {
            lbTrialsLog.Text = "";
            cTrialsChart.Series[0].Points.Clear();

            int pSum = 0;

            int rowsCount = dgvProbData.Rows.Count - 1;

            if (rowsCount == 0)
            {
                lbTrialsLog.Text = "Не указаны шансы";
                return;
            }

            for (int i = 0; i < rowsCount; i++)
            {
                if (pSum + Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value) < 100 && i == rowsCount-1)
                {
                    dgvProbData.Rows[rowsCount - 1].Cells[0].Value = 100 - (pSum);
                    lbTrialsLog.Text = "Сумма шансов не должна быть ниже 100% (дополнение шанса последней ячейки)        ";
                }

                pSum += Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value);
            }

            //Experiment start

            int N = (int)nudTrialsAmount.Value;

            float[] eventUserChances = new float[rowsCount];
            int[] eventFreq = new int[rowsCount];
            float[] eventMediumChance = new float[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                eventUserChances[i] = (float)Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value) / 100f;
                eventFreq[i] = 0;
                eventMediumChance[i] = 0f;
            }

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            double randomAnswer;

            for (int i = 0; i < N; i++)
            {
                randomAnswer = rand.NextDouble();

                for (int j = 0; j < rowsCount; j++)
                {
                    randomAnswer -= eventUserChances[j];
                    if (randomAnswer <= 0)
                    {
                        eventFreq[j]++;
                        break;
                    }
                }
            }

            for(int i = 0; i < rowsCount; i++)
            {
                eventMediumChance[i] = (float)eventFreq[i] / (float)N;

                cTrialsChart.Series[0].Points.AddXY(i+1, eventMediumChance[i]);
            }

            //Math calculations

            double mathExpect = 0f;

            for(int i = 0; i < rowsCount; i++)
                mathExpect += ((double)Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value) / 100f) * (double)i;

            double mathVariance = 0f;

            for (int i = 0; i < rowsCount; i++)
                mathVariance += ((double)Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value) / 100f) * ((i - mathExpect) * (i - mathExpect));

            //Empiric calculations

            double empiricExpect = 0f;

            for (int i = 0; i < rowsCount; i++)
                empiricExpect += eventMediumChance[i] * i;

            double empiricVariance = 0f;

            for (int i = 0; i < rowsCount; i++)
                empiricVariance += eventMediumChance[i] * (i * i);

            empiricVariance -= (empiricExpect * empiricExpect);

            //Errors calculations

            double absErrorExpect = Math.Abs(empiricExpect - mathExpect);

            double absErrorVariance = Math.Abs(empiricVariance - mathVariance);

            double relativeErrorExpect = absErrorExpect / Math.Abs(mathExpect);
            double relativeErrorVariance = absErrorVariance / Math.Abs(mathVariance);

            lbAverage.Text = String.Format("Average: {0:N2} (error = {1:N2}%)", empiricExpect, relativeErrorExpect*100);
            lbVariance.Text = String.Format("Variance: {0:N2} (error = {1:N2}%)", empiricVariance, relativeErrorVariance*100);

            //Chi calculations

            double bigX = 0f;

            for (int i = 0; i < rowsCount; i++)
                bigX += (double)(eventFreq[i] * eventFreq[i]) / ((double)N * (Convert.ToDouble(dgvProbData.Rows[i].Cells[0].Value) / 100f));

            bigX -= N;

            double[] chiTable =
            {
            3.841f,
            5.991f,
            7.815f,
            9.488f,
            11.070f,
            12.592f,
            14.067f,
            15.507f,
            16.919f,
            18.307f,
            19.675f,
            21.026f,
            22.362f,
            23.685f,
            24.996f,
            26.296f,
            27.587f,
            28.869f,
            30.144f,
            31.410f
            };

            bool isBigger = (bigX > chiTable[rowsCount - 2]);
            lbChi.Clear();

            lbChi.SelectionColor = Color.Black;
            lbChi.AppendText("Chi-squared: ");
            lbChi.AppendText(String.Format("{0:N2} > {1:N2}  is ", bigX, chiTable[rowsCount - 2]));
            if(isBigger) lbChi.SelectionColor = Color.Red;
            else lbChi.SelectionColor = Color.Green;
            lbChi.AppendText("true");
        }

        private void dgvProbData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int pSum = 0;

            int rowsCount = dgvProbData.Rows.Count - 1;

            if (rowsCount == 1)
            {
                dgvProbData.Rows[0].Cells[0].Value = 100;
                return;
            }

            for (int i = 0; i < rowsCount; i++)
            {
                if (pSum + Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value) > 100)
                {
                    lbTrialsLog.Text = "Сумма шансов не должна превышать 100%";
                    dgvProbData.Rows[i].Cells[0].Value = 100 - (pSum);
                }

                pSum += Convert.ToInt32(dgvProbData.Rows[i].Cells[0].Value);
            }
        }
    }
}
