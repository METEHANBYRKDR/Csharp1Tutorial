using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDeneme2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Son son = new Son(new Bayrakdar());
            son.Work();
            Console.ReadKey();

        }
    }
    
}
