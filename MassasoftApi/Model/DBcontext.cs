using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DevOpsApi.Model
{ 
public class DBcontext
    {
        public string ConnectionString { get; set; }

        public DBcontext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
