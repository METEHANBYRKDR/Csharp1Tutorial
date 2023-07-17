using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }
        public  void Remove() { Console.WriteLine("Removed"); }
        public  void Clear() { Console.WriteLine("Cleared");
        }
        public void Update() { Console.WriteLine("Updated"); }
        public void Delete() { Console.WriteLine("Deleted"); }

    }
}
