using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05
{
    public partial class MainForm : Form
    {
        //private List<FillableImage> _images = new List<FillableImage>();
        private FillableImage _image;
        private List<Point> _buffer = new List<Point>();

        public MainForm()
        {
            InitializeComponent();
        }

        public Point GetCursorRelativePosition()
        {
            Point absoluteCursor = System.Windows.Forms.Cursor.Position;
            return DrawingCanvas.PointToClient(absoluteCursor);
        }

        private void AddPointToBuffer(Point p)
        {
            if(_buffer.Count > 0)
                DrawingCanvas.CreateGraphics().DrawLine(new Pen(GetEdgeColor()), p, _buffer[_buffer.Count - 1] );
            _buffer.Add(p);
        }

        private Color GetEdgeColor()
        {
            if (BlackRadio.Checked)
                return Color.Black;
            if (GreenRadio.Checked)
                return Color.Green;
            if (RedRadio.Checked)
                return Color.Red;
            return Color.Black;
        }

        private Color GetFillColor()
        {
            if (BackBlackRadio.Checked)
                return Color.Black;
            if (BackGreenRadio.Checked)
                return Color.Green;
            if (BackRedRadio.Checked)
                return Color.Red;
            return Color.Black;
        }

        private void FinalizeImage()
        {
            if (_buffer.Count < 3)
            {
                MessageBox.Show("Указано меньше 3-х точек");
                return;
            }
            FillableImage img = new FillableImage(_buffer, GetEdgeColor(), GetFillColor());
            //_images.Add(img);
            _image = img;
            _buffer.Clear();
            _image.DrawEdges(DrawingCanvas);
        }

        // Adding vertex via mouse
        private void DrawingCanvas_Click(object sender, EventArgs e)
        {
            Point p = GetCursorRelativePosition();
            //Graphics gr = DrawingCanvas.CreateGraphics();
            //Point prev = _buffer[_buffer.Count - 1];
            //gr.DrawLine(new Pen(GetEdgeColor()), prev.X, prev.Y, p.X, p.Y);
            AddPointToBuffer(p);
        }

        private void AddVertexButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Int32.Parse(XBox.Text);
                int y = Int32.Parse(YBox.Text);
                AddPointToBuffer(new Point(x, y));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка чтения данных: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void FinilizeButton_Click(object sender, EventArgs e)
        {
            FinalizeImage();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DrawingCanvas.CreateGraphics().Clear(Color.White);
            _buffer.Clear();
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if(_image == null)
                return;
            try
            {
                _image.Fill(DrawingCanvas);
            }
            catch (NotEnoughVerts ex)
            {
                MessageBox.Show("Фигура не создана");
            }
        }

        private void FillDelayedButton_Click(object sender, EventArgs e)
        {
            if (_image == null)
                return;
            try
            {
                _image.FillDelayed(DrawingCanvas);
            }
            catch (NotEnoughVerts ex)
            {
                MessageBox.Show("Фигура не создана");
            }
        }

        
    }
}
