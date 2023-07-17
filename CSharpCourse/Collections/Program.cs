using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //Generic Collection Tip Güvenli
            //List();
            //Dictionary();

            Console.ReadLine();


        }

        private static void Dictionary()
        {
            Dictionary<String, String> dictionary = new Dictionary<string, string>();
            dictionary.Add("Metehan", "Bayrakdar");
            dictionary.Add("Emirhan", "Bayrakdar1");
            dictionary.Add("Gizem", "Bayrakdar2");


            foreach (var item in dictionary)
            {
                Console.WriteLine(item);

                Console.WriteLine(item.Key);

                Console.WriteLine(item.Value);


            }
            Console.WriteLine(dictionary.ContainsKey("İshak"));
            Console.WriteLine(dictionary.ContainsKey("Metehan"));


            Console.WriteLine(dictionary.ContainsValue("Bayrakdar1"));
            Console.WriteLine(dictionary.ContainsValue("Bayrakdar12321312"));
        }

        private static void List()
        {
            List<String> Cities = new List<String>();
            Cities.Add("Ankara");
            Cities.Add("İstanbul");
            Cities.Contains("Ankara");   /// Contains içerisnde bulunuyormu olarak sorulur aşşağıda birbaşka örneği var bak!!
            foreach (var city in Cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, Name = "MT" });
            //customers.Add(new Customer { Id = 2, Name = "MTB" });

            List<Customer> customers = new List<Customer>
            {
               new Customer{Id=1,Name="Mete"},
               new Customer{Id=2,Name="İshak"}
            };

            var customer3 = new Customer { Id = 6, Name = "Silinecek" };

            var customer2 = new Customer { Id = 3, Name = "Emirhan" };

            customers.Add(customer2); // ekleme metodu
            customers.AddRange(new Customer[2]{  //Yeni veri geldiginde listeye sonradan eklemek için kullanılır
                new Customer { Id=4,Name="Gizem"},
                new Customer { Id = 5, Name = "Havva" }

            });
            // customers.Clear(); //Listenin elemanlarını siler
            customers.Add(customer3);
            customers.Add(customer3);
            customers.Add(customer3);

            Console.WriteLine(customers.Contains(customer2)); //Contains örnek2 ekledigimiz customer 2 ifadesi true döndürür fakat new Customer{Id = 1,Name = "Mete"}; ifadesini False döndürür



            var index = customers.IndexOf(customer2); //Elemanın kaçıncı ındexte oldugunu gösterir  0 dan başlar
            Console.WriteLine("Index {0}", index);
            customers.Add(customer2);

            var lastIndex = customers.LastIndexOf(customer2);
            Console.WriteLine("Son index {0}", lastIndex);

            customers.Insert(0, customer2);


            customers.Remove(customer2);
            //customers.Remove(customer2);
            //customers.Remove(customer2);

            customers.RemoveAll(c => c.Name == "Silinecek");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }

            var count = customers.Count(); // Kaç elemanlı olduğunu gösterir 

            Console.WriteLine("Count: {0}", count);
        }

        private static void ArrayList()
        {
            ArrayList Cities = new ArrayList();
            Cities.Add("Ankara");
            Cities.Add("Adana");
            Cities.Add(1);
            Cities.Add('B');
            Cities.Add(2.5);
            foreach (var city in Cities)
            {
                Console.WriteLine(city);
            }
        }
    }
    class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
