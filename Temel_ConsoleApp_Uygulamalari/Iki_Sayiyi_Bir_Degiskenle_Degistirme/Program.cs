using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Sayiyi_Bir_Degiskenle_Degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sayi3;

            Console.WriteLine(Environment.NewLine + "Lütfen birinci sayıyı giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Lütfen ikinci sayıyı giriniz:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            sayi3 = sayi1;
            sayi1 = sayi2;
            sayi2 = sayi3;

            Console.WriteLine(Environment.NewLine + "Yeni birinci sayı:" + sayi1.ToString());
            Console.WriteLine(Environment.NewLine + "Yeni ikinci sayı:" + sayi2.ToString());

            Console.Read();
        }
    }
}
