using System;
using System.Windows.Forms;
using milktea.Model;

namespace milktea
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //Xóa những cái cũ
            flpTable.Controls.Clear();
            TableModel.ShowIcon(flpTable, pnTableStatus, 1);
        }


        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            //Xóa những cái cũ
            flpTable.Controls.Clear();
            //Theo thứ tự tăng dần
            TableModel.ShowIcon(flpTable, pnTableStatus, 1);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Xóa những cái cũ
            flpTable.Controls.Clear();
            //Theo thứ tự tăng dần
            TableModel.ShowIcon(flpTable, pnTableStatus, 2);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Xóa những cái cũ
            flpTable.Controls.Clear();
            //Theo thứ tự tăng dần
            TableModel.ShowIcon(flpTable, pnTableStatus, 3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Đồng hồ
            lbTime.Text = DateTime.Now.ToString("d/MM/yyyy H:mm:ss");
        }
        
    }
}