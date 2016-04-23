using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSCI467Library;

namespace CSCI467Test {
    class Program {
        static void Main(string[] args) {
            PartsDBConnector connector = new PartsDBConnector("blitz.cs.niu.edu", 3306, "student", "student");
            var parts = connector.GetAllParts();
            foreach (var part in parts) {
                Console.WriteLine(part.ID);
                Console.WriteLine(part.Name);
                Console.WriteLine(part.Price);
                Console.WriteLine("---------------");
                
            }
            Console.ReadLine();

            var part1 = connector.GetPartByID(3);
            Console.WriteLine(part1.ID);
            Console.WriteLine(part1.Name);
            Console.WriteLine(part1.Price);
            Console.WriteLine("---------------");

            Console.ReadLine();
        }
    }
}
