using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringFormat();
            //StringConcat();
            //StringMethods(Cumle);
            
            string Cumle = "My name is Metehan Bayrakdar";
            string Cumle2 = "Blabalba";

            string result = string.Concat(Cumle, Cumle2);


            Console.ReadLine();

        }

        private static void StringMethods(string Cumle)
        {
            var resul = Cumle.Replace(" ", "-"); // cümle içindeki boşlukları - ile değiştirdi
            var resul2 = Cumle.Length; // uzunluğu verir

            var resul3 = Cumle.Clone(); // Cumle nin bir klonunu oluşturuyo başka referans oluşur

            bool resul4 = Cumle.EndsWith("ğ"); // ğ ile biten kelime varmı
            bool resul5 = Cumle.StartsWith("My name"); // My name ile başlayan 

            var resul6 = Cumle.ToLower();
            var resul7 = Cumle.ToUpper();

            var resul8 = Cumle.IndexOf("name"); // nerede oldugunu bulur
            var resul9 = Cumle.LastIndexOf("dar"); //sondan başlar nerde oldugunu bulur

            var resul10 = Cumle.Substring(3); // 3.indexten oncekileri hepsini keser ne kadar kesiceigini belirtebilirsin cumle.Substring(3,4);
            var resul11 = Cumle.Insert(0, "Hi ,"); // 0. indexe ekler
            var resul12 = Cumle.Remove(3, 5); //   belirtilen yeri keser

            Console.WriteLine(resul12);
        }

        private static void StringConcat()
        {
            string firstName = "MT ";
            string lastName = "Bayrakdar";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);
        }

        private static void StringFormat()
        {
            //String.Format birden fazla stringi toplar 
            string city = "Ankara";
            Console.WriteLine(city[0]);

            string city2 = "İstanbul";
            string city3 = "armut";

            string strformat = String.Format("{0} {1} {2}", city, city2, city3);
            Console.WriteLine(strformat);

            string name = "MT";
            // format string
            string strFormat = String.Format("Hello {0}", name);
            Console.WriteLine(strFormat);

            string strFormat1 = String.Format("{0, -20} {1, -14}", "MT", "Bayrakdar");
            Console.WriteLine(strFormat1);
        }
    }
}
