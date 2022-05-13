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

            int rowsCount = dgvProbData.Rows.Count - 1;

            if (rowsCount == 0)
            {
                lbTrialsLog.Text = "Не указаны комманды и их среднее количество голов";
                return;
            }

            double[] commandsMediumGoals = new double[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {
                commandsMediumGoals[i] = Convert.ToDouble(dgvProbData.Rows[i].Cells[1].Value);
                dgvProbData.Rows[i].Cells[2].Value = 0;
                dgvProbData.Rows[i].Cells[3].Value = 0;
                dgvProbData.Rows[i].Cells[4].Value = 0;
                dgvProbData.Rows[i].Cells[5].Value = 0;
            }

            //Stages start

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < rowsCount-1; j++)
                {
                    int leftTeamGoalsAmount = 0;

                    double S = 0f;
                    double a = 0f;

                    while(S >= -commandsMediumGoals[j])
                    {
                        a = rand.NextDouble();

                        S += Math.Log(a);

                        if (S >= -commandsMediumGoals[j]) leftTeamGoalsAmount++;
                    }

                    for(int k  = j+1; k < rowsCount; k++)
                    {
                        int rightTeamGoalsAmount = 0;

                        S = 0f;
                        a = 0f;

                        while (S >= -commandsMediumGoals[k])
                        {
                            a = rand.NextDouble();

                            S += Math.Log(a);

                            if (S >= -commandsMediumGoals[k]) rightTeamGoalsAmount++;
                        }

                        int leftTeamPoints = Convert.ToInt32(dgvProbData.Rows[j].Cells[5].Value);
                        int rightTeamPoints = Convert.ToInt32(dgvProbData.Rows[k].Cells[5].Value);

                        if (leftTeamGoalsAmount > rightTeamGoalsAmount)
                        {
                            leftTeamPoints += 3;
                            dgvProbData.Rows[j].Cells[2].Value = Convert.ToInt32(dgvProbData.Rows[j].Cells[2].Value) + 1;
                            dgvProbData.Rows[k].Cells[3].Value = Convert.ToInt32(dgvProbData.Rows[k].Cells[3].Value) + 1;
                        }
                        else if (rightTeamGoalsAmount > leftTeamGoalsAmount)
                        {
                            rightTeamPoints += 3;
                            dgvProbData.Rows[j].Cells[3].Value = Convert.ToInt32(dgvProbData.Rows[j].Cells[3].Value) + 1;
                            dgvProbData.Rows[k].Cells[2].Value = Convert.ToInt32(dgvProbData.Rows[k].Cells[2].Value) + 1;
                        }
                        else if (leftTeamGoalsAmount == rightTeamGoalsAmount)
                        {
                            leftTeamPoints++;
                            rightTeamPoints++;

                            dgvProbData.Rows[j].Cells[4].Value = Convert.ToInt32(dgvProbData.Rows[j].Cells[4].Value) + 1;
                            dgvProbData.Rows[k].Cells[4].Value = Convert.ToInt32(dgvProbData.Rows[k].Cells[4].Value) + 1;
                        }

                        dgvProbData.Rows[j].Cells[5].Value = leftTeamPoints;
                        dgvProbData.Rows[k].Cells[5].Value = rightTeamPoints;
                    }
                }
            }

            dgvProbData.Sort(clmPoints, ListSortDirection.Descending);

            lbTrialsLog.Text = "Выйграла команда " + dgvProbData.Rows[0].Cells[0].Value;
        }
    }
}
