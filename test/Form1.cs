using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool needDraw = false;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!needDraw) return;

            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Red);
            needDraw = false;
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null) pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            needDraw = true;
            pictureBox1.Invalidate();
            
        }
    }
}
