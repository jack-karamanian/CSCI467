using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace CSCI467Library {
    public class PartsDBConnector {
        static readonly string GetAllPartsQuery = "SELECT * FROM parts";

        MySqlConnection connection;
        public PartsDBConnector(string host, int port, string username, string password) {
            string connectionString = String.Format("server={0};port={1};uid={2};pwd={3};database=csci467;", host, port, username, password);
            connection = new MySqlConnection(connectionString);
        }

        public List<Part> GetAllParts() {
            List<Part> parts = new List<Part>();

            connection.Open();
            MySqlDataReader reader = QueryConnection(GetAllPartsQuery);

            while (reader.Read()) {
                var part = new Part(reader.GetInt32("number"), reader.GetString("description"), reader.GetFloat("price").ToString());
                parts.Add(part);
            }

            connection.Close();

            return parts;
        }

        public Part GetPartByID(int id) {
            string query = String.Format("SELECT * FROM parts WHERE number = {0}", id);

            connection.Open();
            MySqlDataReader reader = QueryConnection(query);

            reader.Read();
            Part part = new Part(reader.GetInt32("number"), reader.GetString("description"), reader.GetFloat("price").ToString());

            connection.Close();
            return part;
        }

        MySqlDataReader QueryConnection(string query) {
            MySqlCommand command = new MySqlCommand(query, connection);
            return command.ExecuteReader();
        }
    }
}
