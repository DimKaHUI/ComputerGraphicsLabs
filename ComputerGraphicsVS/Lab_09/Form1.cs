using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_09
{
    public partial class Form1 : Form
    {
        private List<Point> _polygon = new List<Point>();
        private List<Point> _cutter = new List<Point>();
        private readonly Color _cutterColor = Color.Black;
        private readonly Color _polygonColor = Color.Red;
        private readonly Color _resultColor = Color.GreenYellow;

        private bool _cutterFinalized = false;
        private bool _polygonFinalized = false;

        public Form1()
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

        private void Redraw()
        {
            ClearScreen();
            for (int i = 0; i < _polygon.Count - 1; i++)
            {
                DrawLine(_polygon[i], _polygon[i + 1], _polygonColor, 1);
            }

            for (int i = 0; i < _cutter.Count - 1; i++)
            {
                DrawLine(_cutter[i], _cutter[i + 1], _cutterColor, 1);
            }
        }

        private void TestVisibility()
        {
            Point p = GetCursorRelativePosition();
            int dir = Cutter.GetDirection(_cutter);
            string msg = "";
            for (int i = 0; i < _cutter.Count - 1; i++)
            {
                bool visible = Cutter.IsVisible(_cutter[i], _cutter[i + 1], p, -dir);
                msg += i + ": " + visible + "\n";
            }

            HiddenLabel.Text = msg;
        }

        private void TestIntersection()
        {
            Graphics gr = DrawingCanvas.CreateGraphics();
            for (int i = 0; i < _cutter.Count - 1; i++)
            {
                for (int j = 0; j < _polygon.Count - 1; j++)
                {
                    Point sec;
                    bool flag = Cutter.HasIntersection(_cutter[i], _cutter[i + 1], _polygon[j], _polygon[j + 1],
                        out sec);
                    if (flag)
                    {
                        gr.FillEllipse(new SolidBrush(Color.Blue), sec.X - 5, sec.Y - 5, 10, 10);
                    }
                }
            }
        }

        private void DrawingCanvas_Click(object sender, EventArgs e)
        {
            bool shiftPressed = (ModifierKeys & Keys.Shift) != 0;
            MouseEventArgs mouseArgs = (MouseEventArgs) e;

            if (mouseArgs.Button == MouseButtons.Middle)
            {
                if(!shiftPressed)
                TestVisibility();
                else
                {
                    TestIntersection();
                }
            }

            if (mouseArgs.Button == MouseButtons.Left)
            {
                if(!_cutterFinalized)
                    if (shiftPressed)
                    {
                        if (_cutter.Count >= 3)
                        {
                            _cutterFinalized = true;
                            DrawLine(_cutter.Last(), _cutter[0], _cutterColor, 1);
                            _cutter.Add(_cutter[0]);
                        }
                    }
                    else
                    {
                        Point p = GetCursorRelativePosition();
                        if (_cutter.Count > 0)
                            DrawLine(_cutter.Last(), p, _cutterColor, 1);
                        _cutter.Add(p);
                    }
                else
                {
                    if (!shiftPressed)
                    {
                        _cutterFinalized = false;
                        _cutter.Clear();
                        Redraw();
                        Point p = GetCursorRelativePosition();
                        _cutter.Add(p);
                    }
                }
            }

            if (mouseArgs.Button == MouseButtons.Right)
                if (!_polygonFinalized)
                    if (shiftPressed)
                    {
                        if (_polygon.Count >= 3)
                        {
                            _polygonFinalized = true;
                            DrawLine(_polygon.Last(), _polygon[0], _polygonColor, 1);

                            /*DrawingCanvas.CreateGraphics().FillEllipse(new SolidBrush(Color.Red), _polygon[0].X - 3,
                                _polygon[0].Y - 3, 6, 6);*/

                            _polygon.Add(_polygon[0]);
                        }
                    }
                    else
                    {
                        Point p = GetCursorRelativePosition();
                        if (_polygon.Count > 0)
                            DrawLine(_polygon.Last(), p, _polygonColor, 1);
                        _polygon.Add(p);
                    }
                else
                {
                    if (!shiftPressed)
                    {
                        _polygonFinalized = false;
                        _polygon.Clear();
                        Redraw();
                        Point p = GetCursorRelativePosition();
                        _polygon.Add(p);
                    }
                }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Point> result = Cutter.Cut(_polygon, _cutter);

                for (int i = 0; i < result.Count - 1; i++)
                {
                    DrawLine(result[i], result[i + 1], _resultColor, 3);
                    //DrawingCanvas.CreateGraphics().FillEllipse(new SolidBrush(Color.Aqua), result[i].X - 2, result[i].Y - 2, 4, 4);
                    //DrawingCanvas.CreateGraphics().DrawString(i.ToString(), DefaultFont, new SolidBrush(Color.Fuchsia), result[i].X - 2, result[i].Y - 2);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            _polygon.Clear();
            _cutter.Clear();
            ClearScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorPanelCutter.BackColor = _cutterColor;
            colorPanelPolygon.BackColor = _polygonColor;
            colorPanelResult.BackColor = _resultColor;
        }

        private Point GetPointFromForm()
        {
            int x = Int32.Parse(xBox.Text);
            int y = Int32.Parse(yBox.Text);
            return new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Point p = GetPointFromForm();
                if (!_cutterFinalized)
                {
                    _cutter.Add(p);
                    if (_cutter.Count > 1)
                        DrawLine(p, _cutter[0], _cutterColor, 1);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Point p = GetPointFromForm();
                if (!_polygonFinalized)
                {
                    _polygon.Add(p);
                    if(_polygon.Count > 1)
                        DrawLine(p, _polygon[0], _polygonColor, 1);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
