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
using WindowsFormsApp4.Entity;
using WindowsFormsApp4.Imp;
using milktea.Model;

namespace milktea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Chỉ cần chuyền tên flowLayoutPanel là tất cả auto
            TableModel.ShowIcon(flowLayoutPanel1);
        }
    }
}