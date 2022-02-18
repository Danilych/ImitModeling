using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlaneModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double g = 9.81;
        const double C = 0.15;
        const double rho = 1.29;

        double height, angle, speed, S, m, dt;

        int timertick;

        double cosa, sina, beta, k;

        double t, x, y, vx, vy;
        double maxy = 0;

        private void btn_Start_Click(object sender, EventArgs e)
        {
            height = (double)NumHeight.Value;
            angle = (double)NumAngle.Value;
            speed = (double)NumSpeed.Value;
            S = (double)NumSize.Value;
            m = (double)NumMass.Value;
            dt = (double)NumStep.Value;
            timertick = (int)NumTime.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Sin(angle * Math.PI / 180);

            beta = 0.5 * C * S * rho;
            k = beta / m;

            t = 0;
            x = 0;
            y = height;
            vx = speed * cosa;
            vy = speed * sina;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Points.AddXY(x, y);

            flightTimer.Interval = timertick;
            flightTimer.Start();
        }

        private void flightTimer_Tick(object sender, EventArgs e)
        {
            double vx_old = vx;
            double vy_old = vy;
            double root = Math.Sqrt(vx * vx + vy * vy);

            t = t + dt;

            vx = vx_old - k * vx_old * root * dt;
            vy = vy_old - (g + k * vy_old * root) * dt;

            x = x + vx * dt;
            y = y + vy * dt;

            chart1.Series[0].Points.AddXY(x, y);

            if (y > maxy) maxy = y;

            if (y <= 0)
            {
                flightTimer.Stop();
                dg_flightData.Rows.Add(dt.ToString(), x.ToString(), maxy.ToString(), Math.Sqrt(vx*vx+vy*vy).ToString());
            }
        }
    }
}
