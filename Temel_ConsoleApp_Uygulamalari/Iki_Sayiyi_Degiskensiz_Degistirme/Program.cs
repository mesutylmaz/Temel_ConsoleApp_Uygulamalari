using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayiyi_Degiskensiz_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.WriteLine(Environment.NewLine + "Birinci sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Girilen birinci sayı: " + sayi1);
            Console.WriteLine(Environment.NewLine + "Girilen ikinci sayı: " + sayi2.ToString());

            sayi1 = sayi1 + sayi2;
            sayi2 = sayi1 - sayi2;
            sayi1 = sayi1 - sayi2;

            Console.WriteLine(Environment.NewLine + "Yeni birinci sayı: " + sayi1);
            Console.WriteLine(Environment.NewLine + "Yeni ikinci sayı: " + sayi2.ToString());

            Console.Read();
        }
    }
}
