﻿using System;
using System.Data.SqlClient;

namespace WindowsFormsApp4.Imp
{
    public abstract class ConnDB
    {
        public static SqlConnection Conn()
        {
            // tùy vào mỗi máy nha, mỗi người xe có cổng và tên đang nhập khác nhau
            String connString = "Data Source=localhost,1433;Initial Catalog=milktea;User ID=SA;Password=1234";
            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }
        
    }
}