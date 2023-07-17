using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
        }
    }
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
    class Students : Person
    {
        public int Age { get; set; }
    }
    class Parents : Person 
    {
        public string ChieldName { get; set; }
    }

}
