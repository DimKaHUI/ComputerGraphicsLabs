using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{

    enum Algorithm
    {
        Canonic, Parametric, Brezehghem, MiddlePoint, Library
    }

    class DrawableBuilder
    {
        private static int IntFloor(double val)
        {
            return (int) Math.Round(val);
            //return (int) val;
        }

        private static void UseCanonic(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {
            for (float x = center.X - a; x < center.Y + a; x++)
            {
                double y = Math.Sqrt(b * b * (1 - (x - center.X) * (x - center.X) / (a * a))) + center.Y;
                verts.Add(new Vertex2D(IntFloor(x), IntFloor(y)));
            }

            for (float x = center.X - a; x < center.Y + a; x++)
            {
                double y = -Math.Sqrt(b * b * (1 - (x - center.X) * (x - center.X) / (a * a))) + center.Y;
                verts.Add(new Vertex2D(IntFloor(x), IntFloor(y)));
            }

        }

        private static void WriteFigureLog(List<Vertex2D> verts)
        {
            string[] data = new string[verts.Count];
            for (int i = 0; i < verts.Count; i++)
            {
                data[i] = verts[i].ToString();
            }

            File.WriteAllLines("log.txt", data);
        }

        private static void UseParametric(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {
            float angleStep = 1.0f / Math.Max(a, b);
            double a2 = a * a;
            double b2 = b * b;
            for (float t = 0; t < Math.PI * 4; t += angleStep)
            {
                double sint = Math.Sin(t);
                double sint2 = sint * sint;
                double cost = Math.Cos(t);
                double cost2 = cost * cost;
                double p = a * b / Math.Sqrt(a2 * sint2 + b2 * cost2);
                verts.Add(new Vertex2D(center.X + IntFloor(p * cost), center.Y + IntFloor(p * sint)));
            }
            
        }

        private static void UseBrezenghem(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {
            int col, i, row, bnew;
            int aa, bb, aa2, bb2, aa4, bb4;
            bb = IntFloor(b * b);
            aa = IntFloor(a * a);
            aa2 = aa + aa;
            bb2 = bb + bb;
            aa4 = aa2 + aa2;
            bb4 = bb2 + bb2;

            row = IntFloor(b);
            col = 0;

            int d = aa2 * ((row - 1) * row) +aa + bb2 * (1 - aa);
            while (aa * (row) > bb * col)
            {
                verts.Add(new Vertex2D(center.X + col, center.Y + row));
                verts.Add(new Vertex2D(center.X + col, center.Y - row));
                verts.Add(new Vertex2D(center.X - col, center.Y + row));
                verts.Add(new Vertex2D(center.X - col, center.Y - row));

                if (d >= 0)
                {
                    row--;
                    d -= aa4 * row;
                }
                d += bb2 * (3 + (col * 2));
                col++;
            }

            d = bb2 * (col + 1) * col + aa2 * (row * (row - 2) + 1) + (1 - aa2) * bb;
            while ((row) + 1 != 0)
            {
                verts.Add(new Vertex2D(center.X + col, center.Y + row));
                verts.Add(new Vertex2D(center.X + col, center.Y - row));
                verts.Add(new Vertex2D(center.X - col, center.Y + row));
                verts.Add(new Vertex2D(center.X - col, center.Y - row));
                if (d <= 0)
                {
                    col++;
                    d += bb4 * col;
                }
                row--;
                d += aa2 * (3 - (row * 2));
            }

        }

        private static void UseMiddlepoint(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {

            float tmp = a;
            a = b;
            b = tmp;

            // Right bottom
            List<Vertex2D> arc = new List<Vertex2D>();
            int x, y;
            double d;
            double
                a2 = a * a,
                b2 = b * b,
                a2a = 2 *a2,
                b2b = 2 * b2;

            x = 0;
            y = IntFloor(a);
            d = a2 + b2 *(-a + 0.25f);
            while (b2 * (y - 0.5f) > a2 * x)
            {
                if (d < 0)
                {
                    d += a2*(2*x+3);
                    x++;
                }
                else
                {
                    d += a2 * (2 * x + 3) + b2b * (1 - y);
                    x++;
                    y--;
                }
                arc.Add(new Vertex2D(x, y));
            }

            d = b2 + a2 * (-b + 0.25f);
            x = IntFloor(b);
            y = 0;
            double st = Math.Sqrt(a2 + b2);
            while ((b2 * (y - 0.5) <= a2 * x) && (x >= b2 / st) && (y <= a2 / st))
            {
                if (d < 0)
                {
                    d += b2 * (2 * y + 3);
                    y++;
                }
                else
                {
                    d += a2a * (1 - x) + b2 * (3 + 2 * y);
                    y++;
                    x--;
                }
                arc.Add(new Vertex2D(x, y));
            }

            int count = arc.Count;

            for (int i = 0; i < count; i++)
            {
                Vertex2D v = arc[i];
                v.X = -v.X;
                arc.Add(v);
            }

            count += count;
            for (int i = 0; i < count; i++)
            {
                Vertex2D v = arc[i];
                v.Y = -v.Y;
                arc.Add(v);
            }

            for (int i = 0; i < arc.Count; i++)
            {
                verts.Add(new Vertex2D(center.X + arc[i].X, center.Y + arc[i].Y));
            }
        }

        public static IDrawable BuildCircle(Vertex2D center, int radius, Color color, Algorithm alg)
        {
            List<Vertex2D> verts = new List<Vertex2D>();
            Image res;
            switch (alg)
            {
                case Algorithm.Canonic:
                    UseCanonic(verts, center, radius, radius);
                    break;
                case Algorithm.Parametric:
                    UseParametric(verts, center, radius, radius);
                    break;
                case Algorithm.Brezehghem:
                    UseBrezenghem(verts, center, radius, radius);
                    break;
                case Algorithm.MiddlePoint:
                    UseMiddlepoint(verts, center, radius, radius);
                    break;
                case Algorithm.Library:
                    return new AutoEllipse(center, radius * 2, radius * 2, color);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("alg", alg, null);
            }

            //WriteFigureLog(verts);

            res = new Image(verts.ToArray(), color);
            return res;
        }

        public static IDrawable BuildEllipse(Vertex2D center, float a, float b, Color color, Algorithm alg)
        {
            List<Vertex2D> verts = new List<Vertex2D>();
            Image res;
            switch (alg)
            {
                case Algorithm.Canonic:
                    UseCanonic(verts, center, a, b);
                    break;
                case Algorithm.Parametric:
                    UseParametric(verts, center, a, b);
                    break;
                case Algorithm.Brezehghem:
                    UseBrezenghem(verts, center, a, b);
                    break;
                case Algorithm.MiddlePoint:
                    UseMiddlepoint(verts, center, a, b);
                    break;
                case Algorithm.Library:
                    return new AutoEllipse(center, a * 2, b * 2, color);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("alg", alg, null);
            }

            //WriteFigureLog(verts);

            res = new Image(verts.ToArray(), color);
            return res;
        }
    }
}
