using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Islemi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting İşlemi: Bir rica işlemidir. 
            //Value type işlemlerde istenilen dönüşümü yaparken dönüştürebildiği kadarını dönüştürerek işlemi gerçekleştirir.
            //References Type işlemlerinde ise dönüştürülmek istenen Nesneyi istenilen nesneye dönüştürmeyi dener.

            int deger2 = 1000;      //deger2 yi byte dönüştürmek istiyoruz ancak byte int'ten daha dar aralık olduğundan 1000'i çeviremez.
            byte donusturulenDeger2 = (byte)deger2;
            Console.WriteLine(donusturulenDeger2);

            Console.Read();
        }
    }
}
