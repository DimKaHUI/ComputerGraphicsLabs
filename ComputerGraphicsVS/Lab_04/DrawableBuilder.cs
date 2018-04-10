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
        private static int IntRound(double val)
        {
            return (int) Math.Round(val);
        }

        private static void UseCanonic(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {
            double bb = b * b;
            double aa = a * a;
            for (float x = 0; x < a; x++)
            {
                double hx2 = (x) * (x);
                double y = Math.Sqrt(bb * (1 - hx2 / aa));
                int resX = IntRound(x);
                int resY = IntRound(y);

                verts.Add(new Vertex2D(center.X + resX, center.Y + resY));
                verts.Add(new Vertex2D(center.X + resX, center.Y - resY));
                verts.Add(new Vertex2D(center.X - resX, center.Y + resY));
                verts.Add(new Vertex2D(center.X - resX, center.Y - resY));                
            }

            for (float y = 0; y < b / 1.5f; y++)
            {
                double hy2 = (y) * (y);
                double x = Math.Sqrt(aa * (1 - hy2 / bb));
                int resX = IntRound(x);
                int resY = IntRound(y);
                verts.Add(new Vertex2D(center.X + resX, center.Y + resY));
                verts.Add(new Vertex2D(center.X + resX, center.Y - resY));
                verts.Add(new Vertex2D(center.X - resX, center.Y + resY));
                verts.Add(new Vertex2D(center.X - resX, center.Y - resY));
            }
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
                int xRes = IntRound(p * cost);
                int yRes = IntRound(p * sint);
                verts.Add(new Vertex2D(center.X + xRes, center.Y + yRes));
            }
            
        }

        private static void UseBrezenghem(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {
            int x, y;
            int aa, bb, aa2, bb2, aa4, bb4, aa8, bb8;
            bb = IntRound(b * b);
            aa = IntRound(a * a);
            aa2 = aa + aa;
            bb2 = bb + bb;
            aa4 = aa2 + aa2;
            bb4 = bb2 + bb2;
            aa8 = aa4 + aa4;
            bb8 = bb4 + bb4;

            y = IntRound(b);
            x = 0;

            //int d = aa2 * ((x - 1) * y) + aa + bb2 * (1 - aa);
            int d = bb4 * (x + 1) * (x + 1) + aa * (2 * y - 1) * (2 * y - 1) - aa4 * bb;
            while (aa * (2 * y - 1) > bb2 * (x + 1))
            {
                verts.Add(new Vertex2D(center.X + x, center.Y + y));
                verts.Add(new Vertex2D(center.X + x, center.Y - y));
                verts.Add(new Vertex2D(center.X - x, center.Y + y));
                verts.Add(new Vertex2D(center.X - x, center.Y - y));
                
                if (d >= 0)
                {
                    d -= aa8 * (y - 1);
                    y--;
                }
                d += bb4 * (2 * x + 3);
                x++;
            }

            //d = bb2 * (x + 1) * x + aa2 * (y * (y - 2) + 1) + (1 - aa2) * bb;
            int tx = (2 * x + 1);
            int ty = (y + 1);
            d = bb * tx * tx + aa4 * ty * ty - aa4 * bb;
            while ((y) + 1 != 0)
            {
                verts.Add(new Vertex2D(center.X + x, center.Y + y));
                verts.Add(new Vertex2D(center.X + x, center.Y - y));
                verts.Add(new Vertex2D(center.X - x, center.Y + y));
                verts.Add(new Vertex2D(center.X - x, center.Y - y));
                if (d >= 0)
                {
                    d -= bb8 * (x + 1);
                    x++;
                }
                d += aa4 * (2 * y + 3);
                y--;
            }

        }

        private static void UseBrezenghemAlt(List<Vertex2D> verts, Vertex2D center, float rx, float ry)
        {
            int rx2 = (int)(rx * rx);//a^2
            int ry2 = (int)(ry * ry);//b^2
            int r2y2 = 2 * ry2;
            int r2x2 = 2 * rx2;
            int x = 0, y = (int)ry;
            //f(x,y)=x^2*b^2+a^2y^2-a^2*b^2=0 из каноического          


            //error=b^2*(x+1)^2 + a^2*(y-1)^2-a^2*b^2=
            int d = rx2 + ry2 - r2x2 * y;
            int d1, d2;

            while (y >= 0)
            {
                //AddPoint(ref bitmap, cx, cy, x, y, drawcolor);
                verts.Add(new Vertex2D(center.X + x, center.Y + y));
                verts.Add(new Vertex2D(center.X - x, center.Y + y));
                verts.Add(new Vertex2D(center.X + x, center.Y - y));
                verts.Add(new Vertex2D(center.X - x, center.Y - y));

                if (d < 0)//гор и диаг
                {
                    d1 = 2 * d + r2x2 * y - 1;
                    if (d1 > 0) //диагональная
                    {
                        y -= 1;
                        x += 1;
                        d += r2y2 * x + ry2 + rx2 - r2x2 * y;//b^2 (2x+1)+a^2(1-2y)
                    }
                    else     //гор
                    {
                        x += 1;
                        d += r2y2 * x + ry2;    //+b^2 (2x+1)
                    }
                }
                else if (d == 0)//диагональная
                {
                    x += 1;
                    y -= 1;
                    d += r2y2 * x + ry2 + rx2 - r2x2 * y;
                }
                else
                {
                    d2 = 2 * d - r2y2 * x - 1; //2d-b^2x-1
                    if (d2 < 0) //диагональная
                    {
                        y -= 1;
                        x += 1;
                        d += r2y2 * x + ry2 + rx2 - r2x2 * y;
                    }
                    else//вертикальная
                    {
                        y -= 1;
                        d += rx2 - r2x2 * y;  //a^2(1-2y)
                    }
                }
            } //end while

        }

        private static void UseMiddlepoint(List<Vertex2D> verts, Vertex2D center, float a, float b)
        {

            float tmp = a;
            a = b;
            b = tmp;

            int x, y;
            double d;
            double
                a2 = a * a,
                b2 = b * b,
                a2a = 2 *a2,
                b2b = 2 * b2;

            x = 0;
            y = IntRound(a);
            d = a2 + b2 *(-a + 0.25f);
            while (b2 * (y - 0.5f) > a2 * x)
            {
                verts.Add(new Vertex2D(center.X + x, center.Y + y));
                verts.Add(new Vertex2D(center.X + x, center.Y - y));
                verts.Add(new Vertex2D(center.X - x, center.Y + y));
                verts.Add(new Vertex2D(center.X - x, center.Y - y));
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
               
            }

            d = b2 + a2 * (-b + 0.25f);
            x = IntRound(b);
            y = 0;
            double st = Math.Sqrt(a2 + b2);
            while ((b2 * (y - 0.5) <= a2 * x) && (x >= b2 / st) && (y <= a2 / st))
            {
                verts.Add(new Vertex2D(center.X + x, center.Y + y));
                verts.Add(new Vertex2D(center.X + x, center.Y - y));
                verts.Add(new Vertex2D(center.X - x, center.Y + y));
                verts.Add(new Vertex2D(center.X - x, center.Y - y));
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
            }

        }

        public static IDrawable BuildCircle(Vertex2D center, int radius, Color color, Algorithm alg)
        {
            return BuildEllipse(center, radius, radius, color, alg);
        }

        public static IDrawable BuildEllipse(Vertex2D center, float a, float b, Color color, Algorithm alg)
        {
            List<Vertex2D> verts = new List<Vertex2D>();
            switch (alg)
            {
                case Algorithm.Canonic:
                    UseCanonic(verts, center, a, b);
                    break;
                case Algorithm.Parametric:
                    UseParametric(verts, center, a, b);
                    break;
                case Algorithm.Brezehghem:
                    //UseBrezenghem(verts, center, a, b);
                    UseBrezenghemAlt(verts, center, a, b);
                    break;
                case Algorithm.MiddlePoint:
                    UseMiddlepoint(verts, center, a, b);
                    break;
                case Algorithm.Library:
                    return new AutoEllipse(center, a * 2, b * 2, color);
                default:
                    throw new ArgumentOutOfRangeException("alg", alg, null);
            }

            //WriteFigureLog(verts);

            var res = new Image(verts.ToArray(), color);
            return res;
        }
    }
}
