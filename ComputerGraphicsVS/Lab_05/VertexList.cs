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
    public partial class VertexList : Form
    {
        public VertexList()
        {
            InitializeComponent();
        }

        public void AddToList(List<Point> list)
        {
            foreach (var el in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells.Add(new DataGridViewTextBoxCell());
                row.Cells[0].Value = el.X.ToString();
                row.Cells[1].Value = el.Y.ToString();
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
