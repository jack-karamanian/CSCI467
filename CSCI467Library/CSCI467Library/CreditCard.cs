using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {
    public class CreditCard {
        public string Name { get; private set; }
        public int Number { get; private set; }
        public int SecurityCode { get; private set; }
        public DateTime ExpirationDate { get { return expirationDate; } }

        private readonly DateTime expirationDate;

        public CreditCard(string name, int number, int secCode, DateTime expDate) {
            Name = name;
            Number = number;
            SecurityCode = SecurityCode;
            expirationDate = expDate;
        }
    }
}
