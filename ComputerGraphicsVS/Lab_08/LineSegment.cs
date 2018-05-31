using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    class LineSegment
    {
        public Point Start { get; set; }
        public Point End { get; set; }

        public LineSegment(Point a, Point b)
        {
            Start = a;
            End = b;
        }

        public static List<LineSegment> FromPointList(List<Point> points)
        {
            int count = points.Count / 2;
            List<LineSegment> lines = new List<LineSegment>(count);
            for (int i = 0, j = 0; i < points.Count - 1; i += 2, j++)
                lines.Add(new LineSegment(points[i], points[i + 1]));
            
            return lines;
        }
    }
}
