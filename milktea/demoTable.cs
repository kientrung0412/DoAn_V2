using System.Data;
using System.Windows.Forms;
using milktea.Model;

namespace milktea
{
    public partial class demoTable : Form
    {
        public demoTable()
        {
            InitializeComponent();
            TableModel.ShowTable(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                var x = row.Cells[0].Value;
                MessageBox.Show(x.ToString());
                //dataGridView1.SelectedRows[0];
            }

            //throw new System.NotImplementedException();
        }
    }
}