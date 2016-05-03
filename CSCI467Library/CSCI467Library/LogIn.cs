using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using CSCI467Library;

namespace CSCI467Library
{
    public class LogIn
    {
        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public bool Is_Admin { get; set; }
        public bool Is_MidManager { get; set; }
        public bool Is_Reciever { get; set; }

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        MySqlConnection connection;

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

        public void LogInDBConnect()
        {
            string connectionString = String.Format("server={0};port={1};uid={2};pwd={3};database=sql5117893;", host, port, username, password);
            connection = new MySqlConnection(connectionString);
        }

        public bool Verify_Admin(string id, string password)
        {
            string query = "SELECT * FROM loginData WHERE emp_id='" + id + "';";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        if (Convert.ToString(reader["password"]) != password)
                        {
                            reader.Close();
                            connection.Close();
                            return false;
                        }
                        else
                        {
                            connection.Close();
                            reader.Close();
                            return true;
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        return false;
                    }
                }
            }
        }

        public bool Verify_Reciever(string id, string password)
        {
            string query = "SELECT * FROM loginData WHERE emp_id='" + id + "';";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        if (Convert.ToString(reader["password"]) != password)
                        {
                            reader.Close();
                            connection.Close();
                            return false;
                        }
                        else
                        {
                            connection.Close();
                            reader.Close();
                            return true;
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        return false;
                    }
                }
            }
        }

        public bool Verify_MidManager(string id, string password)
        {
            string query = "SELECT * FROM loginData WHERE emp_id='" + id + "';";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        if (Convert.ToString(reader["password"]) != password)
                        {
                            reader.Close();
                            connection.Close();
                            return false;
                        }
                        else
                        {
                            connection.Close();
                            reader.Close();
                            return true;
                        }
                    }
                    else
                    {
                        reader.Close();
                        connection.Close();
                        return false;
                    }
                }
            }
        }
    }
}
