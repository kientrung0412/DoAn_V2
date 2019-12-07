using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using milktea.Entity;
using milktea.Imp;

namespace milktea.Model
{
    public class TableModel
    {
        private static void showStatus(object sender, EventArgs e)
        {
            //Án vào bàn  còn chống
            Button btn = sender as Button;
            var name = btn.Name;
            frmMain main = new frmMain();
//            main.pn
        }

//        private static void newOrder()
//        {
//            MessageBox.Show("ok");
//        }

        public static void ShowIcon(FlowLayoutPanel flowLayoutPanel, Panel panel, int x)
        {
            List<Table> tables = TableDAO.SelectAll(x);
//            lặp qua lần lượt các bàn
            foreach (var table in tables)
            {
                Button btn = new Button();
                String nameBtn = String.Format("Bàn {0}", table.Id);
                btn.Name = table.Id;
                btn.Text = nameBtn;
                btn.Font = new Font("Segoe UI", 14F);
                btn.Size = new Size(100, 50);
//                hiển thị trang thái bàn
                switch (table.Status)
                {
                    case 1:
                        btn.BackColor = Color.Chartreuse;
                        btn.Click += showStatus;
                        break;
                    case 2:
                        btn.BackColor = Color.Firebrick;
                        btn.Click += showStatus;
                        break;
                    case 3:
                        btn.BackColor = Color.Goldenrod;
                        btn.Click += showStatus;
                        break;
                    case 4:
                        btn.BackColor = Color.Gray;
                        btn.Click += showStatus;
                        break;
                }

                //xác định vị trí nút được gắn vào panel nào
                flowLayoutPanel.Controls.Add(btn);
            }
        }

        public static void ShowTable(DataGridView gridView)
        {
            //Lấy data dưới dạng bảng
            DataSet dataSet = TableDAO.SelectTable();
            if (dataSet.Tables.Count > 0)
            {
                dataSet.Tables[0].Columns[0].ColumnName = "Số bàn";
//                dataSet.Tables[0].Columns[1].ColumnMapping = MappingType.Hidden;
                dataSet.Tables[0].Columns[2].ColumnName = "Trạng thái";
                gridView.DataSource = dataSet.Tables[0];
            }
        }

        public static void Add(int i)
        {
            if (TableDAO.Add(i))
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//        public static void Update(Table table)
//        {
//            if (TableDAO.Update(table))
//            {
//                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
//            }
//            else
//            {
//                MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
        public static void Delete(int num)
        {
            if (TableDAO.Delete(num))
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}