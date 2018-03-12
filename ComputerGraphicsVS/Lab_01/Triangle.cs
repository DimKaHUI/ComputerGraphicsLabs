using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_01
{
    
    public struct Triangle
    {
        public Vertex A, B, C;

        public const int FontSize = 10;
        public const float HeighToWidthCoefficient = 0.70f;
        public const float CircleAngleFactor = 10.0f;

        public double a
        {
            get { return Vertex.Magnitude(B, C); }
        }

        public double b
        {
            get { return Vertex.Magnitude(A, C); }
        }

        public double c
        {
            get { return Vertex.Magnitude(A, B); }
        }

        public Triangle(Vertex a, Vertex b, Vertex c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsDegenerate
        {
            get
            {
                return Area <= 0.00001f;
            }
        }

        private void DrawCircle(float x, float y, float r, PictureBox picBox)
        {
            var gr = picBox.CreateGraphics();
            gr.TranslateTransform(picBox.Width / 2.0f, picBox.Height / 2.0f);
            float prevX = x + r;
            float prevY = y;
            float angleStep = 1 / r * CircleAngleFactor;
            RotationMatrix2D rot = new RotationMatrix2D(angleStep);
            for (float t = angleStep; t < Math.PI * 2; t += angleStep)
            {
                Vector2 rotated = new Vector2(prevX, prevY);
                rotated = rot.Rotate(rotated);
                gr.DrawLine(new Pen(Color.Blue), prevX, prevY, rotated.X, rotated.Y);
                prevX = rotated.X;
                prevY = rotated.Y;
            }
            gr.DrawLine(new Pen(Color.Blue), prevX, prevY, x + r, y);

        }

        public void Draw(PictureBox picBox)
        {
            Pen pen = new Pen(Color.Green);

            var gr = picBox.CreateGraphics();
            gr.TranslateTransform(picBox.Size.Width / 2.0f, picBox.Size.Height / 2.0f);
           
            gr.DrawLine(pen, (float)A.X, -(float)A.Y, (float)B.X, -(float)B.Y);
            gr.DrawLine(pen, (float)B.X, -(float)B.Y, (float)C.X, -(float)C.Y);
            gr.DrawLine(pen, (float)A.X, -(float)A.Y, (float)C.X, -(float)C.Y);
            
            gr.DrawString(A.ToString(), new Font("Arial Black", 10, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), (float)A.X, -(float)A.Y);
            gr.DrawString(B.ToString(), new Font("Arial Black", 10, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), (float)B.X, -(float)B.Y);
            gr.DrawString(C.ToString(), new Font("Arial Black", 10, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), (float)C.X, -(float)C.Y);

            gr.FillRectangle(new SolidBrush(Color.Black), (float)A.X - 3, -(float)A.Y - 3, 6, 6);
            gr.FillRectangle(new SolidBrush(Color.Black), (float)B.X - 3, -(float)B.Y - 3, 6, 6);
            gr.FillRectangle(new SolidBrush(Color.Black), (float)C.X - 3, -(float)C.Y - 3, 6, 6);

        }

        public void DrawFitting(PictureBox picBox)
        {
            Vertex circleCenter = CircumcircleCenter;
            float circleRadius = (float)CircumcircleRadius;
            float xOffset = (float)circleCenter.X;
            float yOffset = (float)circleCenter.Y;
            Vertex nA = new Vertex(A.X - xOffset, A.Y - yOffset, A.Index);
            Vertex nB = new Vertex(B.X - xOffset, B.Y - yOffset, A.Index);
            Vertex nC = new Vertex(C.X - xOffset, C.Y - yOffset, A.Index);
            float k;

            k = (Math.Min(picBox.Size.Width,  picBox.Size.Height) - 20.0f ) / 2.0f / circleRadius;
            ScaleMatrix2D scale = new ScaleMatrix2D(k, k);
            nA = scale.Scale(new Vector2(nA)).ToVertex(nA.Index);
            nB = scale.Scale(new Vector2(nB)).ToVertex(nB.Index);
            nC = scale.Scale(new Vector2(nC)).ToVertex(nC.Index);

            var translated = new Triangle(nA, nB, nC);

            Pen pen = new Pen(Color.Green);

            var gr = picBox.CreateGraphics();

            gr.TranslateTransform(picBox.Size.Width / 2.0f, picBox.Size.Height / 2.0f);

            gr.DrawLine(pen, (float)translated.A.X, -(float)translated.A.Y, (float)translated.B.X, -(float)translated.B.Y);
            gr.DrawLine(pen, (float)translated.B.X, -(float)translated.B.Y, (float)translated.C.X, -(float)translated.C.Y);
            gr.DrawLine(pen, (float)translated.A.X, -(float)translated.A.Y, (float)translated.C.X, -(float)translated.C.Y);

            float pixLen = FontSize * HeighToWidthCoefficient;
            float x = (float) translated.A.X;
            float y = -(float) translated.A.Y;
            if (x > picBox.Width / 2.0f - pixLen * A.ToString().Length)
                x = picBox.Width / 2.0f - pixLen * A.ToString().Length;
            if (y < -picBox.Size.Height / 2.0f + 20.0f)
            {
                y = -picBox.Size.Height / 2.0f + 20.0f;
            }
            if (y > picBox.Size.Height / 2.0f  - 20.0f)
            {
                y = picBox.Size.Height / 2.0f - 20.0f;
            }

            gr.DrawString(A.ToString(), new Font("Arial Black", 10, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), x, y);

            x = (float)translated.B.X;
            y = -(float)translated.B.Y;
            if (x > picBox.Width / 2.0f - pixLen * B.ToString().Length)
                x = picBox.Width / 2.0f - pixLen * B.ToString().Length;
            if (y < -picBox.Size.Height / 2.0f + 20.0f)
            {
                y = -picBox.Size.Height / 2.0f + 20.0f;
            }
            if (y > picBox.Size.Height / 2.0f - 20.0f)
            {
                y = picBox.Size.Height / 2.0f - 20.0f;
            }
            
            gr.DrawString(B.ToString(), new Font("Arial Black", 10, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), x, y);
            x = (float)translated.C.X;
            y = -(float)translated.C.Y;
            if (x > picBox.Width / 2.0f - pixLen * C.ToString().Length)
                x = picBox.Width / 2.0f - pixLen * C.ToString().Length;
            if (y < -picBox.Size.Height / 2.0f + 20.0f)
            {
                y = -picBox.Size.Height / 2.0f + 20.0f;
            }
            if (y > picBox.Size.Height / 2.0f - 20.0f)
            {
                y = picBox.Size.Height / 2.0f - 20.0f;
            }
            gr.DrawString(C.ToString(), new Font("Arial Black", 10, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), x, y);


            gr.FillRectangle(new SolidBrush(Color.Red), (float)translated.A.X - 3, -(float)translated.A.Y - 3, 6, 6);
            gr.FillRectangle(new SolidBrush(Color.Red), (float)translated.B.X - 3, -(float)translated.B.Y - 3, 6, 6);
            gr.FillRectangle(new SolidBrush(Color.Red), (float)translated.C.X - 3, -(float)translated.C.Y - 3, 6, 6);

            double r = translated.CircumcircleRadius;
            circleCenter = translated.CircumcircleCenter;
            //gr.DrawEllipse(new Pen(Color.Blue), (float)(circleCenter.X - r), -(float)(circleCenter.Y + r), (float)r * 2, (float)r * 2);
            DrawCircle((float)circleCenter.X, (float)circleCenter.Y, (float)r, picBox);
        }

        public double CircumcircleArea
        {
            get
            {
                return 2 * Math.PI * Math.Pow(CircumcircleRadius, 2);
            }
        }

        public double CircumcircleRadius
        {
            get
            {
                double r = a * b * c / (4 * Area);
                return r;
            }
        }

        public Vertex CircumcircleCenter
        {
            get
            {
                double
                    xb2 = Math.Pow(B.X, 2),
                    xa2 = Math.Pow(A.X, 2),
                    xc2 = Math.Pow(C.X, 2),
                    ya2 = Math.Pow(A.Y, 2),
                    yb2 = Math.Pow(B.Y, 2),
                    yc2 = Math.Pow(C.Y, 2),
                    x = -0.5 * ((A.Y * (xb2 + yb2 - xc2 - yc2) + B.Y * (xc2 + yc2 - xa2 - ya2) + C.Y *
                                (xa2 + ya2 - xb2 - yb2)) /
                                (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y))),
                    y = 0.5 * ((A.X * (xb2 + yb2 - xc2 - yc2) + B.X * (xc2 + yc2 - xa2 - ya2) + C.X *
                               (xa2 + ya2 - xb2 - yb2)) /
                               (A.X * (B.Y - C.Y) + B.X * (C.Y - A.Y) + C.X * (A.Y - B.Y)));
                return new Vertex(x, y);
            }
        }

        public double Perimeter
        {
            get
            {
                return a + b + c;
            }
        }
        public double Area
        {
            get
            {
                double
                    //double res = Vertex.Magnitude(A, B) * Vertex.Magnitude(A, C) * Vertex.Angle(B, A, C) / 2;
                    p = Perimeter / 2,
                    res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return res;
            }
        }

        public override string ToString()
        {
            string res = A.ToString() + " " + B.ToString() + " " + C.ToString();
            return res;
        }
    }
}
