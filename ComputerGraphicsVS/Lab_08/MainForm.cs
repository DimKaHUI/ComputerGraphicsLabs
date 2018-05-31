using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_08
{
    public partial class MainForm : Form
    {
        private readonly Color _lineColor = Color.Black;
        private readonly Color _polygonColor = Color.Red;
        private readonly Color _resultColor = Color.MediumBlue;
        private readonly int _resultWidth = 3;

        private bool _lineInputStarted = false;
        private bool _polygonFinalized = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public Point GetCursorRelativePosition()
        {
            Point absoluteCursor = System.Windows.Forms.Cursor.Position;
            return DrawingCanvas.PointToClient(absoluteCursor);
        }

        private void DrawLine(Point a, Point b, Color color, int width)
        {
            Graphics gr = DrawingCanvas.CreateGraphics();
            gr.DrawLine(new Pen(color, width), a, b);
        }

        private void ClearScreen()
        {
            DrawingCanvas.CreateGraphics().Clear(Color.White);
        }

        private void AddLinePoint(Point p, int number)
        {
            int len = LinePointsTable.RowCount;
            if (number == 0)
            {
                LinePointsTable.Rows.Add(p.X, p.Y);
                LinePointsTable.FirstDisplayedScrollingRowIndex = len - 1;
            }
            else
            {
                LinePointsTable.Rows[len - 2].Cells[2].Value = p.X;
                LinePointsTable.Rows[len - 2].Cells[3].Value = p.Y;
            }
        }

        private void AddPolygonPoint(Point p)
        {
            PolygonPointsTable.Rows.Add(p.X, p.Y);
            PolygonPointsTable.FirstDisplayedScrollingRowIndex = PolygonPointsTable.RowCount - 1;
        }

        private Point GetLinePoint(int row, int number)
        {
            return new Point((int)LinePointsTable.Rows[row].Cells[number].Value, (int)LinePointsTable.Rows[row].Cells[number + 1].Value);
        }

        private Point GetPolygonPoint(int row)
        {
            return new Point((int)PolygonPointsTable.Rows[row].Cells[0].Value, (int)PolygonPointsTable.Rows[row].Cells[1].Value);
        }

        private void ClearData()
        {
            PolygonPointsTable.Rows.Clear();
            LinePointsTable.Rows.Clear();
        }

        private void Redraw()
        {
            ClearScreen();
            // Redrawing lines
            foreach (DataGridViewRow row in LinePointsTable.Rows)
            {
                if(row.IsNewRow)
                    continue;
                Point a = new Point((int)row.Cells[0].Value, (int)row.Cells[1].Value);
                Point b = new Point((int)row.Cells[2].Value, (int)row.Cells[3].Value);
                DrawLine(a, b, _lineColor, 1);
            }

            // Redrawing polygon
            for (int i = 0; i < PolygonPointsTable.RowCount - 2; i++)
            {
                Point a = new Point((int)PolygonPointsTable.Rows[i].Cells[0].Value, (int)PolygonPointsTable.Rows[i].Cells[1].Value);
                Point b = new Point((int)PolygonPointsTable.Rows[i + 1].Cells[0].Value, (int)PolygonPointsTable.Rows[i + 1].Cells[1].Value);
                DrawLine(a, b, _polygonColor, 1);
            }
        }

        private void DrawingCanvas_Click(object sender, EventArgs e)
        {
            Point p = GetCursorRelativePosition();

            MouseEventArgs mouseEvent = (MouseEventArgs) e;
            bool shiftPressed = (ModifierKeys & Keys.Shift) != 0;
            bool controlPressed = (ModifierKeys & Keys.Control) != 0;
            bool altPressed = (ModifierKeys & Keys.Alt) != 0;

            if (mouseEvent.Button == MouseButtons.Left) // Inputting line segments
            {
                if (controlPressed && !_lineInputStarted)
                {
                    MessageBox.Show("Сначала укажите начало отрезка без зажатого Ctrl", "ERROR", MessageBoxButtons.OK);
                    return;
                }

                if (controlPressed && _lineInputStarted)
                {
                    Point prev = GetLinePoint(LinePointsTable.RowCount - 2, 0);
                    int dx = p.X - prev.X;
                    int dy = p.Y - prev.Y;
                    Point next = p;
                    if (Math.Abs(dx) < Math.Abs(dy))
                        next.X = prev.X;
                    else
                        next.Y = prev.Y;
                    AddLinePoint(next, 1);
                    _lineInputStarted = false;
                    DrawLine(next, prev, _lineColor, 1);
                    return;
                }

                if (altPressed && !_lineInputStarted)
                {
                    MessageBox.Show("Сначала укажите начало отрезка без зажатого Alt", "ERROR", MessageBoxButtons.OK);
                    return;
                }

                if (altPressed && _lineInputStarted)
                {
                    ParallelLines parallel = new ParallelLines();
                    //parar.SearchNearest(ref poligone,coordinates);
                    List<Point> temp_poligone = new List<Point>();
                    for (int i = 0; i < PolygonPointsTable.RowCount - 1; i++)
                    {
                        temp_poligone.Add(GetPolygonPoint(i));
                    }
                    Point nearest =
                        parallel.SearchNearest(temp_poligone, GetLinePoint(LinePointsTable.RowCount - 2, 0), p);
                    AddLinePoint(nearest, 1);
                    temp_poligone.Clear();
                    _lineInputStarted = false;

                    DrawLine(nearest, GetLinePoint(LinePointsTable.RowCount - 2, 0), _lineColor, 1);
                }
                else
                {
                    if (_lineInputStarted)
                    {
                        DrawLine(GetLinePoint(LinePointsTable.RowCount - 2, 0), p, _lineColor, 1);
                        _lineInputStarted = false;
                        AddLinePoint(p, 1);
                    }
                    else
                    {
                        _lineInputStarted = true;
                        AddLinePoint(p, 0);
                    }
                }

            }

            if (mouseEvent.Button == MouseButtons.Right) // Inputting polygon
            {
                Point addable;
                if (shiftPressed)
                {
                    addable = PolygonPointsTable.RowCount - 1 >= 3 ? GetPolygonPoint(0) : p;
                }
                else
                    addable = p;

                if (_polygonFinalized)
                {
                    PolygonPointsTable.Rows.Clear();
                    Redraw();
                    _polygonFinalized = false;
                }

                if (PolygonPointsTable.RowCount - 1 > 0)
                {
                    DrawLine(GetPolygonPoint(PolygonPointsTable.RowCount - 2), addable, _polygonColor, 1);
                }

                AddPolygonPoint(addable);

                if (shiftPressed && PolygonPointsTable.RowCount - 1 > 3)
                    _polygonFinalized = true;
            }
        }

        private List<Point> GetCutter()
        {
            List<Point> cutter = new List<Point>(PolygonPointsTable.RowCount);
            for (int i = 0; i < PolygonPointsTable.RowCount - 1; i++)
            {
                //cutter.Add(new Point((int)PolygonPointsTable.Rows[i].Cells[0].Value, (int)PolygonPointsTable.Rows[i].Cells[1].Value));
                cutter.Add(GetPolygonPoint(i));
            }
            return cutter;
        }

        private List<LineSegment> GetLines()
        {
            List<LineSegment> result = new List<LineSegment>(LinePointsTable.RowCount - 1);
            for (int i = 0; i < LinePointsTable.RowCount - 1; i++)
            {
                //cutter.Add(new Point((int)PolygonPointsTable.Rows[i].Cells[0].Value, (int)PolygonPointsTable.Rows[i].Cells[1].Value));
                result.Add(new LineSegment(GetLinePoint(i, 0), GetLinePoint(i, 2)));
            }
            return result;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearScreen();
            ClearData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            colorPanelCutter.BackColor = _polygonColor;
            colorPanelSource.BackColor = _lineColor;
            colorPanelResult.BackColor = _resultColor;
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            if (_lineInputStarted)
            {
                MessageBox.Show("Ввод линии не завершён", "ERROR", MessageBoxButtons.OK);
                return;
            }

            List<Point> cutter = GetCutter();
            List<LineSegment> lines = GetLines();

            try
            {
                List<LineSegment> result = Cutter.Cut(cutter, lines);

                foreach (var line in result)
                {
                    DrawLine(line.Start, line.End, _resultColor, _resultWidth);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
