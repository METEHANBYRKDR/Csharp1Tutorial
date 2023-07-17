using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Remove();
            customerManager.Delete();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Remove();
            productManager.Update();
            productManager.Delete();
            Console.ReadLine();
        }
        class CustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Added");
            }
            public void Remove() { Console.WriteLine("Removed"); }
            public void Delete() { Console.WriteLine("Deleted"); }
            public void Update() { Console.WriteLine("Updated"); }

        }
    }
}
