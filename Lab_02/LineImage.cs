using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    class LineImage : Image
    {
        public LineImage(Vector2 a, Vector2 b, Pen pen) : base(pen)
        {
            Points.Add(a);
            Points.Add(b);
        }

        public LineImage(float x1, float y1, float x2, float y2, Pen pen) : base(pen)
        {
            Points.Add(new Vector2(x1, y1));
            Points.Add(new Vector2(x2, y2));
        }
    }
}
