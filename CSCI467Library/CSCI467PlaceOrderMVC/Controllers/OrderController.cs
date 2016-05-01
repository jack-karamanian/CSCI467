using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Net;
using System.Net.Sockets;
using CSCI467PlaceOrderMVC.Models;
using CSCI467Library;

namespace CSCI467PlaceOrderMVC.Controllers
{
    public class OrderController : Controller
    {
        private List<OrderModel> orders = new List<OrderModel>();

        // GET: Order
        public ActionResult Index()
        {
            var connection = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
            
            var allParts = connection.GetAllParts();

            foreach (Part p in allParts)
            {
                orders.Add(new OrderModel(0, p));
            }
            return View(orders);
        }

        [HttpPost]
        public ActionResult EnterInfo(IList<OrderModel> orders) {
            
            var query = from order in orders where order.Quantity >= 1 select order;
            ViewBag.Orders = query.ToList<OrderModel>();
            Session["Orders"] = query;
            ViewBag.TaxInfo = GetTaxInfo();
            return View(new InfoModel());
        }

        [HttpPost]
        public ActionResult EnterCreditCard(InfoModel info) {
            ViewBag.Orders = Session["Orders"];
            ViewBag.TaxInfo = GetTaxInfo();
            return View(info);
        }

        public string ProcessCreditCard(string ccName, string ccNumber, DateTime expDate, string amount) {
            var socket = new UdpClient("blitz.cs.niu.edu", 4445);
            var ccString = ccNumber + ":" + expDate.Month + "/" + expDate.Year + ":" + amount + ":" + ccName;

            var encoding = Encoding.GetEncoding("UTF-8");
            var bytes = encoding.GetBytes(ccString);
            socket.Send(bytes, bytes.Count());

            IPEndPoint endpoint = null;
            var message = socket.Receive(ref endpoint);
            return encoding.GetString(message);
        }

        Dictionary<string, Tax> GetTaxInfo() {
            var taxes = new Dictionary<string, Tax>();
            taxes.Add("IL", new Tax { StateRate = 5.0 });
            taxes.Add("CA", new Tax { StateRate = 6.0 });
            taxes.Add("MA", new Tax { StateRate = 4.0 });
            return taxes;
        }
    }
}