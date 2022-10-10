using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizinin_Elemanlarini_Siralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int gecici;

            int[] dizi = { 2, 7, 99, 15, 13, 3, 22, 42, 21 };

            Console.Write("Dizinin ilk hali: ");

            foreach (int item in dizi)
            {
                Console.Write(item + " ");
            }
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i; j < dizi.Length; j++)
                {
                    // >(büyük) işareti <(küçük ) olarak değiştirilirse büyükten küçüğe sıralanır
                    if (dizi[i] > dizi[j])
                    {
                        gecici = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = gecici;
                    }

                }

            }
            Console.WriteLine();
            Console.Write("Dizinin son hali: ");
            foreach (int item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
