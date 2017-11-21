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
                const int scaleX = 45;
                const int scaleY = 75;

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

                float lastY22 = (float)Math.Sin(0);
                float y22 = lastY;

                float stepX = 1F / scaleX*2;

                for (float x = 0; x < 15; x += stepX)
                {
                    gr.CopyFromScreen(picBox.PointToScreen(picBoxTopLeft), picBoxTopLeftm1, size, CopyPixelOperation.SourceCopy);
                    Pen p = new Pen(Color.Red, 0.015F);
                    y = (float)Math.Sin(x);
                    y22 = (float)Math.Cos(x) * y * y;

                    gr.DrawLine(p, -stepX, lastY, 0, y);

                    
                    lastY = y;

                    Pen p2 = new Pen(Color.BlueViolet, 0.015F);
                    gr.DrawLine(p2, -stepX, lastY22, 0, y22);
                    lastY22 = y22;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
