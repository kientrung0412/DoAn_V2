using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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
            SqlDataAdapter adapter = new SqlDataAdapter();

            var conn = Conn();
            conn.Open();
            
            //lấy 2 bảng statusTable và table
            String sql = "SELECT  main.[table].idTable, main.statusTable.nameStatusTable FROM main.statusTable INNER JOIN main.[table] ON main.[table].idStatusTable = main.statusTable.idStatusTable ";

            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = sql;

            adapter.SelectCommand = command;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            return dataSet;
        }
    }
}