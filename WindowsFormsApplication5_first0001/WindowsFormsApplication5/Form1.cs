using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                const int scaleX = 595;
                const int scaleY = 175;

                Point picBoxTopLeft = new Point(0, 0);
                Point picBoxTopLeftm1 = new Point(-1, 0);

                int halfX = picBox.Width / 2;
                int halfY = picBox.Height / 2;
                Size size = new Size(halfX + 20, picBox.Height);

                Graphics gr = picBox.CreateGraphics();
                gr.TranslateTransform(halfX, halfY);

                gr.ScaleTransform(scaleX, scaleY);

                gr.ResetClip();

                float lastY = (float)Math.Sin(0);
                float y = lastY;
                Pen p = new Pen(Color.Red, 0.015F);
                float stepX = 1F / scaleX*5;

                for (float x = 0; x < 15; x += stepX)
                {
                    gr.CopyFromScreen(picBox.PointToScreen(picBoxTopLeft), picBoxTopLeftm1, size, CopyPixelOperation.SourceCopy);
                    y = (float)Math.Sin(x);
                    gr.DrawLine(p, -stepX, lastY, 0, y);
                    lastY = y;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
