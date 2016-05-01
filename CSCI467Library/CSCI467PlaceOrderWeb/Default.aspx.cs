using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CSCI467Library;

namespace CSCI467PlaceOrderWeb {
    public partial class _Default : Page {
        private List<Part> allParts;
        protected List<OrderRow> orderRows;

        protected void Page_Load(object sender, EventArgs e) {


                var connection = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
                orderRows = new List<OrderRow>();
                allParts = connection.GetAllParts();

                foreach (Part p in allParts)
                {
                    orderRows.Add(new OrderRow(0, p));
                }

            GridView1.DataSource = orderRows;
            GridView1.DataBind();
            
        }

        protected void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            textbox.Text = "Hello world";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write("Hello World");
        }

        protected void NextButton_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = orderRows;
            GridView1.DataBind();
            foreach (var item in Request.Form.AllKeys)
            {
                //var textBox = (TextBox)row.FindControl("quantityTextBox");
                System.Diagnostics.Debug.WriteLine(item);
            }
            
        }
    }
}