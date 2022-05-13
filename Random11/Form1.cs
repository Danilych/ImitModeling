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

        private double GetPlotnost(double expect, double variance, double x)
        {
            double ePower = -((x - expect)) * (x - expect) / (2 * variance);
            double e = Math.Pow(Math.E, ePower);

            double div = 1f / (Math.Sqrt(variance) * Math.Sqrt(2 * Math.PI));

            return (div * e);
        }

        private double UseBoxMuller(double a1, double a2)
        {
            double leftSide = Math.Sqrt((-2) * Math.Log(a1));
            double rightSide = Math.Cos(2 * Math.PI * a2);

            return leftSide * rightSide;
        }

        private void btnTrialsStart_Click(object sender, EventArgs e)
        {
            chartNormal.Series[0].Points.Clear();
            chartNormal.Series[1].Points.Clear();

            //Function of plotnost'

            int N = (int)nudTrialsAmount.Value;

            double mathExpect = (double)nudMathExpect.Value;
            double mathVariance = (double)nudMathVariance.Value;

            chartNormal.ChartAreas[0].AxisY.Minimum = 0;

            double dx = (chartNormal.ChartAreas[0].AxisX.Maximum - (chartNormal.ChartAreas[0].AxisX.Minimum)) / 100f;
            double curX = chartNormal.ChartAreas[0].AxisX.Minimum;
            double maxY = 0;

            for (int i = 0; i < 100; i++)
            {
                double p = GetPlotnost(mathExpect, mathVariance, (curX + dx * i));

                chartNormal.Series[1].Points.AddXY(curX + dx * i, p);
            }

            //BOX-MULLER Generator

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            double[] randomNumbers = new double[N];

            double maxX = double.MinValue;
            double minX = double.MaxValue;

            for (int i = 0; i < N; i++)
            {
                double result = UseBoxMuller(rand.NextDouble(),rand.NextDouble());
                result = result * mathVariance + mathExpect;

                randomNumbers[i] = result;

                if(result < minX) minX = result;
                if(result > maxX) maxX = result;
            }

            chartNormal.ChartAreas[0].AxisX.Minimum = (int)(minX - 1);
            chartNormal.ChartAreas[0].AxisX.Maximum = (int)(maxX + 1);

            int k = (int)Math.Log(N, 2f) + 1;
            double dk = (maxX-minX)/(double)k;

            int[] intervalMatches = new int[k];
            double[] intervalFrequency = new double[k];

            for (int i = 0; i < k; i++) intervalMatches[i] = 0;

            for(int i = 0; i < N; i++)
                for(int j = 0; j < k; j++)
                {
                    if(randomNumbers[i] >= minX+dk*j && randomNumbers[i] <= minX + dk * (j+1))
                        intervalMatches[j]++;
                }

            for (int j = 0; j < k; j++)
                intervalFrequency[j] = (double)intervalMatches[j]/(double)N;

            maxY = 0f;

            for (int i = 0; i < k; i++)
            {
                double drawX = (minX + dk * i);
                int id = chartNormal.Series[0].Points.AddXY((drawX), intervalFrequency[i]);
                
                if(maxY < intervalFrequency[i]) maxY = intervalFrequency[i];
            }

            if (maxY > 0.75f) chartNormal.ChartAreas[0].AxisY.Maximum = 1f;
            else if (maxY > 0.5f) chartNormal.ChartAreas[0].AxisY.Maximum = 0.75f;
            else if (maxY > 0.25f) chartNormal.ChartAreas[0].AxisY.Maximum = 0.5f;
            else chartNormal.ChartAreas[0].AxisY.Maximum = 0.25f;

            //Empiric calculations

            double empiricExpect = 0f;

            for (int i = 0; i < N; i++)
                empiricExpect += randomNumbers[i];

            empiricExpect /= (double)N;

            double empiricVariance = 0f;

            for (int i = 0; i < N; i++)
                empiricVariance += (randomNumbers[i] * randomNumbers[i]);

            empiricVariance /= (double)N;

            empiricVariance -= (empiricExpect * empiricExpect);

            empiricVariance = Math.Sqrt(empiricVariance);

            //Errors calculations

            double absErrorExpect = Math.Abs(empiricExpect - mathExpect);

            double absErrorVariance = Math.Abs(empiricVariance - mathVariance);

            double relativeErrorExpect = 0f;
            if (mathExpect == 0) relativeErrorExpect = absErrorExpect / 1;
            else relativeErrorExpect = absErrorExpect / Math.Abs(mathExpect);

            double relativeErrorVariance = absErrorVariance / Math.Abs(mathVariance);

            lbAverage.Text = String.Format("Average: {0:N2} (error = {1:N2}%)", empiricExpect, relativeErrorExpect*100);
            lbVariance.Text = String.Format("Variance: {0:N2} (error = {1:N2}%)", empiricVariance, relativeErrorVariance*100);

            //Chi calculations

            double[] pI = new double[k];

            for(int i = 0; i < k ; i++)
            {
                float second = (float)(((minX + dk * (i + 1)) + (minX + dk * (i)))/(double)2f);
                float plot = (float)GetPlotnost(mathExpect, mathVariance, second);

                if (plot < 0.002f) pI[i] = 0f;
                else pI[i] = dk * plot;
            }

            float bigX = 0f;

            for (int i = 0; i < k; i++)
            {
                float sumPartOne = (float)(intervalMatches[i] * intervalMatches[i]);
                float partTwo = ((float)N * (float)pI[i]);
                float result;

                if (partTwo < 0.002f) result = 0f;
                else result = sumPartOne / partTwo;

                bigX += result;
            }

            bigX -= N;

            float[] chiTable =
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

            bool isBigger = (bigX > chiTable[k - 2]);
            lbChi.Clear();

            lbChi.SelectionColor = Color.Black;
            lbChi.AppendText("Chi-squared: ");
            lbChi.AppendText(String.Format("{0:N2} > {1:N2}  is ", bigX, chiTable[k - 2]));
            if (isBigger)
            {
                lbChi.SelectionColor = Color.Red;
                lbChi.AppendText("true");
            }
            else
            {
                lbChi.SelectionColor = Color.Green;
                lbChi.AppendText("false");
            }

        }
    }
}
