using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degiskenlerle_Ilgili_Bilgiler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Değişkenler: Uygulamada çalışırken bazı önemli verilerimizi kaydetmemizi ve daha sonra kullanabilmemizi sağlarlar.
             * Program çalıştığında bellek üzerinde veriler tanımlanır ve değişkenler ile bunları kullanabilir yada değiştirebiliriz.
             * Değişkenleri tanımlarken ne tipte olacağını belirtmeliyiz.
             * Veri Tipleri değişkenlerin tuttuğu değerlerin türünü ve bellekte tutulacak boyutunu tanımlar.
             * Bazı temel veri tipleri tamsayısal, ondalıksal, metinsel ve mantıksal veri tipleridir.
             * Bu verilerle işlem yaparken en çok ihtiyaç duyulacak özelliklerden biri operatörlerdir.
             * Operatörler sayesinde matematiksel işlemleri gerçekleştirebilir, mantıksal ve ilişkisel işlemleri tanımlandırabiliriz.
             * Örneğin toplama(+), çıkarma(-), çarpma(*) ve bölme(/) temel matematiksel operatörlerdir.
             *         Ve(&&), Veya(||), Değil(!) operatörleri ise temel mantıksal operatörlerdir.
             *         Büyük(>), Küçük(<), Eşit(=) gibi operatörler temel ilişkisel operatörlerdir.
             */


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            // Sayısal Veri Tipleri; 

            /*byte = Boyutu(8 Bit)-Değer aralığı (0'dan 255'e kadardır.)
            * sbyte = Boyutu(8 Bit)-Değer aralığı (-128'den 127'ye kadardır.)
            * short = Boyutu(16 Bit)-Değer aralığı (-35,768'den 32.767'ye kadardır.)
            * ushort = Boyutu(16 Bit)-Değer aralığı(0'dan 65.535'e kadardır.)
            * int = Boyutu(32 Bit)-Değer aralığı(-2.147.483.648'den 2.147.483.647'ye kadardır.)
            * uint = Boyutu(32 Bit)-Değer aralığı(0'dan 4.294.967.295'e kadardır.)
            * long = Boyutu(64 Bit)-Değer aralığı(-9.223.372.036.854.775.808'den 9.223.372.036.854.775.807'ye kadardır.)
            * ulong = Boyutu(64 Bit)-Değer aralığı(0'dan 18.446.744.073.709.551.615'e kadardır.)
            */


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            // Metinsel Veri Tipleri;

            // char = Boyutu(16 Bit)-Değer aralığı(Tek bir karakter tutar.)

            // string = Boyutu(sınırsız)-Değer aralığı(Sınırsız metin tutar.)


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            // Ondalıklı Veri Tipleri;

            // float = Boyutu(32 Bit)-Değer aralığı(Pozitif ve negatif yönde olmak üzere 1.5E-45 ile 3.4E+38 arasında değer alır. (e-45 ve e38 ifadeleri 10 üzeri anlamındadır.))

            // double = Boyutu(64 Bit)-Değer aralığı(Pozitif ve negatif yönde olmak üzere 5E-324 ile 1.7E+308 arasında değer alır. (5E-324 ve 1.7E+308 ifadeleri 10 üzeri anlamındadır.))

            //decimal = Boyutu(128 Bit)-Değer aralığı(Pozitif ve negatif yönde olmak üzere 1E-28 ile 7.9E+28 arasında değer alır. (1E-28 ve 7.9E+28 ifadeleri 10 üzeri anlamındadır.))


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            // Mantıksal Veri Tipi;

            // bool = Boyutu(1 Bit)-Değer aralığı(true/false)


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            // Veriler değişkende saklanırken metinsel ifadeler küçük harfla yazılmaya başlanır. 1'den fazla kelime varsa 2. kelimenin İlk harfi büyük gerisi küçük olacak şekilde devam edilir.

            // Ondalıklı sayıları programda kodlarken araya virgül değil nokta koyulur. Ancak program çalıştığında virgül yazılır.


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            byte örnek1 = 3453;         // Hata verdi çünkü byte içine 0 ile 255 aralığındaki sayılar yazılabilir.
            string örnek2 = 2342342;        // Hata verdi çünkü string bir metinsel ifadedir. Sayısal verileri yazamayız.
            string örnek3 = "ADI Soyadi";    //Metinsel ifade olduğundan sınırsız harf yazılabilir ancak çift tınak içinde olmalı. Tırnak içinde istenildiği gibi yazılabilir.
            double örnek4 = 23424;          //Ondalıklı sayılar tamsayıları kapsadığından hata vermedi.
            double örnek5 = 234212.52; //Ondalıklı kısım nokta ile yazılır.
            char örnek6 = 'a';      //Tek bir harfi saklar. Tek tırnak arasına yazılır.
            char örnek7 = 'sd';     //1'den fazla harf olduğundan hata verdi.
            int örnek8 = 3242;      //Sayısal veri olduğundan ve sınırlar aralığında olduğundan hata vermedi.
            int örnek9 = 323.3;     //Ondalıklı sayı yazıldığından ve integer'ın tamsayıları kapsamasından ötürü hata verdi.
            bool örnek10 = var;      //Bool ifadesi sadece true yada false olabilir. Harici herşeyde hata vericektir.
            bool örnek11 = false;   //Görüldüğü gibi hata vermedi.


            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");


            // Aşağıda görüldüğü gibi 3 sayı da ondalıklı ve tanım aralıkları içinde olmasına rağmen double'da hata vermezken float ve decimal'ın hata verdiğini görüyoruz.
            // Bunun sebebi, aksi belirtilmedikçe ondalıklı sayıların hepsinin double olarak tanımlı olmasındandır. Bu sorunu çözmek için yanlarındaki gibi yazılarak sorunlar düzeltilmelidir.

            float örnek12 = 25.365;         //25.365f;
            double örnek13 = 25.235;        //25.235d;
            decimal örnek14 = 25.215;       //25.215m;

            Console.Read();
        }
    }
}
