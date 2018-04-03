using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    class Image : IDrawable
    {
        protected Color _color;

        private readonly Vertex2D[] _vertexes;

        public Image(Vertex2D[] verts, Color color)
        {
            _color = color;
            _vertexes = (Vertex2D[])verts.Clone();
        }

        public Image(Vertex2D[] verts)
        {
            _color = Color.Black;
            _vertexes = (Vertex2D[])verts.Clone();
        }

        public Image(Color color)
        {
            _vertexes = null;
            _color = color;
        }

        public void SetColor(Color color)
        {
            _color = color;
        }

        public void Draw(PictureBox canvas)
        {
            foreach (var vert in _vertexes)
            {
                DrawPixel(canvas, vert, _color);
            }
        }

        public static void DrawPixel(PictureBox canvas, Vertex2D pixel, Color color)
        {
            Graphics gr = canvas.CreateGraphics();
            gr.FillRectangle(new SolidBrush(color), new Rectangle(pixel.X, pixel.Y, 1, 1));
            //gr.DrawEllipse(new Pen(color),  pixel.X - 1, pixel.Y - 1, 1, 1);
            //gr.DrawLine(new Pen(color), pixel.X - 1, pixel.Y - 1, pixel.X, pixel.Y); // НЕ РАБОТАЕТ
            //gr.DrawImage( );
        }
    }
}
