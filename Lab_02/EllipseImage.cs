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

        public EllipseImage(float a, float b, Pen pen) : base(pen)
        {
            float step;
            for (float fi = 0; fi < Math.PI * 2.0f; fi += step)
            {
                float sinFi = (float)Math.Sin(fi);
                float cosFi = (float) Math.Cos(fi);
                float r = (float)(a * b / Math.Sqrt(a * a * sinFi * sinFi +
                                                                b * b * cosFi * cosFi));
                step = 1 / r;
                float x = (float)(r * cosFi);
                float y = (float)(r * sinFi);
                Points.Add(new Vector2(x, y));
            }
        }
    }
}
