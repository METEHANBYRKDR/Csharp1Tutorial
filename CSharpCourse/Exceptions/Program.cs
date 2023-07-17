using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntroTRYCATCH();

            try
            {
                Find();

            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            HandleException(() =>
            {
                Find();
            });


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        private static void Find()
        {
            List<String> students = new List<string>
            {
                "Mete","Emirhan","Gizem"

            };
            if (!students.Contains("İshak"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found!");
            }
        }

        private static void ExceptionIntroTRYCATCH()
        {
            try
            {
                string[] Names = new string[3] { "METE", "EMIR", "GIZEM" };
                Names[3] = "Ali";

            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);

            }
            catch (IndexOutOfRangeException exception)
            {                                                       // kodların acıklaması eğer yukardaki try blogu calısmazsa catch bloklarını calıstır
                                                                    // birinci catch blogu hatamız ile alakasız oldugundan ikinci catch bloğuna atlar
                                                                    // hatanın problemi range in üzerine deger girdigimizden indexoutofrange hatası alırız ve blok calısır sondaki bloga gitmez
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception!! HATA VAR");
                Console.WriteLine(exception.Message);                // hatayı mesaja döker
                Console.WriteLine(exception.InnerException);         // hatanın alt bilgileri varsa onları gösterir
            }
        }
    }
}
