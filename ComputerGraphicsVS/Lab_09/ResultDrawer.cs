using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class ResultDrawer : Form
    {
        public ResultDrawer()
        {
            InitializeComponent();
        }

        struct WaiterData
        {
            public List<Point> Polygon;
            public Color Color;

            public WaiterData(List<Point> p, Color c)
            {
                Color = c;
                Polygon = p;
            }
        }

        delegate void PopWindow();

        void PopUp()
        {
            TopMost = true;
        }

        private void Waiter(object data)
        {
            WaiterData args = (WaiterData) data;
            
            Thread.Sleep(1000);
            BeginInvoke(new PopWindow(PopUp));
            Drawing(args.Polygon, args.Color);
        }

        private void Drawing(List<Point> polygon, Color color)
        {
            if (polygon.Count == 0)
                return;

            Pen pen = new Pen(color);

            Graphics gr = DrawingCanvas.CreateGraphics();
            
            for (int i = 0; i < polygon.Count - 1; i++)
            {
                int x1 = polygon[i].X;
                int y1 = polygon[i].Y;
                int x2 = polygon[i + 1].X;
                int y2 = polygon[i + 1].Y;
                gr.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public void DrawPolygon(List<Point> polygon, Color color)
        {
            Thread waiter = new Thread(Waiter);
            waiter.Start(new WaiterData(new List<Point>(polygon), color));
        }
    }
}
