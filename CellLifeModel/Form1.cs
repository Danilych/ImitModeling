using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellLifeModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int picturePadding = 1;
        int minX = 0, minY = 0, maxX = 0, maxY = 0;
        int Columns = 5, Rows = 5;

        bool readyFirst = false;
        bool resetDraw = false;

        bool CanHandDraw = false;
        bool CanClick = false;
        bool CanContinueStep = false;
        bool inDrawLifePhase = false;

        bool DrawStep = false;

        bool NeedNewMap = false;

        int ClickX = 0, ClickY = 0;

        float[] ColumnsWidth;
        float RowsHeight = 0;

        bool[,] Cells;

        int currentIter = 0;

        int RoWForDraw = 0;

        private void picAutomat_Paint(object sender, PaintEventArgs e)
        {
            if (!readyFirst) return;

            if (resetDraw)
            {
                if (picAutomat.Image == null) picAutomat.Image = new Bitmap(picAutomat.Width, picAutomat.Height);

                if (NeedNewMap)
                {
                    picAutomat.Image.Dispose();
                    picAutomat.Image = null;
                    picAutomat.Image = new Bitmap(picAutomat.Width, picAutomat.Height);
                    NeedNewMap = false;
                }


                ColumnsWidth = new float[(int)numColumns.Value];

                int ColumnLines = Columns + 1;
                int RowLines = Rows + 1;

                int drawWidth = maxX - minX;
                int drawHeight = maxY - minY;

                float dx = (float)drawWidth / (float)(ColumnLines - 1);
                float dy = (float)drawHeight / (float)(RowLines - 1);

                RowsHeight = (float)maxY / (float)(RowLines - 1);

                float oldX = 0;

                Graphics g = Graphics.FromImage(picAutomat.Image);
                g.Clear(Color.White);

                Pen p = new Pen(Color.Black, 1);

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

                return;
            }
            else if (CanHandDraw)
            {

                int ColumnLines = Columns + 1;
                int RowLines = Rows + 1;

                int drawWidth = maxX - minX;
                int drawHeight = maxY - minY;

                float dx = (float)drawWidth / (float)(ColumnLines -1 );
                float dy = (float)drawHeight / (float)(RowLines - 1);

                Graphics g = Graphics.FromImage(picAutomat.Image);
                Pen p = new Pen(Color.Black, 1);

                for (int i = 0; i < Columns; i++)
                {

                    float yToDraw = dy * RoWForDraw + picturePadding;
                    //float drawY = ;

                    SolidBrush greenBrush = new SolidBrush(Color.Green);
                    SolidBrush whiteBrush = new SolidBrush(Color.White);

                    if (!Cells[RoWForDraw,i])
                    {
                        g.FillRectangle(whiteBrush, ColumnsWidth[i], yToDraw, dx, dy);
                    }
                    else
                    {
                        g.FillRectangle(greenBrush, ColumnsWidth[i], yToDraw, dx, dy);
                    }

                    g.DrawRectangle(p, ColumnsWidth[i], yToDraw, dx, dy);
                }

                //g.Save(); 
                return;
            }
            else if(DrawStep)
            {

                int ColumnLines = Columns + 1; //Add number column
                int RowLines = Rows + 1;

                int drawWidth = maxX - minX;
                int drawHeight = maxY - minY;

                float dx = (float)drawWidth / (float)(ColumnLines - 1);
                float dy = (float)drawHeight / (float)(RowLines - 1);

                Graphics g = Graphics.FromImage(picAutomat.Image);
                Pen p = new Pen(Color.Black, 1);

                for (int i = 0; i < Rows; i++)
                    for (int j = 0; j < Columns; j++)
                    {
                        float yToDraw = dy * i + picturePadding;

                        SolidBrush greenBrush = new SolidBrush(Color.Green);
                        SolidBrush whiteBrush = new SolidBrush(Color.White);

                        if (!Cells[i, j])
                        {
                            g.FillRectangle(whiteBrush, ColumnsWidth[j], yToDraw, dx, dy);
                        }
                        else
                        {
                            g.FillRectangle(greenBrush, ColumnsWidth[j], yToDraw, dx, dy); //
                        }

                        g.DrawRectangle(p, ColumnsWidth[j], yToDraw, dx, dy);
                    }
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

                textLog.Text = "Modeling in time...";
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

            Cells = new bool[Rows, Columns];
            for (int i = 0; i < Rows; i++)
                for(int j = 0;j<Columns;j++) Cells[i,j] = false;

            readyFirst = true;
            resetDraw = true;
            picAutomat.Invalidate();

            timerCodeWaiting.Start();

            textLog.Text = "Generation successful!";
            labelGen.Text = "Generation: none";
        }

        private void timerCodeWaiting_Tick(object sender, EventArgs e)
        {
            picAutomat.Refresh();
            resetDraw = false;
            CanClick = true;
            CanHandDraw = true;
            CanContinueStep = true;

            timerCodeWaiting.Stop();

            btnStartStop.Enabled = true;
            btnStep.Enabled = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            btnGen.Enabled = true;
            btnStartStop.Enabled = false;
            btnStep.Enabled= false;
            NeedNewMap = true;

            textLog.Text = "Form was resized, please regenerate your table!";
            timerDraw.Stop();
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

        private void picAutomat_MouseClick(object sender, MouseEventArgs e)
        {
            bool reDraw = false;
            if (e != null && CanClick)
            {
                ClickX = e.X;
                ClickY = e.Y;

                int RowToDraw = 0;

                for(int i = 0; i < Rows; i++)
                {
                    if((float)ClickY < (float)((RowsHeight*(i+1)) + picturePadding))
                    {
                        RowToDraw = i;
                        break;
                    }
                }

                for (int i = 0; i < Columns; i++)
                {
                    float miX = ColumnsWidth[i];
                    float maX = 0;

                    float miY = picturePadding+RowsHeight*RowToDraw;
                    float maY = 0;

                    if (RowToDraw == (Rows - 1)) maY = RowsHeight * RowToDraw + (RowsHeight * RowToDraw - RowsHeight * (RowToDraw - 1)) + picturePadding;
                    else maY = picturePadding + RowsHeight * (RowToDraw+1);

                    if (i == Columns - 1) maX = ColumnsWidth[i] + (ColumnsWidth[i] - ColumnsWidth[i-1]);
                    else maX = ColumnsWidth[i + 1];

                    if ((miX <= ClickX && maX >= ClickX) && (miY <= ClickY && maY >= ClickY))
                    {
                        Cells[RowToDraw, i] = !Cells[RowToDraw, i];
                        reDraw = true;
                    }
                }

                RoWForDraw = RowToDraw;
                if (reDraw) picAutomat.Invalidate();
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
            CanHandDraw = false;
            bool[,] CellsNew = new bool[Rows,Columns];

            int[] CellsIds;
            CellsIds = new int[9];

            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                {
                    if (i == 0) //x = 5(Row) * 10000 + y(Column)
                    {
                        CellsIds[0] = (j == 0) ? (Rows - 1) * 10000 + Columns - 1 : (Rows - 1) * 10000 + j - 1;
                        CellsIds[1] = (Rows - 1) * 10000 + j;
                        CellsIds[2] = (j == (Columns - 1)) ? (Rows - 1) * 10000 + 0 : (Rows - 1) * 10000 + j + 1;
                    }
                    else
                    {
                        CellsIds[0] = (j == 0) ? (i - 1) * 10000 + Columns - 1 : (i - 1) * 10000 + j - 1;
                        CellsIds[1] = (i - 1) * 10000 + j;
                        CellsIds[2] = (j == (Columns - 1)) ? (i - 1) * 10000 + 0 : (i - 1) * 10000 + j + 1;
                    }

                    CellsIds[3] = (j == 0) ? i * 10000 + Columns - 1 : i * 10000 + j - 1;
                    CellsIds[4] = i * 10000 + j;
                    CellsIds[5] = (j == (Columns - 1)) ? i * 10000 + 0 : i * 10000 + j + 1;

                    if (i == (Rows - 1))
                    {
                        CellsIds[6] = (j == 0) ? 0 * 10000 + Columns - 1 : 0 * 10000 + j - 1;
                        CellsIds[7] = 0 * 10000 + j;
                        CellsIds[8] = (j == (Columns - 1)) ? 0 * 10000 + 0 : 0 * 10000 + j + 1;
                    }
                    else
                    {
                        CellsIds[6] = (j == 0) ? (i + 1) * 10000 + Columns - 1 : (i + 1) * 10000 + j - 1;
                        CellsIds[7] = (i + 1) * 10000 + j;
                        CellsIds[8] = (j == (Columns - 1)) ? (i + 1) * 10000 + 0 : (i + 1) * 10000 + j + 1;
                    }

                    int AliveNeighbours = 0;
                    bool SelfAlive = false;

                    for (int k = 0; k < 9; k++)
                        if (k == 4) SelfAlive = Cells[CellsIds[k] / 10000, CellsIds[k] % 10000];
                        else if (Cells[CellsIds[k] / 10000, CellsIds[k] % 10000]) AliveNeighbours++;

                    if (SelfAlive)
                    {
                        if (AliveNeighbours < 2) CellsNew[i, j] = false;
                        else if (AliveNeighbours == 2 || AliveNeighbours == 3) CellsNew[i, j] = true;
                        else if (AliveNeighbours > 3) CellsNew[i, j] = false;
                    }
                    else if (AliveNeighbours == 3) CellsNew[i, j] = true;
                    else CellsNew[i, j] = false;
                }
            


            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    Cells[i,j] = CellsNew[i,j];

            DrawStep = true;
            picAutomat.Invalidate();
            timerRefresh.Start();

            currentIter++;
           
            labelGen.Text = "Generation: " + currentIter;
        }
    }
}