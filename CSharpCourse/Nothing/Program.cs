using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metin giriniz");
            string metin = Console.ReadLine();
            Console.WriteLine("Arananı girin");
            string aranan = Console.ReadLine();
            if (metin.Contains(aranan))
            {
                Console.WriteLine("{0}{1}",metin,aranan);
            }
            else { Console.WriteLine("123"); }

            Console.ReadLine();
        }
    }
}
