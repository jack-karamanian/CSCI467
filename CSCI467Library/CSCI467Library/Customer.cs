using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {

    public class Customer {
        public string Name { get; private set; }
        public Address Address { get; private set; }

        public Customer(string name, Address address) {
            Name = name;
            Address = address;
        }
    }
    
}
