using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(21);
            customerManager.List();
            Product product = new Product { Id = 1 , Name = "MT"};
            Product product2 = new Product(2, "MT1");

            Talent.Validate();
            Upgrade.Update();
            Upgrade upgrade = new Upgrade();
            upgrade.Update1();




            Console.ReadLine();
        }
    }
    // iki adet constructor CustomerManager olmasının sebebi overload edebiliyoruz eğer değer almassa default olarak 15 değeri dönücek
    // eğer yukarıya değer girersek istenen degeri döndürücek





    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public CustomerManager()
        {

        }
        public void List()
        {
            Console.WriteLine("Listed {0} items ", _count);

        }

    }
    class Product
    {
        public Product()
        {
            
        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;

            _name = name;

        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
    static class Talent
    {
        public static void Validate()
        {
            Console.WriteLine("Validated");
        }

    }
    class Upgrade
    {
        public static void Update()
        {
            Console.WriteLine("Updated");
        }
        internal void Update1()
        {
            Console.WriteLine("Updated1");
        }
  }
}
