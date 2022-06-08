using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.05;
        Random rand = new Random(Guid.NewGuid().GetHashCode());

        double euro, dollar;
        double prevXEuro, prevXDollar;
        int day = 0;

        double mu = 0.005;
        double sigma = 0.05;

        private double UseBoxMuller(double a1, double a2)
        {
            double leftSide = Math.Sqrt((-2) * Math.Log(a1));
            double rightSide = Math.Cos(2 * Math.PI * a2);

            return leftSide * rightSide;
        }

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if(!timerDays.Enabled)
            {
                timerDays.Interval = (int)numTimeStep.Value;
                euro = (double)numEuro.Value;
                dollar = (double)numDollar.Value;

                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();

                chart1.Series[0].Points.AddXY(day, euro);
                chart1.Series[1].Points.AddXY(day, dollar);

                btn_StartStop.Text = "Stop";

                prevXEuro = euro;
                prevXDollar = dollar;

                timerDays.Start();
            }
            else
            {
                timerDays.Stop();
                btn_StartStop.Text = "Start";
            }
        }

        private void timerDays_Tick(object sender, EventArgs e)
        {
            double xi;

            xi = UseBoxMuller(rand.NextDouble(), rand.NextDouble());
            double newXEuro = prevXEuro * Math.Exp((mu-sigma*sigma/(double)2) + sigma * xi);
            euro = newXEuro;
            prevXEuro = newXEuro;

            xi = UseBoxMuller(rand.NextDouble(), rand.NextDouble());
            double newXDollar = prevXDollar * Math.Exp((mu - sigma * sigma / (double)2) + sigma * xi);
            dollar = newXDollar;
            prevXDollar = newXDollar;

            day++;

            chart1.Series[0].Points.AddXY(day, euro);
            chart1.Series[1].Points.AddXY(day, dollar);
        
        }
    }
}
