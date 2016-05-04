using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSCI467Library
{
    public class AddItemsToWareHouse
    {
        public Part selectedItem { get; set; }
        public PartsDBConnector legacy_Parts { get; set; }
        private int Amount_Instock { get; set; }

        public MySqlConnection connection;

        string host = "sql5.freemysqlhosting.net";
        int port = 3306;
        string username = "sql5117893";
        string password = "XSHuaIJZLY";

        public AddItemsToWareHouse()
        {
            if(connection != null)
            {
                connection.Close();
            }

            string connStr = String.Format("server={0};user id={1}; password={2}; database=sql5117893; port={3}",
            host, username, password, port);

            try
            {
                connection = new MySqlConnection(connStr);
                connection.Open();
            }
            catch
            {
            }
        }

        public void Add_Item(string part_id, int quantity_rec)
        {
            MySqlDataReader reader = null;
            
            MySqlCommand cmd = new MySqlCommand("select * from WareHouseItems where part_id='"+part_id+"'", connection);
            try
            {
                reader = cmd.ExecuteReader();
                if(!reader.Read())
                {
                    Amount_Instock = 0;
                    cmd = new MySqlCommand("INSERT INTO WareHouseItems (part_id,current_Total_InStock) VALUES (" + part_id + "," + Amount_Instock.ToString() + ")");                                
                }
                else
                {
                    Amount_Instock = Int32.Parse(reader["current_Total_InStock"].ToString());
                    Amount_Instock += quantity_rec;
                    cmd = new MySqlCommand("UPDATE TABLE WareHouseItems SET current_Total_InStock='" + Amount_Instock.ToString() +
                                "' WHERE part_id='" + part_id + "'", connection);
                }
            }
            catch
            {
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }

        public void Delete_RecievedInventory()
        {
            MySqlDataReader reader = null;

            MySqlCommand cmd = new MySqlCommand("DELETE FROM RecieveItems_ToBeAdded WHERE part_id != 'OoOo'", connection);
            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return;
                }
            }
            catch (MySqlException ex)
            {
            }
            finally
            {
                if (reader != null) reader.Close();
            }
        }
    }
}