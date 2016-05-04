using System;
using MySql.Data.MySqlClient;
using System.Data;

namespace CSCI467Library
{
    public class AddItemsToWareHouse
    {
        public Part selectedItem { get; set; }
        public PartsDBConnector legacy_Parts { get; set; }

    }
}