using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace DevOpsApi.Services
{
    public class FileReader
    {
        string ConfFile = File.ReadAllText("./DBconnection.conf");
        public string port, server, database, user, password; 

        public FileReader()
        {
            readFile();
        }
        public void readFile()
        {
            string[] keyValuePairs = ConfFile.Split(';');

            foreach (string pair in keyValuePairs)
            {
                string[] parts = pair.Split('=');
                if (parts.Length == 2)
                {
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();

                    if (key == "port")
                        port = value;
                    else if (key == "server")
                        server = value;
                    else if (key == "database")
                        database = value;
                    else if (key == "user")
                        user = value;
                    else if (key == "password")
                        password = value;
                }
            }
        }

        public string getConnectionString()
        {
            return "server="+server+";port="+port+";database="+database+";user="+user+";password="+password+";";

                //server=localhost;port=3306;database=DevOpsExamDB;user=root;password=baum123456
        }

        public string getConfFile()
        {
            return ConfFile;
        }

    }
}
