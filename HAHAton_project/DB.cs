﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HAHAton_project
{
    internal class DB
    {   
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=KOMPUTER\SQLEXPRESS;Initial Catalog=ROSDB.MDF;Integrated Security=True");
        //KOMPUTER
        //HOME-PC

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
