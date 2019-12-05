﻿using System;
using System.Data.Common;
using System.Data.SqlClient;
 using milktea.Entity;

 namespace milktea.Imp
{
    public class EmployessDAO : ConnDB
    {
        public static Boolean Login(Employess employess)
        {
//          2 dòng này buộc phải có
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