using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var number = 10;
            if (number != 10)
            {
                Console.WriteLine("Yanlış");
            }
            else
            {
                Console.WriteLine("Doğru");


            }
            Console.ReadLine();*/
            /*var number = 11;
            Console.WriteLine(number==10 ? "numara dogru" : " numara yanlış");
            Console.ReadLine(); //SingleLineIf//
            */
            var number = 2;
            if (number == 1)
            {
                Console.WriteLine("1");

            }
            else if (number == 2)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
            Console.ReadLine();
        }
    }
}
