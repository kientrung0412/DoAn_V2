using System;
using System.Data;
using System.Windows.Forms;
using milktea.Entity;
using milktea.Imp;
using milktea.Model;

namespace milktea
{
    public partial class demoTable : Form
    {
        private int num = -1;

        public demoTable()
        {
            InitializeComponent();
            TableModel.ShowTable(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            num = e.RowIndex;
            
//            if (dataGridView1.SelectedRows.Count > 0)
//            {
//                var row = dataGridView1.SelectedRows[0];
//                var x = row.Cells[0].Value;
//                MessageBox.Show(x.ToString());
//                dataGridView1.SelectedRows[0];
//            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TableModel.Delete(num);
            TableModel.ShowTable(dataGridView1);
        }
    }
}