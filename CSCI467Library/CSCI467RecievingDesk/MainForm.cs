using CSCI467Library;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AutoPartsSystem
{
    public partial class MainForm : Form
    {
        DBConnector conn = new DBConnector("sql5.freemysqlhosting.net", 3306, "sql5117893", "XSHuaIJZLY", "sql5117893");

        public MainForm()
        {
            InitializeComponent();
            LoginPage.Visible = true;
        }

        private void LOGIN_UIbutton_Click(object sender, EventArgs e)
        {
            LoginDBConnector verifier = new LoginDBConnector("sql5.freemysqlhosting.net", 3306, "sql5117893", "XSHuaIJZLY", "sql5117893");
            if (verifier.Is_Admin(ID_entry.Text, PW_entry.Text))
            {
                Invalid_IDPW.Visible = false;
                LoginPage.Visible = false;
                AdminPanel.Visible = true;
            }
            else if (verifier.Is_Employee(ID_entry.Text, PW_entry.Text))
            {
                Invalid_IDPW.Visible = false;
                LoginPage.Visible = false;
                EmployeeToolsPanel.Visible = true;
            }
            else
            {
                Invalid_IDPW.Visible = true;
            }
        }

        private void CSTP_UIbutton_Click(object sender, EventArgs e)
        {
            AdminPanel.Visible = false;
            CSTP.Visible = true;
        }

        private void AdminLOGOFF_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                AdminPanel.Visible = false;
                LoginPage.Visible = true;
            }
        }
        private void EmployeeLOGOFF_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                EmployeeToolsPanel.Visible = false;
                LoginPage.Visible = true;
            }
        }

        private void AddItemToWarehouse_UIbutton_Click(object sender, EventArgs e)
        {
            EmployeeToolsPanel.Visible = false;
            // Add item to warehouse true
        }

        private void FulfillOrderButton_Click(object sender, EventArgs e)
        {
            //EmployeeToolsPanel.Visible = false;

            int processInt;

            CSCI467FulfillOrder.Program   pb = new CSCI467FulfillOrder.Program();
            //(pb.returnPath() + "/CSCI467FulfillOrder.exe");
            processInt = pb.runFulfillOrder();
            // Fullfil Order true
            if(processInt == 0)
            {
                MessageBox.Show("All reports printed.", "Success!");
            }
        }

        private void CancelST_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to cancel?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                CSTP.Visible = false;
                AdminPanel.Visible = true;
            }

        }

        private void CSTPUpdate_Click(object sender, EventArgs e)
        {



            DialogResult check = MessageBox.Show("Are you sure you want to update?", "Warning!", MessageBoxButtons.YesNo);
            if (check == DialogResult.Yes)
            {
                if (TaxValue.Text == null ||
                    ShippingCostTextBox.Text == null ||
                        ShippingCostTextBox.Text == null ||
                            TaxValue.Text == null)
                {
                    MessageBox .Show("Not all fields are filled!", "Error!");
                }
                else
                {

                    try
                    {
                        conn.Connection.Open();
                        var command = new MySqlCommand("SELECT * from `tax` where zip_code= @zips", conn.Connection);
                        command.Parameters.AddWithValue("@zips", Int32.Parse(ZIPTextBox.Text));
                        var reader = command.ExecuteReader();

                        reader.Read();
                        conn.Connection.Close();

                        // Update Tax Table
                        conn.Connection.Open();

                        var addCommand = new MySqlCommand("UPDATE `tax` SET `state`=@states,`zip_code`=@zips,`tax_percent`=@taxs,`shipping_percent`=@ships WHERE zip_code = @zips", conn.Connection);

                        addCommand.Parameters.AddWithValue("@states", StateTextBox.Text);
                        addCommand.Parameters.AddWithValue("@zips", ZIPTextBox.Text);

                        addCommand.Parameters.AddWithValue("@taxs", Int32.Parse(Convert.ToString(TaxPercent.Text)));
                        addCommand.Parameters.AddWithValue("@ships", Int32.Parse(Convert.ToString(ShippingCostTextBox.Text)));

                        addCommand.ExecuteNonQuery();

                        conn.Connection.Close();
                    }
                    catch
                    {
                        // Update Tax Table
                        conn.Connection.Open();

                        var addCommand = new MySqlCommand("INSERT INTO tax (`state`,`zip_code`,`tax_percent`,`shipping_percent`) VALUES (@states,@zips,@taxs,@ships)", conn.Connection);

                        addCommand.Parameters.AddWithValue("@states", StateTextBox.Text);
                        addCommand.Parameters.AddWithValue("@zips", ZIPTextBox.Text);

                        addCommand.Parameters.AddWithValue("@taxs", Int32.Parse(Convert.ToString(TaxPercent.Text)));
                        addCommand.Parameters.AddWithValue("@ships", Int32.Parse(Convert.ToString(ShippingCostTextBox.Text)));

                        addCommand.ExecuteNonQuery();

                        conn.Connection.Close();
                    }

                    CSTP.Visible = false;
                    AdminPanel.Visible = true;
                }
            }
        }
    }
}
