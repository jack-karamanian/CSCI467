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
    public class Part {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;

        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Price { get; private set; }


        public Part()
        {
            ID = "";
            Name = "";
            Price = "";
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
            string query = "select * from Part where Part_num=\"" + Part_id + "\";";
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
