using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    class Figure
    {
        public const float CircleA = 80;
        public const float CircleB = 60;
        public float X, Y;

        private PictureBox _box;
        private Graphics _gr;

        public Figure(PictureBox picBox)
        {
            _box = picBox;
            _gr = _box.CreateGraphics();
            _gr.TranslateTransform(picBox.Width / 2.0f, picBox.Height / 2.0f);
            X = 0;
            Y = 0;
        }

        public void Draw(Vector2 rotCenter, float rotationAngle, Vector2 scaleCenter, float kx, float ky)
        {
            _gr.Clear(Color.White);

            RotationMatrix2D rot = new RotationMatrix2D((float)(rotationAngle * RotationMatrix2D.DegToRad));
            X = rot.RotX(X - rotCenter.X, Y - rotCenter.Y) + rotCenter.X;
            Y = rot.RotY(X - rotCenter.X, Y - rotCenter.Y) + rotCenter.Y;

            ParametricEllipse(rotCenter, rotationAngle, scaleCenter, kx, ky);

            
        }


        private void ParametricEllipse(Vector2 rotCenter, float rotationAngle, Vector2 scaleCenter, float kx, float ky)
        {
            RotationMatrix2D rot = new RotationMatrix2D((float)(rotationAngle * RotationMatrix2D.DegToRad));
            float step = 0;
            bool setup = false;
            float prevX = 0, prevY = 0;
            for (float fi = 0; fi < Math.PI * 2.0f; fi += step)
            {
                float r = (float)(CircleA * CircleB / Math.Sqrt(Math.Pow(CircleA, 2) * Math.Pow(Math.Sin(fi), 2) +
                                                    Math.Pow(CircleB, 2) * Math.Pow(Math.Cos(fi), 2)));
                step = 1 / r;
                float x = X + (float)(r * Math.Cos(fi));
                float y = Y + (float)(r * Math.Sin(fi));
                Vector2 nPoint = rot.RotateAround(x, y, rotCenter.X, rotCenter.Y);


                // TODO SCALE


                if (setup)
                {
                    _gr.DrawLine(new Pen(Color.Black), prevX, prevY, nPoint.X, nPoint.Y);
                }
                else
                {
                    setup = true;
                }
                prevX = nPoint.X;
                prevY = nPoint.Y;
            }
        }
    }
}
