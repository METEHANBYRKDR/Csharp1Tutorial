using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // add();        // deger dondurmeyen basıc parametresız
            //int Adc = add2(1,6); parametresız gerı deger donduren
            //if (Adc <=10 ) 
            //{
            //    Console.WriteLine("10 dan kucuk");

            //}
            //else
            //{
            //    Console.WriteLine("10 dan buyuk");
            //}
            //Console.ReadLine();


            //int Adcb = add3(4);
            //Console.WriteLine(Adcb);


            //int x = 6;        ref parametreli geri değer dönen
            //int y = 4;
            //var result2 = add4(ref x,ref y);
            //Console.WriteLine(result2);
            //Console.ReadLine() ;





            //Console.WriteLine(add5(1, 2, 3, 4, 5, 6, 7));
            //Console.ReadLine();



        }

        
        }

        static void add()
        {
            Console.WriteLine("Added");
        }
        public static int add2(int x,int y) 
        {
            var result = x + y;
            return result;
        }
        public static int add3(int x, int y = 20)
        {
            var result = x + y;
            return result;
        }
        public static int add4(ref int x,ref int y) 
        {
            var result = x + y;
            return result;
        }
        public static int add5(params int[] x)
        {
            return x.Sum();
        }
    }
}
