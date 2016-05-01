using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSCI467PlaceOrderMVC.Models
{
    public class InfoModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string ZIP { get; set; }
        public string SubTotal { get; set; }

        public InfoModel(string firstName, string lastName, string address, string state, string zip, string subtotal) {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            State = state;
            ZIP = zip;
            SubTotal = subtotal;
        }

        public InfoModel() { }

    }
}