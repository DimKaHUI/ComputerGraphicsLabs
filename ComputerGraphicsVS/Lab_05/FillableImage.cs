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
    class FillingEdge
    {
        public int S, E, Y;

        public FillingEdge(int a, int b, int y)
        {
            S = a;
            E = b;
            Y = y;
        }

        public FillingEdge()
        {
            S = 0;
            E = 0;
            Y = 0;
        }
    }

    class NotEnoughVerts : Exception
    {

    }

    class FillableImage
    {
        private List<Point> _vertexes;
        private List<FillingEdge> _fillingEdges;
        private Color _edgeColor;
        private Color _fillColor;

        public FillableImage(List<Point> verts, Color edgeColor, Color fillColor)
        {
            Point[] points = new Point[verts.Count];
            verts.CopyTo(points);
            _vertexes = new List<Point>(points);

            _edgeColor = edgeColor;
            _fillColor = fillColor;
        }

        private void DrawPixel(PictureBox canvas, Point p, Color color)
        {
            Graphics gr = canvas.CreateGraphics();
            gr.FillRectangle(new SolidBrush(color), p.X, p.Y, 1, 1);
        }

        public void DrawEdges(PictureBox canvas)
        {
            Pen pen = new Pen(_edgeColor);
            Graphics gr = canvas.CreateGraphics();
            int i = 0;
            for (; i < _vertexes.Count; i++)
            {
                if (i == 0) continue;
                gr.DrawLine(pen, _vertexes[i - 1], _vertexes[i]);
            }
            gr.DrawLine(pen, _vertexes[i - 1], _vertexes[0]);
        }

        private static bool Intersection(int y, Point s, Point e, out Point res)
        {
            res = new Point(0, 0);
            // Найдем минимальный и максимальный Y
            int yMin = s.Y;
            int yMax = e.Y;
            if (e.Y < s.Y)
            {
                yMin = e.Y;
                yMax = s.Y;
            }

            // Проверим, есть ли пересечение
            if (y < yMin)
                return false;
            if (y > yMax)
                return false;

            int resY = y; // Y - коордната точки пересечения
            if (IsVertical(s, e))
            {
                res = new Point(s.X, resY);
                return true;
            }

            // Найдем вторую координату
            float k = (float) (e.Y - s.Y) / (e.X - s.X);
            float b = e.Y - k * e.X;

            float x = ((float) resY - b) / k;
            int resX = (int) Math.Round(x);

            res = new Point(resX, resY);
            return true;
        }

        private static bool IsHorizontal(Point s, Point e)
        {
            return s.Y == e.Y;
        }

        private static bool IsVertical(Point s, Point e)
        {
            return s.X == e.X;
        }

        private bool IsLocalMinMax(int pointIndex)
        {
            Point left, same, right;
            same = _vertexes[pointIndex];
            if (pointIndex == 0)
            {
                left = _vertexes[_vertexes.Count - 1];
                right = _vertexes[1];
            }
            else if (pointIndex == _vertexes.Count - 1)
            {
                left = _vertexes[_vertexes.Count - 2];
                right = _vertexes[0];
            }
            else
            {
                left = _vertexes[pointIndex - 1];
                right = _vertexes[pointIndex + 1];
            }

            if (left.Y > same.Y && right.Y > same.Y)
                return true;
            if (left.Y < same.Y && right.Y < same.Y)
                return true;
            return false;
        }

        private static int CompareByLine(Point a, Point b)
        {
            if (a.Y < b.Y)
                return -1;
            if (a.Y > b.Y)
                return 1;
            return 0;
        }

        private static int CompareByX(Point a, Point b)
        {
            if (a.X < b.X)
                return -1;
            if (a.X > b.X)
                return 1;
            return 0;
        }

        private List<Point> SortByX(List<Point> list)
        {
            List<Point> result = new List<Point>();
            int prevY = list[0].Y;
            List<Point> section = new List<Point>();
            foreach (var point in list)
            {
                if (point.Y == prevY)
                    section.Add(point);
                else
                {
                    prevY = point.Y;
                    section.Sort(CompareByX);
                    result.AddRange(section);
                    section.Clear();
                    section.Add(point);
                }
            }

            return result;
        }

        private List<List<Point>> SplitByLine(List<Point> list)
        {
            List<List<Point>> res = new List<List<Point>>();
            List<Point> tmp = new List<Point>();
            int y = list[0].Y;
            foreach (var l in list)
            {
                if (l.Y == y)
                    tmp.Add(l);
                else
                {
                    res.Add(tmp);
                    tmp = new List<Point>();
                    y = l.Y;
                    tmp.Add(l);
                }
            }
            return res;
        }

        

        private void InitFilling()
        {
            if (_vertexes.Count < 2)
                throw new NotEnoughVerts();

            // Определим максимум и минимум фигуры
            Point max = _vertexes[0];
            Point min = _vertexes[0];
            foreach (var vert in _vertexes)
            {
                if (vert.Y > max.Y)
                    max = vert;
            }
            foreach (var vert in _vertexes)
            {
                if (vert.Y < min.Y)
                    min = vert;
            }

            // Определим точки пересечения сканирующих строк со всеми негоризонтальными ребрами
            List<Point> intersections = new List<Point>();
            for (int y = min.Y + 1; y <= max.Y + 1; y++)
            {
                // Перебираем все ребра
                int i = 1;
                Point res;
                bool exists;
                for (; i < _vertexes.Count; i++)
                {
                    if (IsHorizontal(_vertexes[i - 1], _vertexes[i]))
                        continue;

                    exists = Intersection(y, _vertexes[i - 1], _vertexes[i], out res);
                    if (exists)
                    {
                        if(intersections.Count != 0)
                        if (res.Equals(intersections[intersections.Count - 1]))
                            continue;
                        int pointIndex = -1;
                        for (int j = 0; j < _vertexes.Count && pointIndex == -1; j++)
                            if (_vertexes[j].Equals(res))
                                pointIndex = j;
                        if (pointIndex >= 0)
                            if (IsLocalMinMax(pointIndex))
                                intersections.Add(res);
                        intersections.Add(res);
                    }
                }

                // Последнее ребро
                if (IsHorizontal(_vertexes[0], _vertexes[i - 1]))
                    continue;
                exists = Intersection(y, _vertexes[0], _vertexes[i - 1], out res);
                if (exists)
                {
                    if (intersections.Count != 0)
                        if (res.Equals(intersections[intersections.Count - 1]))
                            continue;
                    int pointIndex = -1;
                    for (int j = 0; j < _vertexes.Count && pointIndex == -1; j++)
                        if (_vertexes[j].Equals(res))
                            pointIndex = j;
                    if (pointIndex >= 0)
                        if (IsLocalMinMax(pointIndex))
                            intersections.Add(res);
                    intersections.Add(res);
                }
            }

            // Отсортируем список по строкам и по возрастанию координаты х в каждой строке;
            intersections.Sort(CompareByLine);
            intersections = SortByX(intersections);

            //VertexList listForm = new VertexList();
            //listForm.AddToList(intersections);
            //listForm.Show();

            // Закрашиваем

            List<List<Point>> lines = SplitByLine(intersections);

            _fillingEdges = new List<FillingEdge>();

            foreach (var line in lines)
            {
                for (int i = 1; i < line.Count; i += 2)
                {
                    Point a = line[i - 1];
                    //a.X += 1;
                    Point b = line[i];
                    //b.X -= 1;
                    //gr.DrawLine(pen, a, b);
                    _fillingEdges.Add(new FillingEdge(a.X, b.X, a.Y));
                }
            }
        }

        public void FillDelayed(PictureBox canvas)
        {
            Graphics gr = canvas.CreateGraphics();
            Pen pen = new Pen(_fillColor);
            InitFilling();
            int y = _fillingEdges[0].Y;
            foreach (var line in _fillingEdges)
            {
                //gr.DrawLine(pen, line.S, line.Y, line.E, line.Y);
                if (Math.Abs(line.S - line.E) > 2)
                    gr.DrawLine(pen, line.S + 1, line.Y, line.E - 1, line.Y);
                else if (Math.Abs(line.S - line.E) == 2)
                {
                    DrawPixel(canvas, new Point(line.S + 1, line.Y), _fillColor);
                }
                if (line.Y != y)
                {
                    Thread.Sleep(500);
                    y = line.Y;
                }
            }
        }

        public void Fill(PictureBox canvas)
        {
            Graphics gr = canvas.CreateGraphics();
            Pen pen = new Pen(_fillColor);
            InitFilling();
            foreach (var line in _fillingEdges)
            {
                if (Math.Abs(line.S - line.E) > 2)
                    gr.DrawLine(pen, line.S + 1, line.Y, line.E - 1, line.Y);
                else if (Math.Abs(line.S - line.E) == 2)
                {
                    DrawPixel(canvas, new Point(line.S + 1, line.Y), _fillColor);
                }
            }
        }
    }
}
