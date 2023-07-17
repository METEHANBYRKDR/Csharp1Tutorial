using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogumTarihi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* doğum tarihinin ikinci rakamı gir
            doğduğun saatteki  rakamları topla
            doğduğun saatteki  rakamları topla
            hangi ayda doğduğunu gir
            ismin kaç harfli 
            hepsini topla kader belirle
             
             
             */
            Console.WriteLine("Hi" +"                   "+"Do u want to know ur fade");
            Console.ReadLine();
            Console.WriteLine("Enter the second digit of the date of birth");
            int dogum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Collect the numbers from the time you were born");
            int saat = Convert.ToInt32(Console.ReadLine());
            int toplam = saat + dogum;
            if (toplam >= 10 && toplam <= 20)
            {
                Console.WriteLine("Good luck");
            }
            else if (toplam >= 21 &&  toplam <= 30) 
            {
                Console.WriteLine("Bad luck");
            }
            else { Console.WriteLine("Very bad luck");
            }
            Console.ReadLine ();



        }
    }
}
