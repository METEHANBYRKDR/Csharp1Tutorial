using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
    // private>protected>internal> public
    // private ve protected farkı protected verilen değişkeni inheritance boyutuna taşır ve miras alınan classın içerisinde kullanabilirsin 
    // internal projenin içerisinde referans ihtiyacı duymadan kullanılabilir classlar default olarak internaldir
    class Customer
    {
        private int Id { get; set; }
        protected int Id2 { get; set; }

        public void Save()
        {

        }

    }
    class Student:Customer
    {
        public new void Save()
        {
            
        }

    }
    class Course
    {
        public int Id3 { get; set; }
        private class NestedClass
        {
            private void IciceClass(int id)
            {

            }
        }
    }
}
