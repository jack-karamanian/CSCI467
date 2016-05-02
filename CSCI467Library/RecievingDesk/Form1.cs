using CSCI467Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecievingDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void CheckAccpet_Click(object sender, EventArgs e)
        {
            int err = 0;
            if (Int32.TryParse(ItemRecievedCode.Text, out err)) //checks for integer input
            {
                PartsDBConnector connection = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
                Part signlePart = connection.GetPartByID(Int32.Parse(ItemRecievedCode.Text));
                PartName.Text = signlePart.Name;
                PartName.Visible = true;
            }
            else {PartName.Text = "Error, not valid part"; } //else show error
        }

        //Clears all textboxes of data
        private void Clear_Click(object sender, EventArgs e)
        {
            ItemRecievedCode.Text = "";
            Quantity.Text = "";
            PartName.Text = "";
            NumRecieved.Text = "";
            PartName.Visible = false;
        }
    }
}
