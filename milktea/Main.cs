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

namespace milktea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Table> tables = TableDAO.Show();
            foreach (var table in tables)
            {
                Button btn = new Button();
                String nameBtn = String.Format("Bàn {0}", table.Id);
                btn.Name = table.Id;
                btn.Text = nameBtn;
                btn.Font = new Font("Segoe UI", 14F);
                switch (table.Status)
                {
                    case 1:
                        btn.BackColor = Color.Chartreuse;
                        break;
                    case 2:
                        btn.BackColor = Color.Firebrick;
                        break;
                    case 3:
                        btn.BackColor = Color.Goldenrod;
                        break;
                    case 4:
                        btn.BackColor = Color.Gray;
                        break;
                    
                }
                btn.Size = new Size(100, 50);
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}