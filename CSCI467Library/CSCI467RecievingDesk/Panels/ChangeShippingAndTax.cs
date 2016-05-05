using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql;
using MySql.Data.MySqlClient;
using CSCI467Library;

namespace RecievingDesk.Panels
{
    public partial class ChangeShippingAndTax : UserControl
    {
        DBConnector conn = new DBConnector("sql5.freemysqlhosting.net", 3306, "sql5117893", "XSHuaIJZLY", "sql5117893");

        public ChangeShippingAndTax()
        {
            InitializeComponent();
        }

        private void CancelST_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to cancel?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                CSTP.Visible = false;
                //                AdminController.ScrollStateHScrollVisible = true;
            }

        }

        private void CSTPUpdate_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to update?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
  
            }
        }

    }
}
