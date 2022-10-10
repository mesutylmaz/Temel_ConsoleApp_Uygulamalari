using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert sınıfı altında bulunan ve To ifadesi ile başlayan methotlar, Parse() metodundan farklı olarak yalnızca string değil bütün türlerin tamamından dönüştürme işlemi yapılabilir.
            //Parse() Methodu kendisine gönderilen string tipindeki veriyi istenilen veri tipine çevirmek için kullanılır.

            string deger1 = "15";       //deger1'i int'e çeviriyor. Parse, her zaman string ifadesini alır ve başka bir forma çevirir.
            int donusturulenDeger1 = int.Parse(deger1);
            Console.WriteLine(donusturulenDeger1);

            Console.Read();
        }
    }
}
