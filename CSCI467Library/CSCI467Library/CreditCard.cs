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
    public class CreditCard {

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;

        public string Name { get; private set; }
        public int Number { get; private set; }
        public int SecurityCode { get; private set; }
        public string ExpirationDate { get; set; }
        

        public CreditCard(string name, int number, int secCode, string expDate) {
            Name = name;
            Number = number;
            SecurityCode = SecurityCode;
            ExpirationDate = expDate;
        }

        public void Add_CreditCardToStorage(string customer_id)
        {
            string query = "INSERT INTO credit_card (customer_id,cus_name,card_num,ssid,exp_date) VALUES (\"" + customer_id +
                "\",\"" + Name + "\",\"" + Number + "\",\"" + SecurityCode + "\",\"" 
                + ExpirationDate + "\";";

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);
        }

        public CreditCard GetCreditCardBy_ID(string customer_id)
        {
            string query = "select * from CreditCard where customer_id=\"" + customer_id + "\";";
            CreditCard temp = new CreditCard("",0,0,"");

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    //DateTime mytime = DateTime.Now  ;
                    if (reader.HasRows)
                    {
                        temp.Name = (Convert.ToString(reader["cus_name"]));
                        temp.Number = Int32.Parse((Convert.ToString(reader["card_num"])));
                        temp.SecurityCode = Int32.Parse((Convert.ToString(reader["ssid"])));
                        temp.ExpirationDate = (Convert.ToString(reader["exp_date"]));
                    }
                }
            }
            return temp;
        }
    }
}
