using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_02
{
    class Figure : ICloneable
    {
        public const float CircleA = 80;
        public const float CircleB = 60;
        public const double Deg2Rad = Math.PI / 180;

        private readonly PictureBox _box;
        private readonly Graphics _gr;

        private readonly  Image[] _images = new Image[7];

        private Figure(PictureBox picBox, Image[] images)
        {
            _box = picBox;
            _gr = _box.CreateGraphics();
            _gr.TranslateTransform(picBox.Width / 2.0f, picBox.Height / 2.0f);

            _images = new Image[images.Length];
            for (int i = 0; i < images.Length; i++)
            {
                _images[i] = (Image)images[i].Clone();
            }
        }

        public Figure(PictureBox picBox)
        {
            _box = picBox;
            _gr = _box.CreateGraphics();
            _gr.TranslateTransform(picBox.Width / 2.0f, picBox.Height / 2.0f);

            // Body
            _images[0] = new EllipseImage(80, 60, new Pen(Color.Black));

            // Head
            _images[1] = new EllipseImage(20, 20, new Pen(Color.Black));
            _images[1].Translate(-80, 49);

            // Nose
            _images[2] = new TriangleImage(new Vector2(-90, 50), new Vector2(-140, 40), new Vector2(-90, 40), new Pen(Color.Black));
            
            // Tail
            _images[3] = new TriangleImage(new Vector2(70, 20), new Vector2(100, 20), new Vector2(80, 0), new Pen(Color.Black));

            // Wing
            _images[4] = new TriangleImage(new Vector2(30, -30), new Vector2(80, -100), new Vector2(60, -30), new Pen(Color.Black));

            // Left leg
            _images[5] = new LineImage(new Vector2(-50, -46), new Vector2(-100, -100), new Pen(Color.Black));

            // Right leg
            _images[6] = new LineImage(new Vector2(-20, -57), new Vector2(-20, -110), new Pen(Color.Black));

        }

        public void Draw(Vector2 pos, Vector2 rotCenter, float rotationAngle, Vector2 scaleCenter, float kx, float ky)
        {
            _gr.Clear(Color.White);

            foreach (var img in _images)
            {
                if (img == null)
                    continue;
                img.Scale(kx, ky, scaleCenter);
                img.RotateAround((float)(rotationAngle * Deg2Rad), rotCenter);
                img.Translate(pos.X, pos.Y);
                img.Draw(_box);
            }
        }

        public void Draw()
        {
            _gr.Clear(Color.White);
            foreach (var img in _images)
            {
                if (img == null)
                    continue;
                img.Draw(_box);
            }
        }

        public object Clone()
        {
            Figure f = new Figure(_box, _images);
            return f;
        }
    }
}
