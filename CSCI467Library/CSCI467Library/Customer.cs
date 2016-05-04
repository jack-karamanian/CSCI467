using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSCI467Library {

    public class Customer {

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        MySqlConnection connection;

        public string ID { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }

        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public void CustomerConnect()
        {
            if (connection != null)
                connection.Close();

            string connStr = String.Format("server={0};user id={1}; password={2}; database=sql5117893; port={3}",
                host, username, password,port);

            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();
            }
            catch
            {
                return;
            }
        }
        public Customer()
        {
            Name = "";
            Address = new Address();
            ID = "";

            CustomerConnect();
        }

        public Customer(string name, string id, Address address) {
            Name = name;
            Address temp = new Address();
            Address = temp.GetAddressBy_ID(id);
            ID = id;

            CustomerConnect();
        }

        public void Add_CustomerToStorage()
        {
            string query = "INSERT INTO customer (customer_id,name) VALUES (\"" + ID +
                "\",\"" + Name + "\"";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
        }

        public Customer GetCustomerBy_ID(string customer_id)
        {
            string query = "select * from Customer where customer_id=\"" + customer_id + "\";";
            Customer temp = new Customer();

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        temp.ID = (Convert.ToString(reader["customer_id"]));
                        temp.Name = (Convert.ToString(reader["name"]));
                    }
                }
            }
            return temp;
        }
    }
}
