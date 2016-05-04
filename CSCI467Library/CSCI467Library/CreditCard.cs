using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSCI467Library {
    public class CreditCard {

        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        MySqlConnection connection;

        public string Name { get; private set; }
        public int Number { get; private set; }
        public int SecurityCode { get; private set; }
        public string ExpirationDate { get; set; }

        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public void CreditCardConnect()
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
            }
        }

        public CreditCard()
        {
            Name = "";
            Number = 0;
            SecurityCode = 0;
            ExpirationDate = "";
            CreditCardConnect();
        }

        public CreditCard(string name, int number, int secCode, string expDate) {
            Name = name;
            Number = number;
            SecurityCode = SecurityCode;
            ExpirationDate = expDate;
            CreditCardConnect();
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
