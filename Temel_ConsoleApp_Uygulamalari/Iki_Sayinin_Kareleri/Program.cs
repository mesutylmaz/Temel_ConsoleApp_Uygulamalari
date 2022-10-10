using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayinin_Kareleri
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Soru 3:
            //Dışarıdan girilen 2 sayının karelerinin toplamı ile karelerinin farkının toplamı kaçtır? (Math sınıfı kullanılmayacak)

            Console.WriteLine(Environment.NewLine + "Lütfen birinci sayı değerini giriniz:");
            double sayi4;
            sayi4 = Convert.ToInt32(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Girilen birinci sayı: " + sayi4);

            Console.WriteLine(Environment.NewLine + "Lütfen ikinci sayı değerini giriniz:");
            double sayi5;
            sayi5 = Convert.ToInt32(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Girilen ikinci sayı: " + sayi5);

            double sayi4kare = sayi4 * sayi4;
            Console.WriteLine(Environment.NewLine + "Girilen birinci sayının karesi: " + sayi4kare);

            double sayi5kare = sayi5 * sayi5;
            Console.WriteLine(Environment.NewLine + "Girilen ikinci sayının karesi: " + sayi5kare);

            double karelerToplami = sayi4kare + sayi5kare;
            Console.WriteLine(Environment.NewLine + "Girilen sayıların kareleri toplamı: " + karelerToplami);

            double karelerFarki = sayi4kare - sayi5kare;
            Console.WriteLine(Environment.NewLine + "Girilen sayıların kareleri farkı: " + karelerFarki);

            double sonuc = karelerToplami + karelerFarki;
            Console.WriteLine(Environment.NewLine + "Girilen sayıların karelerinin toplamıyla farkının toplamı: " + sonuc);

            Console.Read();

            #endregion
        }
    }
}
