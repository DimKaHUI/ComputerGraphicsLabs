using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    struct Vertex2D
    {
        public int X;
        public int Y;

        public Vertex2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}", X, Y);
        }
    }
}
