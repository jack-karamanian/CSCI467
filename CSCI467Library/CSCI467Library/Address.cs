using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {

    public class Address {
        public string Line1 { get; private set; }
        public string Line2 { get; private set; }
        public string Country { get; private set; }
        public int ZIPCode { get; private set; }
        public string State { get; private set; }

        public Address(string line1, string line2, string country, int zip, string state) {
            Line1 = line1;
            Line2 = line2;
            Country = country;
            ZIPCode = zip;
            State = state;
        }
    }

}
