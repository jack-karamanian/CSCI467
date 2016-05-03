using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using CSCI467Library;

namespace CSCI467Library {
    class Tax {
        private MySqlDataAdapter adapter;
        private MySqlCommandBuilder builder;
        private DataTable parts;
        MySqlConnection connection;

        public double StateRate { get; set; }
        public double CountyRate { get; set; }
        public double FederalRate { get; set; }
        public double Tariff { get; set; }
    }
}
