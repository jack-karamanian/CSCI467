using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCI467Library;

namespace CSCI467PlaceOrder {
    public partial class Form1 : Form {
        PartsDBConnector connection;
        List<Part> allParts;
        public Form1() {
            InitializeComponent();
            connection = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
            allParts = connection.GetAllParts();
            partListBox.DataSource = allParts;
        }

        private void button1_Click(object sender, EventArgs e) {
            partListPanel.Visible = !partListPanel.Visible;
            
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e) {
            var text = searchTextBox.Text;
            if (text == string.Empty) {
                partListBox.DataSource = allParts;
            } else { 
                var byID = from part in allParts where text.Contains(part.ID.ToString()) select part;
                partListBox.DataSource = byID.ToList<Part>();
            }
        }
    }
}
