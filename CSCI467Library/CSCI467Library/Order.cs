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
    class Order {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;
        
        public Address Destination { get; set; }
        public DateTime TimeOrdered { get; set; }
        public Tax TaxRates { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public string order_id { get; set; }
        public Customer customerInfo { get; set; }
        public List<Part> PartsOrdered { get; private set; }

        string partID_fromStorage = null;

        public Order()
        {
            Destination = new Address();
            TimeOrdered = new DateTime();
            TaxRates = new Tax();
            order_id = 0;
            SubTotal = 0;
            Total = 0;
            PartsOrdered = new List<Part>();
        }

        public Order(Address destination, DateTime timeOrdered, Tax taxes, double subTotal, double total, List<Part> parts) {
            Destination = destination;
            TimeOrdered = timeOrdered;
            TaxRates = taxes;
            SubTotal = subTotal;
            Total = total;
            PartsOrdered = parts;
            Add_OrderToStorage(this);
        }

        public void Add_OrderToStorage(Order newOrder)
        {
            Order temp = newOrder;
            string storage = null;
            foreach (Part part in temp.PartsOrdered)
            {
                storage += part.ID;
                storage += "-";
            }
            string query = "INSERT INTO Order (parts,customer_id,time_order) VALUES (\"" + storage +
                "\",\"" + temp.customerInfo.ID + "\",\"" + (Convert.ToString(TimeOrdered)) + "\";";

             adapter = new MySqlDataAdapter(query, connection);
             builder = new MySqlCommandBuilder(adapter);
        }

        public Order GetOrderBy_ID(string Order_id)
        {
            string query = "select * from Order where order_num=\"" + Order_id + "\";";
            Order temp = new Order();

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        temp.order_id = (Convert.ToString(reader["order_num"]));
                        string temp_storage = null;
                        temp_storage = (Convert.ToString(reader["name"]));
                        string[] parts = temp_storage.Split('-');
                        for(int i = 0; parts[i] != null; i++)
                        {
                            Part getPart = new Part();
                            temp.PartsOrdered[i] = getPart.GetOnePartBy_ID(parts[i]);
                        }
                    }
                }
            }
            return temp;
        }
    }
}
