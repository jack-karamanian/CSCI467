using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCI467Library;
using Excel = Microsoft.Office.Interop.Excel;
using MySql;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;

namespace CSCI467FulfillOrder
{
    public class Program
    {
        public string returnPath()
        {
            string folder = Environment.CurrentDirectory;
            return folder;
        }

        public int runFulfillOrder()
        {
            string connStr = String.Format("server={0};user id={1}; password={2}; database=sql5117893; port={3}",
                host, username, password, port);

            OrderDBConnector orderDB = new OrderDBConnector(host, port, username, password, username);
            Order order = orderDB.GetOldestOrder();

            PartsDBConnector partsDB = new PartsDBConnector(partHost, partPort, partUsername, partPassword);

            int oID = orderDB.GetPartID();

            generatePackingList(partsDB, order, oID);
            generateShippingLabel(partsDB, order, oID);
            generateInvoice(partsDB, order, oID);

            //orderDB.RemoveOldestOrder();

            return 0;

        }

        private static Excel.Workbook MyBook = null;
        private static Excel.Application MyApp = null;
        private static Excel.Worksheet MySheet = null;

        private static string host = "sql5.freemysqlhosting.net";
        private static int port = 3306;
        private static string username = "sql5117893";
        private static string password = "XSHuaIJZLY";

        private static string partHost = "blitz.cs.niu.edu";
        private static int partPort = 3306;
        private static string partUsername = "student";
        private static string partPassword = "student";

        static void Main()
        {
            string connStr = String.Format("server={0};user id={1}; password={2}; database=sql5117893; port={3}",
                host, username, password, port);

            OrderDBConnector orderDB = new OrderDBConnector(host, port, username, password, username);
            Order order = orderDB.GetOldestOrder();

            PartsDBConnector partsDB = new PartsDBConnector(partHost , partPort , partUsername , partPassword);

            int oID = orderDB.GetPartID();

            generatePackingList(partsDB, order, oID);
            generateShippingLabel(partsDB, order, oID);
            generateInvoice(partsDB, order, oID);

            //orderDB.RemoveOldestOrder();
        }

        

        static void generateShippingLabel(PartsDBConnector partsDB, Order order, int  orderID)
        {

            MyApp = new Excel.Application();
            MyApp.Visible = false;
            string templatePath = Path.Combine(Environment.CurrentDirectory, @"Data\Templates\shippingLabelTemplate.xlsx");

            MyBook = MyApp.Workbooks.Open(templatePath);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explicit cast is not required here

            MySheet.Cells[11, 3].Value = order.Customer.Name;
            MySheet.Cells[12, 3].Value = order.Destination.Line1;
            MySheet.Cells[13, 3].Value = order.Destination.Line2;

            string zipState;

            zipState = order.Destination.ZIPCode + "   " + order.Destination.State + "   " + order.Destination.Country;

            MySheet.Cells[14, 3].Value = zipState;

            MySheet.Cells[1, 5].Value = DateTime.Today;

            //to-do: find palce in db to store reports
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\ShippingLabels\");
            path = path + "shippingLabel" + orderID + ".xlsx";

            //string savePath = @"C:\Users\justin\Desktop\Reports\invoices\";
            //savePath = savePath + ;

            MySheet.SaveAs(path);

            MySheet.PrintOutEx();

            MyApp.Quit();
        }

        static void generatePackingList(PartsDBConnector partsDB, Order order, int orderID)
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            string templatePath = Path.Combine(Environment.CurrentDirectory, @"Data\Templates\packingListTemplate.xlsx");

            MyBook = MyApp.Workbooks.Open(templatePath);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explicit cast is not required here

            MySheet.Cells[1, 1].Value = "Employee Packing List   #" + orderID;

            int rowCount = 4;
            foreach (KeyValuePair<int, int> entry in order.PartsOrdered )
            {
                Part part = partsDB.GetPartByID(entry.Key);
                // do something with entry.Value or entry.Key
                MySheet.Cells[rowCount, 1].Value = "#" + entry.Key + "-" + part.Name;
                MySheet.Cells[rowCount, 2].Value = entry.Value;

                rowCount += 1;
            }

            MySheet.Cells[1, 2].Value = DateTime .Today ;

            //to-do: find palce in db to store reports
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\PackingLists\");
            path = path + "packingList" + orderID + ".xlsx";

            //string savePath = @"C:\Users\justin\Desktop\Reports\invoices\";
            //savePath = savePath + ;

            MySheet.SaveAs(path);
            MySheet.PrintOutEx();

            MyApp.Quit();
        }

        static void generateInvoice(PartsDBConnector partsDB, Order order, int orderID)
        {
            MyApp = new Excel.Application();
            MyApp.Visible = false;
            string templatePath = Path.Combine(Environment.CurrentDirectory, @"Data\Templates\invoiceTemplate.xlsx");

            MyBook = MyApp.Workbooks.Open(templatePath);
            MySheet = (Excel.Worksheet)MyBook.Sheets[1]; // Explicit cast is not required here

            //add customer information to excel invoice template
            MySheet.Cells[4, 6].Value = orderID;
            MySheet.Cells[10, 1].Value = order.Customer.Name;
            MySheet.Cells[11, 1].Value = order.Destination.Line1;
            MySheet.Cells[12, 1].Value = order.Destination .Line2;
            MySheet.Cells[13, 1].Value = order.Destination.State;
            MySheet.Cells[14, 1].Value = order.Destination .ZIPCode;

            MySheet.Cells[35, 6].Value = order.TaxRate / 100;

            int rowCount = 17;
            //for each item in part List
            foreach (KeyValuePair<int, int> entry in order.PartsOrdered)
            {
                // do something with entry.Value or entry.Key
                Part part = partsDB.GetPartByID(entry.Key);

                MySheet.Cells[rowCount, 1].Value = part.Name;
                MySheet.Cells[rowCount, 5].Value = entry.Value;
                MySheet.Cells[rowCount, 6].Value = part.Price;
                rowCount += 1;
            }
            MySheet.Cells[1, 2].Value = DateTime.Today;

            string path = Path.Combine(Environment.CurrentDirectory, @"Data\Invoices\");
            path = path + "invoice" + orderID + ".xlsx";

            MySheet.SaveAs(path);
            MySheet.PrintOutEx();

            MyApp.Quit();
        }
    }
}
