using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSCI467PlaceOrderMVC.Models {
    public class TaxShippingModel {
        public string State { get; set; }
        public int ZIP { get; set; }
        public float Tax { get; set; }
        public float Shipping { get; set; }
    }
}