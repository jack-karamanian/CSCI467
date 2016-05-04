using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace CSCI467Library {
    class Tax {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        MySqlConnection connection;

        public double Rate { get; set; }

        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public Tax()
        {
            Rate = 0.1;

            string connectionString = String.Format("server={0};port={1};uid={2};pwd={3};database=sql5117893;", host, port, username, password);
            connection = new MySqlConnection(connectionString);
        }

        public Tax( double percentage )
        {
           SetTax_Rate(percentage);
            Rate = GetTaxRate();

            string connectionString = String.Format("server={0};port={1};uid={2};pwd={3};database=sql5117893;", host, port, username, password);
            connection = new MySqlConnection(connectionString);
        }

        public void SetTax_Rate(double x)
        {
            string query = "UPDATE tax SET percent =" + (Convert.ToString(x)) + ";";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
        }

        public double GetTaxRate()
        {
            string query = "select * from tax;";

            Tax temp = new Tax();

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        temp.Rate = (double)Int32.Parse((Convert.ToString(reader["percent"])));
                    }
                }
            }
            return temp.Rate;
        }
    }
}
