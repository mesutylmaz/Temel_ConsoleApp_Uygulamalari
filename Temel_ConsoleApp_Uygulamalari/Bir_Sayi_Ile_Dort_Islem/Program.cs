using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bir_Sayi_Ile_Dort_Islem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Soru 2:
            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2 ile bölümünden kalanın karesi kaçtır?

            Console.WriteLine(Environment.NewLine + "Lütfen bir sayı değeri giriniz:");
            double sayi3;
            sayi3 = Convert.ToInt32(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Girilen sayı: " + sayi3);

            sayi3 -= 10;
            Console.WriteLine(Environment.NewLine + "Girilen sayının 10 eksiği: " + sayi3);

            sayi3 += 20;
            Console.WriteLine(Environment.NewLine + "Yeni sayının 20 fazlası: " + sayi3);

            sayi3 = sayi3 % 2;
            Console.WriteLine(Environment.NewLine + "Son sayının 2 ile bölümünden kalan: " + sayi3);

            sayi3 = sayi3 * sayi3;
            Console.WriteLine(Environment.NewLine + "Kalan sayının karesi: " + sayi3);

            Console.Read();

            #endregion
        }
    }
}
