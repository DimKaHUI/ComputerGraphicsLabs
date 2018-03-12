using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02
{
    class TriangleImage : Image
    {
        public TriangleImage(Vector2 a, Vector2 b, Vector2 c, Pen pen)
            : base(pen)
        {
            Points.Add(a);;
            Points.Add(b);
            Points.Add(c);
        }
    }
}
