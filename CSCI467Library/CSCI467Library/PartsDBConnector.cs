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
    public class PartsDBConnector {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;
        
        static readonly string GetAllPartsQuery = "SELECT * FROM parts;";

        public PartsDBConnector()
        {
            string connectionString = "server=blitz.cs.niu.edu;port=3306;uid=student;pwd=student;database=csci467;";
            connection = new MySqlConnection(connectionString);
        }

        public PartsDBConnector(string host, int port, string username, string password) {
            string connectionString = String.Format("server={0};port={1};uid={2};pwd={3};database=csci467;", host, port, username, password);
            connection = new MySqlConnection(connectionString);
        }

        public DataTable GetAllParts() {
            parts = new DataTable();

            adapter = new MySqlDataAdapter(GetAllPartsQuery, connection);
            builder = new MySqlCommandBuilder(adapter);

            adapter.Fill(parts);

            return parts;
        }

        public DataTable GetPartBy_ID(string id) {
            string query = "SELECT * FROM parts WHERE number = '" + id + "';";

            parts = new DataTable();

            adapter = new MySqlDataAdapter(query, connection);
            builder = new MySqlCommandBuilder(adapter);

            adapter.Fill(parts);

            return parts;
        }

        public void update()
        {
            DataTable changes = parts.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
                parts.AcceptChanges();
            }
        }
    }
}
