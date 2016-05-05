using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecievingDesk.Panels
{
    public partial class EmployeeTools : UserControl
    {
        public EmployeeTools()
        {
            InitializeComponent();
        }

        private void LOGOFF_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                EmployeeToolsPanel.Visible = false;
                //Login panel true
            }
        }

        private void AddItemToWarehouse_UIbutton_Click(object sender, EventArgs e)
        {
            EmployeeToolsPanel.Visible = false;
            // Add item to warehouse true
        }

        private void FullfillOrderButton_Click(object sender, EventArgs e)
        {
            EmployeeToolsPanel.Visible = false;
            // Fullfil Order true
        }

        private void FullfillOrderButton_Click_1(object sender, EventArgs e)
        {
            // Fullfill order to true
        }
    }
}
