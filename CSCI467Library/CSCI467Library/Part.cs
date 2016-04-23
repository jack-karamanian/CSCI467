using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSCI467Library {
    public class Part {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Price { get; private set; }

        public Part(int id, string name, string price) {
            ID = id;
            Name = name;
            Price = price;
        }

        public static bool operator ==(Part a, Part b) {
            return a.ID == b.ID;
        }

        public static bool operator !=(Part a, Part b) {
            return a.ID != b.ID;
        }

        public override bool Equals(object obj) {
            return ID == ((Part)obj).ID;
        }
    }
}
