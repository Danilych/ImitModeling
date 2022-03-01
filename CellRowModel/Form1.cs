using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellRowModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int picturePadding = 15;
        int minX = 0, minY = 0, maxX = 0, maxY = 0;
        int Columns = 5, Rows = 5;

        bool readyFirst = false;
        bool resetDraw = false;

        bool CanDraw = false;
        bool CanClick = false;
        bool CanContinueStep = false;
        bool inDrawLifePhase = false;

        bool NeedNewMap = false;

        int ClickX = 0, ClickY = 0;

        float[] ColumnsWidth;
        float RowsHeight = 0;

        bool[] Cells;

        int currentIter = 0;

        private void picAutomat_Paint(object sender, PaintEventArgs e)
        {
            if (!readyFirst) return;
            
            if (resetDraw)
            {
                if (picAutomat.Image == null) picAutomat.Image = new Bitmap(picAutomat.Width, picAutomat.Height);

                if(NeedNewMap)
                {
                    picAutomat.Image.Dispose();
                    picAutomat.Image = null;
                    picAutomat.Image = new Bitmap(picAutomat.Width, picAutomat.Height);
                    NeedNewMap = false;
                }
                

                ColumnsWidth = new float[(int)numColumns.Value + 1];

                int ColumnLines = Columns + 2; //Add number column
                int RowLines = Rows + 1;

                int drawWidth = maxX - minX;
                int drawHeight = maxY - minY;

                float dx = (float)drawWidth / (float)(ColumnLines - 1);
                float dy = (float)drawHeight / (float)(RowLines - 1);

                RowsHeight = (float)maxY / (float)(RowLines - 1);

                float oldX = 0;

                Graphics g = Graphics.FromImage(picAutomat.Image);//e.Graphics;
                g.Clear(Color.White);

                Pen p = new Pen(Color.Black, 2);

                for (int i = 0; i < ColumnLines; i++)
                {
                    float drawX = dx * i + picturePadding;

                    if (i != 0) ColumnsWidth[i - 1] = oldX; //lift side of column

                    oldX = drawX;

                    g.DrawLine(p, drawX, minY, drawX, maxY);
                }

                for (int i = 0; i < RowLines; i++)
                {
                    float drawY = dy * i + picturePadding;

                    g.DrawLine(p, minX, drawY, maxX, drawY);
                }

                float fontSize = 32f;

                float minWidth = ColumnsWidth[1] - ColumnsWidth[0];
                float minHeight = RowsHeight;
                bool change = false;

                if (minWidth <= 35f) { minWidth = Math.Min(10f, (minWidth - 5f)); change = true; }
                if (minHeight <= 52f) {minHeight = (minHeight / 52f) * 32f ; change = true; }
                if(change) fontSize = Math.Min(minWidth, minHeight);


                Font drawFont = new Font("Arial", fontSize, FontStyle.Regular);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                StringFormat drawFormat = new StringFormat();

                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                for (int i = 0; i < Rows; i++)
                {
                    float drawY = dy * i + picturePadding;
                    g.DrawString(i.ToString(), drawFont, drawBrush, ColumnsWidth[0], drawY, drawFormat);
                }

                return;
            }
            else if (CanDraw )
            {

                int ColumnLines = Columns + 2; //Add number column
                int RowLines = Rows + 1;

                int drawWidth = maxX - minX;
                int drawHeight = maxY - minY;

                float dx = (float)drawWidth / (float)(ColumnLines - 1);
                float dy = (float)drawHeight / (float)(RowLines - 1);

                Graphics g = Graphics.FromImage(picAutomat.Image);
                Pen p = new Pen(Color.Black, 2);

                for (int i = 0; i < Columns; i++)
                {

                    float yToDraw = dy * currentIter + picturePadding;
                    //float drawY = ;

                    SolidBrush greenBrush = new SolidBrush(Color.Green);
                    SolidBrush whiteBrush = new SolidBrush(Color.White);

                    if (!Cells[i])
                    {
                        g.FillRectangle(whiteBrush, ColumnsWidth[i + 1], yToDraw, dx, dy);
                    }
                    else
                    {
                        g.FillRectangle(greenBrush, ColumnsWidth[i + 1], yToDraw, dx, dy);
                    }

                    g.DrawRectangle(p, ColumnsWidth[i+1], yToDraw, dx, dy);
                }
                
                //g.Save(); 
                return;
            }

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (!inDrawLifePhase)
            {
                CanClick = false;
                btnStartStop.Text = "Stop";
                inDrawLifePhase = true;
                CanContinueStep = false;

                timerDraw.Interval = (int)numTimer.Value;
                timerDraw.Start();

                btnStep.Enabled = false;
                btnGen.Enabled = false;

                textLog.Text = "Modeling...";
            }
            else
            {
                btnStartStop.Text = "Start";
                inDrawLifePhase = false;
                CanContinueStep = true;

                timerDraw.Stop();
                btnStep.Enabled = true;
                btnGen.Enabled = true;

                textLog.Text = "Stoped...";
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            currentIter = 0;

            minX = 0 + picturePadding;
            minY = 0 + picturePadding;

            maxX = picAutomat.Width - picturePadding;
            maxY = picAutomat.Height - picturePadding;

            Columns = (int)numColumns.Value;
            Rows = (int)numRows.Value;

            Cells = new bool[Columns];
            for(int i = 0; i < Columns; i++) Cells[i] = false;

            readyFirst = true;
            resetDraw = true;
            picAutomat.Invalidate();
            
            timerCodeWaiting.Start();

            textLog.Text = "Generation successful!";
        }

        private void timerCodeWaiting_Tick(object sender, EventArgs e)
        {
            picAutomat.Refresh();
            resetDraw = false;
            CanClick = true;
            CanDraw = true;
            CanContinueStep = true;

            timerCodeWaiting.Stop();

            btnStartStop.Enabled = true;
            btnStep.Enabled = true;
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (!CanContinueStep) return;

            CanClick = false;
            inDrawLifePhase = false;
            CanContinueStep = true;

            btnStep.Enabled = true;
            btnGen.Enabled = true;

            textLog.Text = "Modeling Step...";
            MakeStep();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CanDraw = false;
            CanContinueStep = false;
            CanClick = false;
            inDrawLifePhase = false;

            timerDraw.Stop();

            btnStartStop.Enabled = false;
            btnStep.Enabled = false;

            NeedNewMap = true;

            textLog.Text = "Form was resized, please regenerate your cells!";
        }

        private void picAutomat_MouseClick(object sender, MouseEventArgs e)
        {
            bool reDraw = false;
            if (e != null && CanClick)
            {
                ClickX = e.X;
                ClickY = e.Y;
                for (int i = 0; i < Columns; i++)
                {
                    float miX = ColumnsWidth[i + 1];
                    float maX = 0;

                    float miY = picturePadding;
                    float maY = RowsHeight + picturePadding;

                    if (i == Columns - 1) maX = ColumnsWidth[i + 1] + (ColumnsWidth[i + 1] - ColumnsWidth[i]);
                    else maX = ColumnsWidth[i + 2];

                    if ((miX <= ClickX && maX >= ClickX) && (miY <= ClickY && maY >= ClickY))
                    {
                        Cells[i] = !Cells[i];
                        reDraw = true;
                    }
                }

               if(reDraw) picAutomat.Invalidate();
               timerRefresh.Start();
            }
        }
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            picAutomat.Refresh();
            timerRefresh.Stop();
        }

        private void timerDraw_Tick(object sender, EventArgs e)
        {
            MakeStep();
        }

        private void MakeStep()
        {
            int RuleNumber = (int)numRule.Value;
            bool []CellsNew = new bool[Columns];

            for(int i= 0; i < Columns; i++)
            {
                int LeftCellId = (i == 0) ? Columns - 1 : i - 1;
                int RightCellId = (i == Columns-1) ? 0 : i + 1;

                int patternNumber = 0;

                if (Cells[LeftCellId]) patternNumber |= 1 << 2;
                if (Cells[i]) patternNumber |= 1 << 1;
                if (Cells[RightCellId]) patternNumber |= 1 << 0;


                bool RuleResult = (RuleNumber & (1 << patternNumber)) != 0;

                CellsNew[i] = RuleResult;

            }

            for (int i = 0; i < Columns; i++) Cells[i] = CellsNew[i];

            picAutomat.Invalidate();
            timerRefresh.Start();

            currentIter++;
            if (currentIter >= Rows - 1)
            {
                timerDraw.Stop();

                btnStartStop.Text = "Start";
                inDrawLifePhase = false;
                CanContinueStep = false;

                btnStartStop.Enabled = false;
                btnStep.Enabled = false;
                btnGen.Enabled = true;

                textLog.Text = "Simulation ended!";
            }
        }
    }
}