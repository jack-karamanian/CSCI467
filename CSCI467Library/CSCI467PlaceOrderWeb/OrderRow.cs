using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCI467Library;

namespace CSCI467PlaceOrderWeb
{
    public class OrderRow
    {
        public int Quantity { get; set; }
        public Part Part { get; set; }

        public OrderRow(int quantity, Part part) {
            Quantity = quantity;
            Part = part;
        }
    }
}