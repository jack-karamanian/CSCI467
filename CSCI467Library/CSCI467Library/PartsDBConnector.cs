using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace CSCI467Library {
    public class PartsDBConnector : DBConnector {
        static readonly string GetAllPartsQuery = "SELECT * FROM `parts`";

        public PartsDBConnector(string host, int port, string username, string password) : base(host, port, username, password, "csci467") {
            
        }

        public List<Part> GetAllParts() {
            List<Part> parts = new List<Part>();

            Connection.Open();
            MySqlDataReader reader = QueryConnection(GetAllPartsQuery);

            while (reader.Read()) {
                var part = new Part(reader.GetInt32("number"), reader.GetString("description"), reader.GetFloat("price").ToString());
                parts.Add(part);
            }

            Connection.Close();

            return parts;
        }

        public Part GetPartByID(int id) {
            string query = String.Format("SELECT * FROM parts WHERE number = {0}", id);

            Connection.Open();
            MySqlDataReader reader = QueryConnection(query);

            reader.Read();
            Part part = new Part(reader.GetInt32("number"), reader.GetString("description"), reader.GetFloat("price").ToString());

            Connection.Close();
            return part;
        }

        MySqlDataReader QueryConnection(string query) {
            MySqlCommand command = new MySqlCommand(query, Connection);
            return command.ExecuteReader();
        }
    }
}
