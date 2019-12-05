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
        public static void ShowIcon(FlowLayoutPanel flowLayoutPanel, int x)
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

                //xác định vị trí nút được gắn vào panel nào
                flowLayoutPanel.Controls.Add(btn);
            }
        }

        public static void ShowTable(DataGridView gridView)
        {
            DataSet dataSet = TableDAO.SelectTable();
            if (dataSet.Tables.Count > 0)
            {
                dataSet.Tables[0].Columns[0].ColumnName = "Số bàn";
                dataSet.Tables[0].Columns[1].ColumnName = "Trạng thái";
                gridView.DataSource = dataSet.Tables[0];
            }
        }
    }
}