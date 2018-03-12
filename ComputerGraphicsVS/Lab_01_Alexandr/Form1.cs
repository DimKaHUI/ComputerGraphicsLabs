using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_01_Alexandr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics gr = DrawCanvas.CreateGraphics();
            double x, y, prevX = 0, prevY = 0;
            float a = 13, b = 7;
            float offsetX = DrawCanvas.Size.Width / 2;
            float offsetY = DrawCanvas
            float angleStep = 0.5f;

            for (float angle = 0; angle < 360; angle += angleStep)
            {
                x = (a + b) * Math.Cos(angle) - a * Math.Cos((a + b) * angle / a);
                y = (a + b) * Math.Sin(angle) - a * Math.Sin((a + b) * angle / a);
                if (angle > 0)
                {
                    gr.DrawLine(new Pen(Color.Black), (float)prevX, (float)prevY, (float)x, (float)y);
                }
                prevX = x;
                prevY = y;
            }

            
        }
    }
}
