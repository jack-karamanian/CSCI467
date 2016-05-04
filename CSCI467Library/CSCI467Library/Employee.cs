using System;
using MySql.Data.MySqlClient;

namespace CSCI467Library {
    public class Employee {

        public int ID { get; set; }
        public string Password { get; set; }

        public Employee()
        {
            ID = 0;
            Password = "";
        }

        public Employee(int id, string password) {
            ID = id;
            Password = password;
        }
    }
}
