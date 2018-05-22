using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KG_LABA7
{
    class Algo
    {
        private int xLeft, xRight, yTop, yBot;
        private readonly Graphics g;
        
       
        //31
        private void DrawLine(Point p1, Point p2, bool visible)
        {
            if (visible)
            {
                Pen pen = new Pen(Color.Red, 2);
                g.DrawLine(pen, p1, p2);
            }
        }

        private int GetPointCodeSumm(int[] pointCode)
        {
            int res = 0;
            foreach (var n in pointCode)
                res += n;
            return res;
        }

        private int GetLogicalProduct(int[] code1, int[] code2)
        {
            int res = 0;
            for (int i = 0; i < 4; i++)
            {
                res += code1[i] * code2[i];
            }
            return res;
        }

        private int[] GetPointCode(Point p)
        {
            int[] t = new int[4] {0, 0, 0, 0};
            if (p.X < xLeft) t[3] = 1;
            if (p.X > xRight) t[2] = 1;
            if (p.Y < yBot) t[1] = 1; // Ниже окна
            if (p.Y > yTop) t[0] = 1; // Выше окна
            return t;
        }

        private void ProceedSegment(Point p1, Point p2)
        {
            bool go15 = false;

            //Point r1 = Point.Empty, r2 = Point.Empty; // Resulting points
            Point[] ri = new Point[]{Point.Empty, Point.Empty, Point.Empty};
            Point q = Point.Empty; // Working variable;
            int iteration; // Iteration number

            // 3. Calculating point codes T1 and T2
            int[] t1 = GetPointCode(p1);
            int[] t2 = GetPointCode(p2);
            // Calculating code summs
            int s1 = GetPointCodeSumm(t1);
            int s2 = GetPointCodeSumm(t2);

            // 4. Setting visibility property
            int visible = 1;

            // 5. Setting initial targent
            double tangent = 10e30;

            // 6. Checking of full visibility
            if (s1 == 0 && s2 == 0)
            {
                // Is fully visible
                ri[1]= p1;
                ri[2] = p2;

                // Nothing to do here, but to draw
                DrawLine(ri[1], ri[2], true);
                return;
            }


            // Is not fully visible
            // 7. Calculating logical product
            int logicalProd = GetLogicalProduct(t1, t2);


            // 8. Checking if segment is fully invisible
            if (logicalProd != 0)
            {
                // Invisible, nothing to do here
                visible = -1;
                return;
            }

            // 9. Checking first point visibility
            if (s1 == 0)
            {
                // First point is visible
                ri[1] = p1;
                q = p2;
                iteration = 2;
                // goto 15
                go15 = true;
            }
            else
            {
                
                // 10. Checking second point visibility
                if (s2 == 0)
                {
                    // Second point is visible
                    ri[1] = p2;
                    q = p1;
                    iteration = 2;
                    // goto 15
                    go15 = true;
                }
                else
                {
                    // 11. Set i = 0
                    iteration = 0;
                }
            }

            while (true)
            {
                if (!go15)
                {
                    // 12.
                    iteration++;

                    // 13. Checking iteration
                    if (iteration > 2)
                    {
                        DrawLine(ri[1], ri[2], Convert.ToBoolean(visible));
                        return;
                    }

                    // 14. Setting Q
                    if(iteration == 1)
                        q = p1;
                    if (iteration == 2)
                        q = p2;
                }
                else
                {
                    go15 = false;
                }

                // 15. Checking segment placement
                if (p1.X == p2.X)
                {
                    // Segment is vertical
                    // goto 23
                }
                else
                {
                    // 16. Calculating tangent
                    tangent = (double) (p2.Y - p1.Y) / (p2.X - p1.X);

                    // 17. Checking crossing left edge possibility
                    if (q.X > xLeft) 
                    {
                        // q правее левой грани, нет пересечения
                        // goto 20
                    }
                    else
                    {
                        // 18. Calculating Y of crossing left edge
                        double yp = tangent * (xLeft - q.X) + q.Y;

                        // 19. Checking if correct
                        if (yp >= yBot && yp <= yTop)
                        {
                            ri[iteration].X = xLeft;
                            ri[iteration].Y = (int) Math.Round(yp);
                        }
                    }

                    // 20. Checking crossing right edge possibility
                    if (q.X < xRight)
                    {
                        // goto 23
                    }
                    else
                    {
                        // 21. Calculating Y of crossing rith edge
                        double yp = tangent * (xRight - q.X) + q.Y;

                        // 22. Checking if correct
                        if (yp >= yBot && yp <= yTop)
                        {
                            ri[iteration].X = xRight;
                            ri[iteration].Y = (int) Math.Round(yp); // NOT FOUND
                            continue; // goto 12
                        }
                    }
                }

                // 23. Checking if horizontal
                if (Math.Abs(tangent) < 1e-6)
                {
                    continue;
                }

                // 24. Checking crossing top edge possibility
                if (q.Y < yTop)
                {
                    // No crossing
                    // goto 27
                }
                else
                {
                    // 25. Calculating crossing X
                    double xp = (yTop - q.Y) / tangent + q.X;
                    
                    // 26. Checking if correct
                    if (xp >= xLeft && xp <= xRight)
                    {
                        ri[iteration].X = (int)Math.Round(xp);
                        ri[iteration].Y = yTop;
                        // goto 12
                        continue;
                    }
                }

                // 27. Checking crossing bottom edge possibility
                if (q.Y > yBot)
                {
                    // No crossing
                    // goto 30
                    //break;
                    continue;
                }
                else
                {
                    // 28. Calculating crossing X
                    double xp = (yBot - q.Y) / tangent + q.X;

                    // 29. Checking if correct
                    if (xp >= xLeft && xp <= xRight)
                    {
                        ri[iteration].X = (int)Math.Round(xp);
                        ri[iteration].Y = yBot;
                        // goto 12
                        continue;
                    }
                }
            }

            // 30. Setting visibility flag to "invisible"
            visible = 0;
            DrawLine(ri[1], ri[2], Convert.ToBoolean(visible));
        }


        public Algo(List<Point> points,Rectangle rect,ref Graphics g)
        {
            this.g = g;


            xLeft = rect.X;
            yTop = rect.Y + rect.Size.Height;
            //yTop = rect.Y;
            xRight = rect.Location.X + rect.Size.Width;
            yBot = rect.Location.Y;
            //yBot = rect.Y + rect.Size.Height;

            for (int i = 0; i < points.Count() / 2; i++)
            {
                ProceedSegment(points[i * 2], points[i * 2 + 1]);
            }
        }
    }
}
