﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSCI467Library {
    class OrderDBConnector : DBConnector {
        public OrderDBConnector(string host, int port, string username, string password, string database) : base(host, host, username, password, database) {

        }

        public Order GetOldestOrder() {
            Connection.Open();

            var command = new MySqlCommand("SELECT MIN(time_ordered) FROM `orders` ORDER BY time_ordered ASC;", Connection);
            var reader = command.ExecuteReader();

            reader.Read();
            int id = reader.GetInt32("order_num");
            var address = reader.GetString("address");
            var state = reader.GetString("state");
            var zip = Convert.ToInt32(reader.GetString("zip_code"));
            var firstName = reader.GetString("fname");
            var lastName = reader.GetString("lname");
            var time = reader.GetDateTime("time_ordered");
            var total = reader.GetFloat("total");
            var subtotal = reader.GetFloat("subtotal");

            var quantities = GetQuantities(id);

            var order = new Order(new Address(address, "", "US", zip, state), time, null, subtotal, total, new Customer(firstName + " " + lastName, null), quantities);

            Connection.Close();

            return order;
        }

        public void RemoveOldestOrder() {
            Connection.Open();

            var command = new MySqlCommand("DELETE FROM `orders` WHERE order_num = (SELECT order_num FROM `orders` WHERE time_ordered = MIN(time_ordered));", Connection);
            command.ExecuteNonQuery();

            Connection.Close();
        }

        public void AddOrder(Order order) {
            Connection.Open();

            var addCommand = new MySqlCommand("INSERT INTO orders (order_num, time_ordered, fname, lname, address, state, zip_code, total, subtotal) VALUES (NULL, @time_ordered, @fname, @lname, @address, @state, @zip_code, @total, @subtotal)", Connection);
            addCommand.Parameters.AddWithValue("@time_ordered", DateTime.Now);

            var name = order.Customer.Name.Split(' ');
            addCommand.Parameters.AddWithValue("@fname", name[0]);
            addCommand.Parameters.AddWithValue("@lname", name[1]);

            addCommand.Parameters.AddWithValue("@address", order.Destination.Line1);
            addCommand.Parameters.AddWithValue("@state", order.Destination.State);
            addCommand.Parameters.AddWithValue("@zip_code", order.Destination.ZIPCode.ToString());
            addCommand.Parameters.AddWithValue("@total", order.Total);
            addCommand.Parameters.AddWithValue("@subtotal", order.SubTotal);
            addCommand.ExecuteNonQuery();

            Connection.Close();
        }

        Dictionary<int, int> GetQuantities(int id) {
            Dictionary<int, int> partQuantities = new Dictionary<int, int>();
            var partCommand = new MySqlCommand("FROM parts_list SELECT * WHERE order_id = " + id, Connection);
            var partReader = partCommand.ExecuteReader();

            while (partReader.Read()) {
                partQuantities[partReader.GetInt32("part_id")] = partReader.GetInt32("quantity");
            }
            return partQuantities;
        }
    }
}
