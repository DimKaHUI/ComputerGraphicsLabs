using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class MainForm : Form
    {
        private History _history = new History(8);
        private Figure _figure;
        public MainForm()
        {
            InitializeComponent();

            _figure = new Figure(DrawCanvas);
        }

        private void ProceedButt_Click(object sender, EventArgs e)
        {
            float dx = (float)Convert.ToDouble(TranDxBox.Text);
            float dy = (float)Convert.ToDouble(TranDyBox.Text);
            Vector2 rotCent = new Vector2((float)Convert.ToDouble(RotXBox.Text), (float)Convert.ToDouble(RotYBox.Text));
            float angle = (float) Convert.ToDouble(RotAngleBox.Text);
            Vector2 scaleCent = new Vector2((float)Convert.ToDouble(ScaleXBox.Text), (float)Convert.ToDouble(ScaleYBox.Text));
            float kx = (float) Convert.ToDouble(ScaleXBox.Text);
            float ky = (float) Convert.ToDouble(ScaleYBox.Text);

            _figure.Draw(new Vector2(dx, dy), rotCent, angle, scaleCent, kx, ky);

            _history.NextStep();
            _history.StoreData("Figure", _figure);

            TranDxBox.Text = "0";
            TranDyBox.Text = "0";
            ScaleXBox.Text = "1";
            ScaleYBox.Text = "1";
            RotAngleBox.Text = "0";
            RotXBox.Text = "0";
            RotYBox.Text = "0";

            // Setting up information
            //PosLabel.Text = String.Format("({0:0.0}, {1:0.0})", _figure.X, _figure.Y);
        }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                if (!_history.PrevStep())
                    return;
                Figure tmp = (Figure) _history.LoadData("Figure");
                if (tmp != null)
                {
                    _figure = tmp;
                    _figure.Draw();
                }
            }

            if (e.Control && e.KeyCode == Keys.Y)
            {
                if (!_history.Revert())
                    return;
                Figure tmp = (Figure)_history.LoadData("Figure");
                if (tmp != null)
                {
                    _figure = tmp;
                    _figure.Draw();
                }
            }
        }
    }
}
