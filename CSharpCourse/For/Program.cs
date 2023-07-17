using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();

            //int a = 10;
            //do {
            //    Console.WriteLine(a);
            //    a--;
            //} while (a >=150);
            //Console.ReadKey();


            int a = 1;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j <= 100; j++) ;

            }




        }

        private static void WhileLoop()
        {
            int a = 100;
            while (a >= 0)
            {
                Console.WriteLine(a);
                a -= 2;
            }
            Console.WriteLine("Now ur number is {0}", a);
        }

        private static void ForLoop()
        {
            int a = 1;
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
