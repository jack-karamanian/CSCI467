using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CSCI467Library;

namespace CSCI467PlaceOrderWeb {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            var connection = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
            Repeater1.DataSource = connection.GetAllParts();
            Repeater1.DataBind();
        }
    }
}