using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using WindowsFormsApp4.Entity;

namespace WindowsFormsApp4.Imp
{
    public class TableDAO : ConnDB
    {
        public static List<Table> Show()
        {
            List<Table> tables = new List<Table>();

//            2 dòng này buộc phải có
            var conn = Conn();
            conn.Open();

            String sql = "select * from main.[table]";

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
    }
}