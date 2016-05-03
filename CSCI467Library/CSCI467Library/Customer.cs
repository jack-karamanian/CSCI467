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

namespace CSCI467Library {

    public class Customer {

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;

        public string ID { get; private set; }
        public string Name { get; private set; }
        public Address Address { get; private set; }

        public Customer()
        {
            Name = "";
            Address = new Address();
            ID = "";
        }

        public Customer(string name, string id, Address address) {
            Name = name;
            Address temp = new Address();
            Address = temp.GetAddressBy_ID(id);
            ID = id;
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
                        temp.Name = Int32.Parse((Convert.ToString(reader["name"])));
                    }
                }
            }
            return temp;
        }
    }
}
