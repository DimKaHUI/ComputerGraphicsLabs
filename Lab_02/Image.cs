using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_02
{
    class Image : IDrawable, ICloneable
    {
        public Pen Pen;
        public List<Vector2> Points = new List<Vector2>();

        public Image(Pen pen)
        {
            Pen = pen;
        }
        public virtual void Draw(PictureBox picBox)
        {
            Graphics gr = picBox.CreateGraphics();
            gr.TranslateTransform(picBox.Width / 2.0f, picBox.Height / 2.0f);
            for (int i = 1; i < Points.Count; i++)
            {
                gr.DrawLine(Pen, Points[i - 1].X, -Points[i - 1].Y, Points[i].X, -Points[i].Y);
            }
            if(Points.Count > 2)
                gr.DrawLine(Pen, Points[0].X, -Points[0].Y, Points[Points.Count - 1].X, -Points[Points.Count - 1].Y);
        }

        public virtual void RotateAround(float angle, Vector2 center)
        {
            
            RotationMatrix2D rot = new RotationMatrix2D(angle);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = rot.RotateAround(Points[i], center);
            }
        }

        public virtual void Scale(float kx, float ky, Vector2 center)
        {
            //ScaleMatrix2D scale = new ScaleMatrix2D(kx, ky);
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = ScaleMatrix2D.ScaleFromAnalitic(Points[i], center, new Vector2(kx, ky));
            }
        }

        public virtual void Translate(float dx, float dy)
        {
            for (int i = 0; i < Points.Count; i++)
            {
                Points[i] = new Vector2(Points[i].X + dx, Points[i].Y + dy);
            }
        }

        public virtual object Clone()
        {
            Image clone = new Image(Pen);
            clone.Pen = Pen;
            clone.Points = new List<Vector2>();
            for (int i = 0; i < Points.Count; i++)
            {
                clone.Points.Add(Points[i]);
            }
            return clone;
        }
    }
}
