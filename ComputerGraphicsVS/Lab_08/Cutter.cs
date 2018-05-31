using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_08
{
    static class Cutter
    {
        struct Vector
        {
            public int x;
            public int y;
            public int z;

            public Vector(Point end, Point start)
            {
                x = end.X - start.X;
                y = end.Y - start.Y;
                z = 0;
            }

            public Vector(int a, int b, int c = 0)
            {
                x = a;
                y = b;
                z = c;
            }

            public static int ScalarMultiplication(Vector a, Vector b)
            {
                return a.x * b.x + a.y * b.y + a.z * b.z;
            }

            public static Vector VectorMult(Vector a, Vector b)
            {
                Vector res = new Vector();
                res.x = a.y * b.z - a.z * b.y;
                res.y = a.z * b.x - a.x * b.z;
                res.z = a.x * b.y - a.y * b.x;
                return res;
            }
        }

        private static int GetDirection(List<Point> polygon)
        {
            // Если знаки всех в-орных произведений смежных сторон равны 0,
            // то прямоуг - отрезок
            // Если есть и положит. и  отриц., то многоуг невыпуклый
            // Если все неотрицательные, то выпуклый и нормали напр. влево
            // Если все неположительны, то выпуклый и нормали напр. вправо

            Vector a = new Vector(polygon[1], polygon[0]);
            Vector b = new Vector();
            Vector tmp = new Vector();
            int n = polygon.Count;

            int res = 0;

            for (int i = 1; i < n - 1; i++)
            {
                b = new Vector(polygon[i + 1], polygon[i]);
                tmp = Vector.VectorMult(a, b);

                if (res == 0)
                    res = Math.Sign(tmp.z);

                if (res != Math.Sign(tmp.z))
                {
                    if (tmp.z != 0)
                        return 0;
                }
                a = b;
            }

            b = new Vector(polygon[1], polygon[0]);
            tmp = Vector.VectorMult(a, b);

            if (res == 0)
                res = Math.Sign(tmp.z);

            if (res != Math.Sign(tmp.z))
            {
                if (tmp.z != 0)
                    return 0;
            }

            return res;
        }

        private static List<Vector> GetNormals(List<Point> polygon, int direction)
        {
            List<Vector> result = new List<Vector>(polygon.Count);

            int n = polygon.Count - 1;

            Vector b;

            for (int i = 0; i < n; i++)
            {
                b = new Vector(polygon[i + 1], polygon[i]);

                if(direction == -1)
                    result.Add(new Vector(b.y, -b.x));
                else
                    result.Add(new Vector(-b.y, b.x));
            }

            b = new Vector(polygon[0], polygon[n]);
            if (direction == -1)
                result.Add(new Vector(b.y, -b.x));
            else
                result.Add(new Vector(-b.y, b.x));

            return result;
        }

        private static Point SegmentParametric(double t, Point p1, Point p2)
        {
            Point tmp = new Point();
            tmp.X = p1.X + (int)(Math.Round((p2.X - p1.X) * t));
            tmp.Y = p1.Y + (int)(Math.Round((p2.Y - p1.Y) * t));
            return tmp;
        }

        private static List<Point> CutSegment(List<Point> cutter, LineSegment seg, List<Vector> normals)
        {
            List<Point> result = new List<Point>();

            bool visible = false;

            int n = cutter.Count;

            Vector d, w;
            int dSm, wSm;

            double tBot = 0, tTop = 1;
            double t;

            d = new Vector(seg.End, seg.Start); // Segment's vector

            for (int i = 0; i < n; i++) // For each cutter's edge
            {
                w = new Vector(seg.Start, cutter[i]); // Vector from line's start to cutter's edge

                dSm = Vector.ScalarMultiplication(d, normals[i]); // Side of line
                wSm = Vector.ScalarMultiplication(w, normals[i]); // Visibility for parallels
                
                // If line and edge are parallel (Scalar. m. is zero)
                if (dSm == 0)
                {
                    if (wSm < 0)
                    {
                        result.Clear();
                        return result; // segment is fully invisible
                    }
                }
                else
                {
                    // Calculating T parametr
                    t = -wSm / (double) dSm;

                    if (dSm > 0)
                    {
                        // Out of segment, no crossing
                        if (t > 1)
                            return result;
                        else
                        {
                            // P is oriented from in to outside.
                            // tA is tE now, if tE > tA
                            tBot = Math.Max(tBot, t);
                        }
                    }
                    else // dSm < 0
                    {
                        if (t < 0)
                            return result;
                        else
                        {
                            // P is oriented from out to inside
                            // tB is tE now, if tE < tB
                            tTop = Math.Min(tTop, t);
                        }
                    }
                }
            }

            if (tBot <= tTop)
            {
                Point tmp = SegmentParametric(tBot, seg.Start, seg.End);
                Point p2 = SegmentParametric(tTop, seg.Start, seg.End);
                Point p1 = tmp;
                result.Add(p1);
                result.Add(p2);
            }
            return result;
        }

        public static List<LineSegment> Cut(List<Point> cutter, List<LineSegment> segs)
        {
            int direction = GetDirection(cutter);

            if(direction == 0)
                throw new ArgumentException("Отсекатель должен быть выпуклым", "cutter");

            List<LineSegment> result = new List<LineSegment>();
            List<Vector> normals = GetNormals(cutter, direction);

            for(int i = 0; i < segs.Count; i++)
            {
                List<Point> cutted = CutSegment(cutter, segs[i], normals);
                result.AddRange(LineSegment.FromPointList(cutted));
            }

            return result;
        }
    }
}
