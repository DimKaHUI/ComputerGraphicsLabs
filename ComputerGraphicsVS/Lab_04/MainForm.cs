using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    struct UserData
    {
        public Vertex2D CircleCenter;
        public Vertex2D EllipseCenter;
        public double A, B;
        public double Radius;
    }


    public partial class MainForm : Form
    {

        List<IDrawable> _images = new List<IDrawable>();
        private Algorithm _alg;
        private Color _background;
        private Color _imgColor;
        private bool isEllipse = false;
        private UserData _data;
        
        public MainForm()
        {
            InitializeComponent();
            ReadAlgorithm();
            ReadColor();
        }

        void ShowError(string msg)
        {
            MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void ReadAlgorithm()
        {
            int index = AlgorithmBox.SelectedIndex;
            _alg = (Algorithm)index;
        }

        void ReadFigure()
        {
            if (CircleRadio.Checked)
                isEllipse = false;
            else if (EllipseRadio.Checked)
                isEllipse = true;
        }

        void ReadData()
        {
            _data = new UserData();
            _data.CircleCenter = new Vertex2D();
            _data.EllipseCenter = new Vertex2D();
            bool succes = true;
            succes &= Int32.TryParse(CircleXBox.Text, out _data.CircleCenter.X);
            succes &= Int32.TryParse(CircleYBox.Text, out _data.CircleCenter.Y);
            succes &= Int32.TryParse(EllipseXBox.Text, out _data.EllipseCenter.X);
            succes &= Int32.TryParse(EllipseYBox.Text, out _data.EllipseCenter.Y);
            succes &= Double.TryParse(CircleRadiusBox.Text, out _data.Radius);
            succes &= Double.TryParse(EllipseABox.Text, out _data.A);
            succes &= Double.TryParse(EllipseBBox.Text, out _data.B);

            if(!succes)
                throw new FormatException();
        }

        void ReadColor()
        {
            if (BlackRadio.Checked)
                _imgColor = Color.Black;
            else if (WhiteRadio.Checked)
                _imgColor = Color.White;
            else if (RedRadio.Checked)
                _imgColor = Color.Red;

            if(BackBlackRadio.Checked)
                _background = Color.Black;
            else if (BackWhiteRadio.Checked)
                _background = Color.White;
            else if (BackRedRadio.Checked)
                _background = Color.Red;
        }

        void ClearScreen()
        {
            Graphics gr = DrawingCanvas.CreateGraphics();
            gr.Clear(_background);
        }

        void ClearImages()
        {
            ReadColor();
            _images.Clear();
        }

        private void DrawImages()
        {
            ClearScreen();
            foreach (var img in _images)
            {
                img.Draw(DrawingCanvas);
            }
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //Image.DrawPixel(DrawingCanvas, new Vertex2D(200, 200), Color.Black);
            //return;
            ReadColor();
            ReadFigure();

            ReadAlgorithm();
            if ((int) _alg == -1)
            {
                ShowError("Алгоритм не выбран");
                return;
            }

            try
            {
                ReadData();
            }
            catch (FormatException ex)
            {
                ShowError("I/O error: " + ex.Message);
                return;
            }

            IDrawable drawable;
            if (isEllipse)
            {
                drawable = DrawableBuilder.BuildEllipse(_data.EllipseCenter, (float)_data.A, (float)_data.B, _imgColor, _alg);
            }
            else
            {
                drawable = DrawableBuilder.BuildCircle(_data.CircleCenter, (int)_data.Radius, _imgColor, _alg);
            }

            _images.Add(drawable);
            DrawImages();
        }

        private void CircleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == (Object) CircleRadio)
            {
                if (CircleRadio.Checked)
                {
                    CircleParamsPanel.Visible = true;
                    EllipseParamsPanel.Visible = false;
                }
            }

            if (sender == (Object)EllipseRadio)
            {
                if (EllipseRadio.Checked)
                {
                    CircleParamsPanel.Visible = false;
                    EllipseParamsPanel.Visible = true;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearImages();
            ClearScreen();
        }
    }
}
