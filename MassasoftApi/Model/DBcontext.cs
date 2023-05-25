using DevOpsApi.Services;
using DevOpsExamApi.Model;
using Microsoft.AspNetCore.Http.HttpResults;
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
        public DBcontext() 
        {
            FileReader fr = new FileReader();
            this.ConnectionString = fr.getConnectionString();
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public void insertMessage(Message message)
        {
            string email = message.Email;
            string subject = message.Subject;
            string body = message.Body;
            //try
            //{
                //This is my update query in which i am taking input from the user through windows forms and update the record.
                string query = $"INSERT INTO Messages (Email, Subject, Body) VALUES ('{email}', '{subject}', '{body}');";


                //This is  MySqlConnection here i have created the object and pass my connection string.
                MySqlConnection MyConn = new MySqlConnection(this.ConnectionString);
                MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                {
                }
                MyConn.Close();//Connection closed here
            
                
            
        }
    }
}
