using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using CSCI467PlaceOrderMVC.Models;
using CSCI467Library;


namespace CSCI467PlaceOrderMVC {
    public class TaxDBConnector : DBConnector {
        public TaxDBConnector(string host, int port, string username, string password, string database) : base(host, port, username, password, database) {

        }

        public List<TaxShippingModel> GetAllTaxInfo() {
            List<TaxShippingModel> taxes = new List<TaxShippingModel>();

            // Get all states
            Connection.Open();
            var stateCommand = new MySqlCommand("SELECT * FROM `tax`;", Connection);
            var reader = stateCommand.ExecuteReader();

            while (reader.Read()) {
                var tax = new TaxShippingModel { State = reader.GetString("state"), ZIP = reader.GetInt32("zip_code"), Tax = reader.GetFloat("tax_percent"), Shipping = reader.GetFloat("shipping_percent") };
                taxes.Add(tax);

            }

            Connection.Close();

            return taxes;
        }
        
    }
}