using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3];
            //students[0] = "METE";
            //students[1] = "GIZEM";
            //students[2] = "EMIR";

            //string[] students2 = new[] { "Mete","Gizem","Emir" };

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine();
            //Console.ReadLine();




            //string[,] x = new string[5,3]
            //{
            //    {"a","b","c"},
            //    {"d","e","f"},
            //    {"q","w","r"},
            //    {"t","y","u"},
            //    {"k","l","m"},


            //};
            //for (int i = 0; i <= x.GetUpperBound(0); i++)
            //{
            //    for (int b = 0; b <= x.GetUpperBound(1); b++)
            //    {
            //        Console.WriteLine(x[i,b]);
            //    }
            //    Console.WriteLine("*****************");
            //}
            //Console.ReadLine();



            int[] numbers = new[] {1,2,3,4,5};
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }

    }
}
