using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using milktea.Entity;
using milktea.Imp;
using milktea.Model;

namespace milktea
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            //Chỉ cần chuyền tên flowLayoutPanel là tất cả auto
            TableModel.ShowIcon(flowLayoutPanel1, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Xóa những cái cũ
            flowLayoutPanel1.Controls.Clear();
            //Theo thứ tự tăng dần
            TableModel.ShowIcon(flowLayoutPanel1, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            //Theo thứ tự giảm dần
            TableModel.ShowIcon(flowLayoutPanel1, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            //Thẹo trạng thái bàn
            TableModel.ShowIcon(flowLayoutPanel1, 3);
        }
    }
}