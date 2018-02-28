using System;
using System.Windows.Forms;

namespace Lab_02
{
    public partial class MainForm : Form
    {
        private const int UndoSteps = 9;

        private readonly History _history;
        private Figure _figure;
        public MainForm()
        {
            InitializeComponent();

            _figure = new Figure(DrawCanvas);
            _history = new History(UndoSteps);
            UndoInfo.Text = @"Количество отмен: " + (UndoSteps - 1).ToString();
        }

        private void ProceedButt_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 scaleCent = new Vector2((float) Convert.ToDouble(ScaleXCBox.Text),
                    (float) Convert.ToDouble(ScaleYCBox.Text));
                float kx = (float) Convert.ToDouble(ScaleXBox.Text);
                float ky = (float) Convert.ToDouble(ScaleYBox.Text);


                _figure.Draw(new Vector2(0, 0), new Vector2(0, 0), 0, scaleCent, kx, ky);

                _history.NextStep();
                _history.StoreData("Figure", _figure);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(@"Возникла ошибка ввода данных. 
" + formatException.Message, @"I/O ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //ScaleXBox.Text = @"1";
            //ScaleYBox.Text = @"1";
            //ScaleXCBox.Text = @"0";
            //ScaleYCBox.Text = @"0";
        }

        private void Undo()
        {
            if (!_history.PrevStep())
                return;
            Figure tmp = (Figure)_history.LoadData("Figure");
            if (tmp != null)
            {
                _figure = tmp;
                _figure.Draw();
            }
        }

        private void Redo()
        {
            if (!_history.Revert())
            {
                return;
            }
            Figure tmp = (Figure)_history.LoadData("Figure");
            if (tmp != null)
            {
                _figure = tmp;
                _figure.Draw();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                Undo();
            }

            if (e.Control && e.KeyCode == Keys.Y)
            {
                Redo();
            }
        }

        private void UndoButt_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void RedoButt_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void ResetButt_Click(object sender, EventArgs e)
        {
            _figure = new Figure(DrawCanvas);
            _figure.Draw();
            _history.NextStep();
            _history.StoreData("Figure", _figure);
        }

        private void RotButt_Click(object sender, EventArgs e)
        {
            try
            {
                Vector2 rotCent = new Vector2((float)Convert.ToDouble(RotXBox.Text),
                    (float)Convert.ToDouble(RotYBox.Text));
                float angle = -(float)Convert.ToDouble(RotAngleBox.Text);
                
                _figure.Draw(new Vector2(0, 0), rotCent, angle, new Vector2(0,0), 1, 1);

                _history.NextStep();
                _history.StoreData("Figure", _figure);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(@"Возникла ошибка ввода данных. 
" + formatException.Message, @"I/O ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //RotAngleBox.Text = @"0";
            //RotXBox.Text = @"0";
            //RotYBox.Text = @"0";
        }

        private void TranslateButt_Click(object sender, EventArgs e)
        {
            try
            {
                float dx = (float)Convert.ToDouble(TranDxBox.Text);
                float dy = (float)Convert.ToDouble(TranDyBox.Text);

                _figure.Draw(new Vector2(dx, dy), new Vector2(0, 0), 0, new Vector2(0, 0), 1, 1);

                _history.NextStep();
                _history.StoreData("Figure", _figure);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(@"Возникла ошибка ввода данных. 
" + formatException.Message, @"I/O ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //TranDxBox.Text = @"0";
            //TranDyBox.Text = @"0";
        }
    }
}
