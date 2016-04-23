using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {
    public class Employee {
        public int ID { get; set; }
        public string Password { get; set; }

        public Employee(int id, string password) {
            ID = id;
            Password = password;
        }
    }
}
