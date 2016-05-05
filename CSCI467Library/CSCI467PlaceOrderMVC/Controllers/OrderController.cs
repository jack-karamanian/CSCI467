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
        private TaxDBConnector taxDbConnector = new TaxDBConnector("sql5.freemysqlhosting.net", 3306, "sql5117893", "XSHuaIJZLY", "sql5117893");
        private OrderDBConnector orderDbConnector = new OrderDBConnector("sql5.freemysqlhosting.net", 3306, "sql5117893", "XSHuaIJZLY", "sql5117893");

        // GET: Order
        public ActionResult Index()
        {
            // Retrieve all parts
            var connection = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
            
            var allParts = connection.GetAllParts();

            foreach (Part p in allParts)
            {
                orders.Add(new OrderModel(0, p));
            }
            return View(orders);
        }

        /// <summary>
        /// Captures the selected parts and prompts InfoModel input.
        /// </summary>
        /// <param name="orders">The selected parts.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EnterInfo(IList<OrderModel> orders) {
            
            var query = from order in orders where order.Quantity >= 1 select order;
            ViewBag.Orders = query.ToList<OrderModel>();
            Session["Orders"] = query;
            ViewBag.TaxInfo = GetTaxInfo();
            return View(new InfoModel());
        }

        /// <summary>
        /// Retrieves InfoModel and prompts credit card input
        /// </summary>
        /// <param name="info">The order information.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult EnterCreditCard(InfoModel info) {
            ViewBag.Orders = Session["Orders"];
            var taxinfo = GetTaxInfo();
            var saletax = (from TaxShippingModel tax in taxinfo where tax.State == info.State && tax.ZIP.ToString() == info.ZIP select tax).ToList()[0];
            ViewBag.TaxInfo = saletax;
            Session["Order"] = info;
            Session["TaxInfo"] = saletax;
            return View(info);
        }

        /// <summary>
        /// Retrieves credit card information, validates it, and adds the order
        /// to the database if the card is valid.
        /// </summary>
        /// <param name="ccName">Credit card holder name</param>
        /// <param name="ccNumber">Credit card number</param>
        /// <param name="expDate">Credit card expiration date</param>
        /// <param name="amount">Amount to be charged</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult ProcessCreditCard(string ccName, string ccNumber, DateTime expDate, string amount) {
            string message = VerifyCreditCard(ccName, ccNumber, expDate, amount);

            string response = "";

            bool validCreditCard = message.Contains("is valid");
            if (validCreditCard) {
                response = "Order successful.";
                IEnumerable<OrderModel> parts = (IEnumerable<OrderModel>)Session["Orders"];

                InfoModel order = (InfoModel)Session["Order"];
                TaxShippingModel tax = (TaxShippingModel)Session["TaxInfo"];

                Dictionary<int, int> partsDict = new Dictionary<int, int>();
                foreach (var model in parts) {
                    partsDict[model.Part.ID] = model.Quantity;
                }
                double subtotal = Convert.ToDouble(order.SubTotal);
                orderDbConnector.AddOrder(new Order(new Address(order.Address, "", "US", Convert.ToInt32(order.ZIP), order.State),
                                          DateTime.Now,
                                          tax.Tax, tax.Shipping, subtotal,
                                          (subtotal + (subtotal * tax.Tax) + (subtotal * tax.Shipping)),
                                          new Customer(order.FirstName + " " + order.LastName, null), partsDict));

            } else {
                response = "Credit card validation falied.";
            }

            return View("~/Views/Order/ProcessCreditCard.cshtml", null, response);
        }

        /// <summary>
        /// Gets all tax informaion
        /// </summary>
        /// <returns></returns>
        public List<TaxShippingModel> GetTaxInfo() {
            return taxDbConnector.GetAllTaxInfo();
        }

        /// <summary>
        /// Verifies a credit card
        /// </summary>
        /// <param name="ccName">Credit card holder name</param>
        /// <param name="ccNumber">Credit card number</param>
        /// <param name="expDate">Credit card expiration date</param>
        /// <param name="amount">Amount to be charged</param>
        /// <returns>The verification server response</returns>
        private string VerifyCreditCard(string ccName, string ccNumber, DateTime expDate, string amount) {
            var socket = new UdpClient("blitz.cs.niu.edu", 4445);
            var ccString = ccNumber + ":" + expDate.Month + "/" + expDate.Year + ":" + amount + ":" + ccName;

            var encoding = Encoding.GetEncoding("UTF-8");
            var bytes = encoding.GetBytes(ccString);
            socket.Send(bytes, bytes.Count());

            IPEndPoint endpoint = null;
            var message = socket.Receive(ref endpoint);
            return encoding.GetString(message);
        }
    }
}