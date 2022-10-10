using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplamin_Farka_Bolumunden_Kalani_Bulma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            // Soru 1:
            //Dışarıdan alınan 2 sayının toplamıyla farkının birbirine bölümünden kalanın sonucunu ekrana yazdıran programı yazınız.(Farkın toplama bölümünden kalan kaçtır?)

            Console.WriteLine(Environment.NewLine + "Lütfen büyük sayıyı giriniz:");
            double sayi1;
            sayi1 = Convert.ToInt32(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Girilen birinci sayı: " + sayi1);

            Console.WriteLine(Environment.NewLine + "Lütfen küçük sayıyı giriniz:");
            double sayi2;
            sayi2 = Convert.ToInt32(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Girilen ikinci sayı: " + sayi2);

            double toplam = sayi1 + sayi2;
            Console.WriteLine(Environment.NewLine + "Girilen sayıların toplamları: " + toplam);

            double fark = sayi1 - sayi2;
            Console.WriteLine(Environment.NewLine + "Girilen sayıların farkı: " + fark);

            double kalan = toplam % fark;
            Console.WriteLine(Environment.NewLine + "Girilen sayıların toplamlarının farklarına bölümünden kalan: " + kalan);

            Console.Read();

            #endregion
        }
    }
}
