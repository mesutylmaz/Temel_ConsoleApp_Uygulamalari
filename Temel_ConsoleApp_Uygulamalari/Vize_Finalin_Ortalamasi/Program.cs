using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vize_Finalin_Ortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Soru 4:
            //Dışarıdan girilen vize sınavının %40 ve final sınavının %60'ını alıp bir öğrencinin not ortalamasını hesaplayan ve ekrana yazdıran programı yazdırın.

            Console.WriteLine(Environment.NewLine + "Lütfen Öğrencinin Vize Sınav Notunu Giriniz:");
            double vize;
            vize = Convert.ToDouble(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Vize Notu: " + vize);

            Console.WriteLine(Environment.NewLine + "Lütfen Öğrencinin Final Sınav Notunu Giriniz:");
            double final;
            final = Convert.ToDouble(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Final Notu: " + final);

            double vizeNotu = vize * 0.4;
            Console.WriteLine(Environment.NewLine + "Öğrencinin Vize Notunun Etkisi: " + vizeNotu);

            double finalNotu = final * 0.6;
            Console.WriteLine(Environment.NewLine + "Öğrencinin Final Notunun Etkisi: " + finalNotu);

            double ortalama = vizeNotu + finalNotu;
            Console.WriteLine(Environment.NewLine + "Öğrencinin Not Ortalaması: " + ortalama);

            Console.Read();

            #endregion
        }
    }
}
