using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // ForeachLoop();


            Console.ReadLine();
        }

        private static void ForeachLoop()
        {
            string[] students = new string[] { "mete", "ali", "emir" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
