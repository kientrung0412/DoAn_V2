﻿using System;
using System.Data.Common;
using System.Data.SqlClient;
using WindowsFormsApp4.Entity;

namespace WindowsFormsApp4.Imp
{
    public class EmployessDAO : ConnDB
    {
        public static Boolean Login(Employess employess)
        {
            var conn = Conn();
            conn.Open();
            
            String sql = String.Format("select * from main.employess WHERE main.employess.phone = {0}  AND  main.employess.password = {1}", employess.Phone, employess.Passsword);
            
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = conn;
            
            DbDataReader reader = command.ExecuteReader();
            
            //nếu true đăng nhập thành công
            return reader.HasRows;
        }
    }
}