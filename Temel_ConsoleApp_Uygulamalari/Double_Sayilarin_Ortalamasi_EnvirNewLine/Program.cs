using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Sayilarin_Ortalamasi_EnvirNewLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1, sayi2, sayi3, sayi4, sayi5;
            double ortalama;

            Console.WriteLine(Environment.NewLine + "Lütfen hesaplanacak birinci sayıyı yazınız:");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Lütfen hesaplanacak ikinci sayıyı yazınız:");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Lütfen hesaplanacak üçüncü sayıyı yazınız:");
            sayi3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Lütfen hesaplanacak dördüncü sayıyı yazınız:");
            sayi4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Environment.NewLine + "Lütfen hesaplanacak beşinci sayıyı yazınız:");
            sayi5 = Convert.ToDouble(Console.ReadLine());

            ortalama = ((sayi1 + sayi2 + sayi3 + sayi4 + sayi5) / 5);


            Console.WriteLine(Environment.NewLine + "Girdiğiniz 5 sayının ortalaması:" + ortalama.ToString());

            Console.Read();
        }
    }
}
