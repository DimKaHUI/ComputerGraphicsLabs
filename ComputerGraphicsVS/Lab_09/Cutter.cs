using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_09
{
    static class Cutter
    {
        struct Vector
        {
            public int x;
            public int y;
            public int z;

            public Vector(int a, int b, int c = 0)
            {
                x = a;
                y = b;
                z = c;
            }
            public Vector(Point end, Point start)
            {
                x = end.X - start.X;
                y = end.Y - start.Y;
                z = 0;
            }
            public static void VectorMult(Vector a, Vector b, ref Vector res)
            {
                res.x = a.y * b.z - a.z * b.y;
                res.y = a.z * b.x - a.x * b.z;
                res.z = a.x * b.y - a.y * b.x;
            }
        };

        public static int GetDirection(List<Point> poligon)
        {
            // Если знаки всех в-орных произведений смежных сторон равны 0,
            // то прямоуг - отрезок
            // Если есть и положит. и  отриц., то многоуг невыпуклый
            // Если все неотрицательные, то выпуклый и нормали напр. влево
            // Если все неположительны, то выпуклый и нормали напр. вправо

            Vector a = new Vector(poligon[1], poligon[0]);
            Vector b = new Vector();
            Vector tmp = new Vector();
            int n = poligon.Count;

            int res = 0;

            for (int i = 1; i < n - 1; i++)
            {
                b = new Vector(poligon[i + 1], poligon[i]);
                Vector.VectorMult(a, b, ref tmp);

                if (res == 0)
                    res = Math.Sign(tmp.z);

                if (res != Math.Sign(tmp.z))
                {
                    if (tmp.z != 0)
                        return 0;
                }
                a = b;
            }

            b = new Vector(poligon[1], poligon[0]);
            Vector.VectorMult(a, b, ref tmp);

            if (res == 0)
                res = Math.Sign(tmp.z);

            if (res != Math.Sign(tmp.z))
            {
                if (tmp.z != 0)
                    return 0;
            }

            return res;
        }

        private static int VectorMultZ(int ax, int ay, int bx, int by) //векторное произведение
        {
            return ax * by - bx * ay;
        }

        public static bool IsVisible(Point s, Point e, Point p, int side)
        {
            double z = (p.X - s.X) * (e.Y - s.Y) - (e.X - s.X) * (p.Y - s.Y);
            
            // Point is on the left side
            if (Math.Abs(z) < 1e-6)
                return true;
            return Math.Sign(side) == Math.Sign(z);
        }


        public static bool HasIntersection(Point s1, Point e1, Point s2, Point e2, out Point sec)
        {
            sec = Point.Empty;
            
            double resX = 0;
            double resY = 0;

            double kf, kg;

            // Finding coefficients
            if (s1.X - e1.X == 0)
                kf = Double.PositiveInfinity;
            else
                kf = (double)(s1.Y - e1.Y) / (s1.X - e1.X);

            if (s2.X - e2.X == 0)
                kg = Double.PositiveInfinity;
            else
                kg = (double)(s2.Y - e2.Y) / (s2.X - e2.X);
            
            // Finding B
            double bf = s1.Y - kf * s1.X;
            double bg = s2.Y - kg * s2.X;

            if (Math.Abs(kf - kg) < 1e-6)
                return false;

            resX = (bg - bf) / (kf - kg);
            resY = kf * resX + bf;

            sec = new Point((int)Math.Round(resX), (int)Math.Round(resY));

            // Check if lies on first segment
            bool correct = true;

            double minX = Math.Min(s1.X, e1.X);
            double maxX = Math.Max(s1.X, e1.X);

            double minY = Math.Min(s1.Y, e1.Y);
            double maxY = Math.Max(s1.Y, e1.Y);

            correct &= resX >= minX && resX <= maxX && resY >= minY && resY <= maxY;

            // Check if lies on second segment
            minX = Math.Min(s2.X, e2.X);
            maxX = Math.Max(s2.X, e2.X);

            minY = Math.Min(s2.Y, e2.Y);
            maxY = Math.Max(s2.Y, e2.Y);

            correct &= resX >= minX && resX <= maxX && resY >= minY && resY <= maxY;

            return correct;
        }

        public static List<Point> Cut(List<Point> polygonArg, List<Point> cutter)
        {
            List<Point> result = new List<Point>();
            List<Point> polygon = new List<Point>(polygonArg);

            if (polygon.Count < 4)
            {
                throw new ArgumentException("Слишком мало вершин в многоугольнике", nameof(polygon));
            }

            if (cutter.Count < 4)
            {
                throw new ArgumentException("Слишком мало вершин в отсекателе", nameof(cutter));
            }

            int dir = GetDirection(cutter);

            if(dir == 0)
                throw new ArgumentException("Отсекатель должен быть выпуклым", nameof(cutter));

            polygon.RemoveAt(polygon.Count - 1);

            // 1. 

            // 2. Cycle foreach cutter's edge
            Point s = polygon[0];
            for (int i = 0; i < cutter.Count - 1; i++)
            {
                //nq = 0; // 2.1. Setting number of resulting vertexes to zero
                result = new List<Point>();

                Point f = Point.Empty;
                // 2.2 Cycle foreach polygon's edge
                for (int j = 0; j < polygon.Count; j++)
                {
                    // 2.2.1
                    if (j == 0) // j == 1 (first vertex)
                    {
                        f = polygon[0];
                        // goto 2.2.5
                    }
                    else
                    {
                        // 2.2.2 | 2.2.3
                        Point t;
                        bool intersected = HasIntersection(
                            s,
                            polygon[j],
                            cutter[i],
                            cutter[i + 1], out t);
                        if (intersected)
                        {
                            // 2.2.4 Increasing number of resulting vertexes
                            //nq++;
                            result.Add(t);
                        }
                        // else goto 2.2.5
                    }

                    // 2.2.5
                    s = polygon[j];

                    // 2.2.6 Checking visibility of S against C_j C_j-1, adding S to result
                    if (IsVisible(cutter[i], cutter[i + 1], s, -dir))
                    {
                        result.Add(s);
                    }

                    // 2.2.7 end of inner cycle
                }

                // 2.3 Checking if nq != 0
                if (result.Count != 0)
                {
                    // 2.4
                    Point t;
                    bool intersected = HasIntersection(
                        s,
                        f,
                        cutter[i],
                        cutter[i + 1], out t);
                    if (intersected)
                    {
                        // 2.6 Increasing number of resulting vertexes
                        //nq++;
                        result.Add(t);
                    }
                    else
                    {
                        // goto 2
                    }
                }
                else
                {
                    polygon.Add(polygon[0]);
                    return result;
                }
                // 2.7 ????
                polygon = new List<Point>(result);
                // 2.8
            }

            polygon.Add(polygon[0]);
            result.Add(result[0]);
            // 2.9
            return result;
        }

    }
}
