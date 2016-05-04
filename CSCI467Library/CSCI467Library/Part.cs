using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSCI467Library {
    public class Part {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        MySqlConnection connection;

        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Price { get; private set; }

        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public void PartConnect()
        {
            if (connection != null)
                connection.Close();

            string connStr = String.Format("server={0};user id={1}; password={2}; database=sql5117893; port={3}",
                host, username, password, port);

            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();
            }
            catch
            {
            }
        }

        public Part()
        {
            ID = "";
            Name = "";
            Price = "";
            PartConnect();
        }

        public Part(string id, string name, string price)
        {
            ID = id;
            Name = name;
            Price = price;
            PartConnect();
        }

        public static bool operator ==(Part a, Part b) {
            return a.ID == b.ID;
        }

        public static bool operator !=(Part a, Part b) {
            return a.ID != b.ID;
        }

        public override bool Equals(object obj) {
            return ID == ((Part)obj).ID;
        }

        public Part GetOnePartBy_ID(string Part_id)
        {
            string query = "select * from Part where Part_num=\"" + Part_id + "\"";
            Part temp = new Part();

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        temp.ID = (Convert.ToString(reader["number"]));
                        temp.Name = (Convert.ToString(reader["description"]));
                        temp.Name = (Convert.ToString(reader["price"]));
                    }
                }
            }
            return temp;
        }
    }
}
