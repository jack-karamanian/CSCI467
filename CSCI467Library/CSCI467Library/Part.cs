using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {
    public class Part {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }

        public Part(int id, string name, string price) {
            ID = id;
            Name = name;
            Price = price;
        }

        public Part() {
            ID = -1;
            Name = "";
            Price = "";
        }
    }
}
