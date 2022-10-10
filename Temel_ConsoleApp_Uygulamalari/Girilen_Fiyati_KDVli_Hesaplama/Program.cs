using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen_Fiyati_KDVli_Hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.NewLine + "Lütfen hesaplamak istediğiniz fiyat tutarını giriniz:");
            Double fiyat, kdvli;
            fiyat = Convert.ToDouble(Console.ReadLine());

            kdvli = fiyat * 1.18;
            Console.Write(Environment.NewLine + "Girdiğiniz fiyatın KDV'li tutarı:" + kdvli.ToString() + " TL");

            Console.ReadLine();
        }
    }
}
