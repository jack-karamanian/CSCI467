using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {
    public class Order {
        public Address Destination { get; set; }
        public DateTime TimeOrdered { get; set; }
        public double TaxRate { get; set; }
        public double Shipping { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public Customer Customer { get; set; }
        public Dictionary<int, int> PartsOrdered { get; private set; }

        public Order(Address destination, DateTime timeOrdered, double taxes, double shipping, double subTotal, double total, Customer customer, Dictionary<int, int> parts) {
            Destination = destination;
            TimeOrdered = timeOrdered;
            TaxRate = taxes;
            Shipping = shipping;
            SubTotal = subTotal;
            Total = total;
            Customer = customer;
            PartsOrdered = parts;
            
        }

        private void FillParts(List<Part> parts) {
            foreach (Part part in parts) {
                PartsOrdered[part.ID]++;
            }
        }
    }
}
