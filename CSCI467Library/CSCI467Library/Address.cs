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

    public class Address {

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;

        public string house_number { get; private set; }
        public string apartmentNUM { get; private set; }
        public string street_name { get; private set; }
        public string Country { get; private set; }
        public int ZIPCode { get; private set; }
        public string State { get; private set; }

        public Address()
        {
            house_number = 0;
            street_name = "";
            Country = "";
            ZIPCode = 0;
            State = "";
            apartmentNUM = 0;
        }

        public Address(string customer_id, string line1, string line2, string country, int zip, string state,string apartmentNumber) {
            house_number = line1;
            street_name = line2;
            Country = country;
            ZIPCode = zip;
            State = state;
            apartmentNUM = apartmentNumber;
            Add_AddressToStorage(customer_id);
        }

        public void Add_AddressToStorage(string customer_id)
        {
            string query = "INSERT INTO address (customer_id,street_num,street_name,state,zip_code,country,apartment_num) VALUES (\""+customer_id+
                "\",\"" + house_number + "\",\"" + street_name + "\",\"" + State + "\",\"" + ZIPCode + "\",\"" + Country + "\",\"" 
                + apartmentNUM + "\";";
            
            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
        }

        public Address GetAddressBy_ID(string customer_id) 
        {
            string query = "select * from address where customer_id=\"" + customer_id + "\";";
            Address temp = new Address();

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        temp.house_number = (Convert.ToString(reader["street_num"]));
                        temp.street_name = (Convert.ToString(reader["street_name"]));
                        temp.Country = (Convert.ToString(reader["street_name"]));
                        temp.ZIPCode = Int32.Parse((Convert.ToString(reader["zip_code"])));
                        temp.State = (Convert.ToString(reader["state"]));
                        temp.apartmentNUM = (Convert.ToString(reader["apartment_num"]));
                    }
                }
            }
            return temp;
        }
    }
}
