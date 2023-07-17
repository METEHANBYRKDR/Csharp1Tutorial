using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls enter a number");
            int number = Convert.ToInt32 (Console.ReadLine());
            //switch (number)
            //{
            //    case 5:
            //        Console.WriteLine("number is 5");
            //        break;
            //     case 6:
            //        Console.WriteLine("number is 6");
            //        break;
            //    default : Console.WriteLine("number not found");
            //        break;
            //}
            //Console.ReadLine();
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("the number is between 0-100");

            }
            else if (number >= 101 &&  number <= 200)
            {
                Console.WriteLine("The number is between 100-200");
            }
            else if (number >=201 && number <= 300)
            {
                Console.WriteLine("The number is between 200-300");
            }
            else {
                Console.WriteLine("This number undefined");
            }
            Console.ReadLine();
        }
    }
}
