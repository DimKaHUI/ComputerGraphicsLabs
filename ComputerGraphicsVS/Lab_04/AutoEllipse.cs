using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    class AutoEllipse : IDrawable
    {
        private int x0, y0;
        private float _a, _b;
        private Color _color;
        public AutoEllipse(Vertex2D center, float a, float b, Color color)
        {
            x0 = center.X;
            y0 = center.Y;
            _a = a;
            _b = b;
            _color = color;
        }

        public void Draw(PictureBox canvas)
        {
            Graphics gr = canvas.CreateGraphics();
            gr.DrawEllipse(new Pen(_color), x0 - _a / 2, y0 - _b / 2, _a, _b );
        }
    }
}
