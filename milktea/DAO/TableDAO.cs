using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using milktea.Entity;

namespace milktea.Imp
{
    public class TableDAO : ConnDB
    {
        public static List<Table> SelectAll(int n)
        {
            List<Table> tables = new List<Table>();

//            2 dòng này buộc phải có
            var conn = Conn();
            conn.Open();

            String sql = "select * from main.[table] ORDER BY main.[table].idTable ASC";

            switch (n)
            {
                //tăng đần
                case 1:
                    sql = "select * from main.[table] ORDER BY main.[table].idTable ASC";
                    break;
                //giảm dần
                case 2:
                    sql = "select * from main.[table] ORDER BY main.[table].idTable DESC";
                    break;
                //theo loại
                case 3:
                    sql = "select * from main.[table]";
                    break;
            }


            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = sql;

            DbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Table table = new Table();
                //Cột thứ 1 có index là 0
                table.Id = reader.GetInt32(0).ToString();
                table.Status = reader.GetInt32(1);

                tables.Add(table);
            }

            return tables;
        }

        public static DataSet SelectTable()
        {
            var conn = Conn();
            String sql =
                "SELECT  main.[table].idTable, main.[table].idStatusTable, main.statusTable.nameStatusTable FROM main.statusTable INNER JOIN main.[table] ON main.[table].idStatusTable = main.statusTable.idStatusTable order by main.[table].idTable ASC ";

            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            return ds;
        }

        public static Boolean Add(int i)
        {
            String sql = "SELECT * FROM main.[table]";
            var conn = Conn();
            
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataRow row = ds.Tables[0].NewRow();
                row[1] = i;
                ds.Tables[0].Rows.Add(row);

                if (adapter.Update(ds.Tables[0]) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static Boolean Delete(int num)
        {
            String sql = "SELECT * FROM main.[table] order by main.[table].idTable ASC";
            var conn = Conn();
            
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DataRow row = ds.Tables[0].Rows[num];
                row.Delete();

                if (adapter.Update(ds.Tables[0]) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

//        public static Boolean Update(Table table)
//        {
//            Boolean b = false;
//
//            var conn = Conn();
//            conn.Open();
//
//            String sql =
//                String.Format(
//                    "update main.[table] set main.[table].idStatusTable = {0} where main.[table].idTable = {1}",
//                    table.Status, table.Id);
//
//            try
//            {
//                SqlCommand command = new SqlCommand();
//                command.Connection = conn;
//                command.CommandText = sql;
//
//                int n = command.ExecuteNonQuery();
//                if (n > 0)
//                {
//                    b = true;
//                }
//                else
//                {
//                    b = false;
//                }
//            }
//            catch (Exception e)
//            {
//                b = false;
//            }
//
//            return b;
//        }
    }
}