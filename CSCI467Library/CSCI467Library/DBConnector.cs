using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace CSCI467Library {
    public class DBConnector {
        public MySqlConnection Connection { get; private set; }

        public DBConnector(string host, int port, string username, string password, string database) {
            string connectionString = String.Format("server={0};port={1};uid={2};pwd={3};database={4};", host, port, username, password, database);
            Connection = new MySqlConnection(connectionString);
        }
    }
}
