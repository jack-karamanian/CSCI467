using System;
using MySql.Data.MySqlClient;

namespace CSCI467Library
{
    public class LogIn
    {
        public bool Is_Admin;
        public bool Is_MidManager;
        public bool Is_Reciever;

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        public MySqlConnection connection;

        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public void LogInDBConnect()
        {
            if (connection != null)
                connection.Close();

            string connStr = String.Format("server={0};user id={1}; password={2}; database=sql5117893; port={3}",
                host, username, password, port);

            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();

                connection.ChangeDatabase("sql5117893");
            }
            catch
            {
            }
        }

        public LogIn()
        {
            LogInDBConnect();
        }

        public LogIn(string id, string password)
        {
            LogInDBConnect();
            Is_Admin = Verify_Admin(id, password);
            Is_MidManager = Verify_MidManager(id, password);
            Is_Reciever = Verify_Reciever(id, password);
        }

        public bool Verify_Admin(string id, string pw)
        {
            string query = "SELECT * FROM loginData WHERE emp_id='" + id + "'";
            
            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            MySqlDataReader reader = null;

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (Convert.ToString(reader["password"]) == pw)
                        {
                            if (id[0] == 'A')
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool Verify_Reciever(string id, string pw)
        {
            string query = "SELECT * FROM loginData WHERE emp_id='" + id + "'";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            MySqlDataReader reader = null;

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (Convert.ToString(reader["password"]) == pw)
                        {
                            if (id[0] == 'e')
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public bool Verify_MidManager(string id, string pw)
        {
            string query = "SELECT * FROM loginData WHERE emp_id='" + id + "'";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            MySqlDataReader reader = null;

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (Convert.ToString(reader["password"]) == pw)
                        {
                            if (id[0] == 'k')
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
