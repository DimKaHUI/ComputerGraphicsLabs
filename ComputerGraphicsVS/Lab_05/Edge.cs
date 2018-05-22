using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05
{
    class Edge
    {
        public Point Start;
        public Point End;

        public Edge(Point a, Point b)
        {
            Start = a;
            End = b;
        }

        public Edge()
        {
            Start = Point.Empty;
            End = Point.Empty;
        }
    }
 
}
