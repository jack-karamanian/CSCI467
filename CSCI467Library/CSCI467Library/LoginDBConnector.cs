using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace CSCI467Library
{
    public class LoginDBConnector : DBConnector
    {
        public LoginDBConnector(string host, int port, string username, string password, string database)
            : base(host, port, username, password, database)
        {

        }

        public bool Is_Admin(string ID, string pw)
        {
            Connection.Open();

            var command = new MySqlCommand("SELECT * FROM `loginData` WHERE emp_id='" + ID + "' and password='" + pw + "'", Connection);
            var reader = command.ExecuteReader();

            reader.Read();
            try
            {
                if ('A' == reader.GetString("emp_id")[0]) return true;
            }
            catch
            {
                Connection.Close();
                return false;
            }
            Connection.Close();
            return false;
        }

        public bool Is_Employee(string ID, string pw)
        {
            Connection.Open();

            var command = new MySqlCommand("SELECT * FROM `loginData` WHERE emp_id='" + ID + "' and password='" + pw + "'", Connection);
            var reader = command.ExecuteReader();

            reader.Read();
            try
            {
                if ('A' == reader.GetString("emp_id")[0]) return false;
            }
            catch
            {
                Connection.Close();
                return false;
            }
            

            Connection.Close();

            return true;
        }
    }
}
