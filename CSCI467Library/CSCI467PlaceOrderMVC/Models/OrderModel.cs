using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CSCI467Library;

namespace CSCI467PlaceOrderMVC.Models
{
    public class OrderModel
    {
        public int Quantity { get; set; }
        public Part Part { get; set; }

        public OrderModel(int quantity, Part part)
        {
            Quantity = quantity;
            Part = part;
        }
        public OrderModel() {
        }
    }
}