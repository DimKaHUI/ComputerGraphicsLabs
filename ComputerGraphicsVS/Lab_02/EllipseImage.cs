using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class EllipseImage : Image
    {

        public EllipseImage(float a, float b, Pen pen, float angleStepFactor) : base(pen)
        {
            if (angleStepFactor < 1)
            {
                throw new ArgumentException("AngleStepFactor must be equal to 1 or greater");
            }

            float step;
            for (float fi = 0; fi < Math.PI * 2.0f; fi += step)
            {
                float r = (float)(a * b / Math.Sqrt(Math.Pow(a, 2) * Math.Pow(Math.Sin(fi), 2) +
                                                                Math.Pow(b, 2) * Math.Pow(Math.Cos(fi), 2)));
                step = 1 / r * angleStepFactor;
                float x = (float)(r * Math.Cos(fi));
                float y = (float)(r * Math.Sin(fi));
                Points.Add(new Vector2(x, y));
            }
        }
    }
}
