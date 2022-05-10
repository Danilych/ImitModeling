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

        private void btnEventOne_Click(object sender, EventArgs e)
        {
            double p = (double)nudOChanceOneEvent.Value / 100f;

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            double randomAnswer = rand.NextDouble();

            if (randomAnswer <= p) lbAnswerEventOne.Text = "Да";
            else lbAnswerEventOne.Text = "Нет";
        }

        private void btnBallEight_Click(object sender, EventArgs e)
        {
            double p = 1f / 20f;

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            double randomAnswer = rand.NextDouble();

            string[] answers = {
                "Бесспорно",
                "Предрешено",
                "Никаких сомнений",
                "Определённо да",
                "Можешь быть уверен в этом",
                "Мне кажется — «да»",
                "Вероятнее всего",
                "Хорошие перспективы",
                "Знаки говорят — «да»",
                "Да",
                "Пока не ясно, попробуй снова",
                "Спроси позже",
                "Лучше не рассказывать",
                "Сейчас нельзя предсказать",
                "Сконцентрируйся и спроси опять",
                "Даже не думай",
                "Мой ответ — «нет»",
                "По моим данным — «нет»",
                "Перспективы не очень хорошие",
                "Весьма сомнительно",};

            int answerID = -1;

            for (int i = 0; i < answers.Length; i++)
            {
                randomAnswer -= p;
                if (randomAnswer <= 0)
                {
                    answerID = i;
                    break;
                }
            }

            lbAnswerBallEight.Text = answers[answerID];
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
