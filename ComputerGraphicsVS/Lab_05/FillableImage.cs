using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05
{
    class FillableImage
    {
        private readonly List<Point> _verts;
        private readonly PictureBox _canvas;
        private readonly Color _edgeColor;
        private readonly Color _fillColor;

        public FillableImage(List<Point> verts, PictureBox drawingCanvas, Color edgeColor, Color fillColor)
        {
            _verts = new List<Point>(verts);
            _canvas = drawingCanvas;
            this._edgeColor = edgeColor;
            _fillColor = fillColor;
        }

        int GetIntersection(Point a, Point b, int scanner)
        {
            float x, y, x1, y1, x2, y2, dx, dy, step;
            int i;

            x1 = a.X;
            x2 = b.X;
            y1 = a.Y;
            y2 = b.Y;
            dx = Math.Abs(x2 - x1);
            dy = Math.Abs(y2 - y1);
            if (dx >= dy)
                step = dx;
            else
                step = dy;
            dx = dx / step;
            dy = dy / step;
            x = x1;
            y = y1;
            i = 1;
            while (i <= step)
            {
                if (Math.Abs(y - scanner) < 1e-3)
                {
                    return (int)x;
                }
                x = x + dx;
                y = y + dy;
                i = i + 1;
            }
            return -1;
        }


        List<Point> GetIntersections()
        {
            List<Point> res = new List<Point>();
            for (int scanY = 0; scanY < _canvas.Height; scanY++)
            {
                List<int> xInts = new List<int>();

                // Ищем грани, с которыми есть пересечение
                for (int i = 0; i < _verts.Count - 1; i += 2)
                {
                    // Исключаем горизонтальные ребра


                    int x = GetIntersection(_verts[i], _verts[i + 1], scanY);
                    if(x == -1)
                        continue;
                    
                    xInts.Add(x);

                    int k = i - 2;
                    if (i == 0)
                    {
                        k = i;
                        while (_verts[k + 1] != _verts[0])
                            k += 2;
                    }
                    if (scanY == _verts[i].Y && _verts[i + 1].Y > scanY && _verts[k].Y > scanY)
                    {
                        xInts.Add(x);
                    }
                    else if (scanY == _verts[i].Y && _verts[i + 1].Y < scanY && _verts[k].Y < scanY)
                    {
                        xInts.Add(x);
                    }

                }
                xInts.Sort();
                for (int i = 0; i < xInts.Count; i++)
                {
                    res.Add(new Point(xInts[i], scanY));
                }
            }

            return res;
        }


        public void Fill(int delay)
        {
            Pen pen = new Pen(_fillColor);
            Graphics gr = _canvas.CreateGraphics();

            List<Point> points = GetIntersections();
            
            // TODO
        }
    }
}
