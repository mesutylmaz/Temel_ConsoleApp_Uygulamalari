using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotla_Merhaba_Yazdirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya");         // Line'ları silmezsek satırları aşağıya atıcak şekilde yazdırır. 
            Console.WriteLine("Lütfen Enter'a basınız: ");          // Enter'a basınca Hello World'ü de yazdırıyor.
            Console.ReadLine();

            EkranaYaz();
        }

        static void EkranaYaz()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
