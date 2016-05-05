using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCI467Library;

namespace RecievingDesk.Panels
{
    public partial class AddItemToWarehouse : UserControl
    {
        DBConnector conn = new DBConnector("blitz.cs.niu.edu", 3306, "student", "student", "csci467");
        PartsDBConnector parts = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");

        public AddItemToWarehouse()
        {
            InitializeComponent();
            PartsDBConnector parts = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
            this.dataGrid.DataSource = parts.GetAllParts();
        }

        private void AddItemUpdate_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to update?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                // Update Table
                AddItemToWareHouse_Panel.Visible = false;
                // Employee Tools Panel true
            }
        }

        private void AddItemCancel_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to cancel?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                AddItemToWareHouse_Panel.Visible = false;
                // Employee Tools Panel true
            }
        }
    }
}
