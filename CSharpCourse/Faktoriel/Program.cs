using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faktoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
        }

        public static int Fak(ref int sayi)
        {
            int faktoriel = 1;
            for (int i = 1; i<= sayi; i++)
            {
                faktoriel *= i;
            }
            return sayi;

        }


    }
}
