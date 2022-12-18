using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace HAHAton_project
{
    internal class DB
    {
        MySqlConnection sqlConnection = new MySqlConnection("server=31.31.198.22;port=3306;database=u1878080_rosdb;username=u1878080_admin;password=KringeSquad");

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

        public MySqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
