using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_01
{

    /* Лабораторная 1
     * Задано множество точек
     * Найти такой треугольник, у которого
     * разность площадей с описанной окружностью
     * минимальна
    */
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        public double S2R(object val, ref bool success)
        {
            try
            {
                return Convert.ToDouble(val);
            }
            catch
            {
                success = false;
            }
            return 0;
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            Graphics gr = DrawCanvas.CreateGraphics();
            gr.Clear(Color.White);

            gr.TranslateTransform(DrawCanvas.Size.Width / 2.0f, DrawCanvas.Size.Height / 2.0f);

            if (PointGrid.RowCount < 4)
            {
                MessageBox.Show("Not enough points to build a triangle");
                return;
            }

            // Перебор всех треугольников
            double minDiff = -1;
            bool setup = false;
            Triangle min = new Triangle();
            for (int i = 0; i < PointGrid.RowCount - 1 && PointGrid[0, i] != null; i++)
            for (int j = i; j < PointGrid.RowCount - 1 && PointGrid[0, j] != null; j++)
            for (int k = j; k < PointGrid.RowCount - 1 && PointGrid[0, k] != null; k++)
            {
                bool success = true;
                double val1 = S2R(PointGrid[0, i].Value, ref success);
                double val2 = S2R(PointGrid[1, i].Value, ref success);
                double val3 = S2R(PointGrid[0, j].Value, ref success);
                double val4 = S2R(PointGrid[1, j].Value, ref success);
                double val5 = S2R(PointGrid[0, k].Value, ref success);
                double val6 = S2R(PointGrid[1, k].Value, ref success);

                if (!success)
                    continue;

                Vertex a = new Vertex(val1, val2, i);
                Vertex b = new Vertex(val3, val4, j);
                Vertex c = new Vertex(val5, val6, k);

                Triangle triangle = new Triangle(a, b, c);
                if (triangle.IsDegenerate)
                {
                    continue;
                }

                double diff = triangle.CircumcircleArea - triangle.Area;
                if (diff < minDiff || !setup)
                {
                    setup = true;
                    minDiff = diff;
                    min = triangle;
                }
            }

            if(setup)
            ResultLabel.Text = min +
                               "\nTriange with minimum difference between circumircle and its own area.";
            else
            {
                ResultLabel.Text = "No correct triangles found";
            }

            min.DrawFitting(DrawCanvas);
        }

        private void PointGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void GeneratePointsButton_Click(object sender, EventArgs e)
        {
            int amount = 0;
            try
            {
                amount = Convert.ToInt32(GenInputBox.Text);
                if(amount < 0)
                    throw new Exception("Amount of points must be positive");
            }
            catch(Exception exception)
            {
                MessageBox.Show("Incorrect amount of points. " + exception.Message);
            }

            PointGrid.Rows.Clear();
            for (int i = 0; i < amount; i++)
            {
                float x = -100.0f + rnd.Next() % 100.0f;
                float y = -100.0f + rnd.Next() % 100.0f;
                PointGrid.Rows.Add(x / 10, y / 10);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //PointGrid[2, 0].Value = 1;
        }

        private void PointGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < PointGrid.RowCount - 1; i++)
            {
                PointGrid[2, i].Value = i;
            }
        }
        private void PointGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < PointGrid.RowCount - 1; i++)
            {
                PointGrid[2, i].Value = i;
            }
        }

        private void DelRowButt_Click(object sender, EventArgs e)
        {
            if (PointGrid.CurrentRow != null && !PointGrid.CurrentRow.IsNewRow)
                PointGrid.Rows.Remove(PointGrid.CurrentRow);
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            PointGrid.Rows.Clear();
        }


    }
}
