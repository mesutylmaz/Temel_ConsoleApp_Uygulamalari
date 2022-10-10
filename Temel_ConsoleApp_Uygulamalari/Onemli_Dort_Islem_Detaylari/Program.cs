using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onemli_Dort_Islem_Detaylari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1/3=?");     //1/3=?
            Console.WriteLine(1 / 3);       //0
            Console.WriteLine(1F / 3);      //0.33333
            Console.WriteLine(1D / 3);      //0.33333333
            Console.WriteLine(1M / 3);      //0.333333333333333333333

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


            char karakter1 = 'A';
            char karakter2 = '1';
            char karakter3 = '.';
            char karakter4 = karakter1;
            Console.WriteLine(karakter1 + karakter2 + karakter3);       //160
            Console.WriteLine("karakter1" + "karakter2" + "karakter3");     //karakter1karakter2karakter3
            Console.WriteLine(" " + 'A' + "" + 'R');        // AR
            Console.WriteLine('A' + 'R' + "" + 'A' + "" + 'C');        //147AC       //Tırnak işareti gelene kadar int ifadeler olduğunu kabul edip harflerin ascii cod karşılığını toplayarak devam ediyor. Tırnak geldikten sonra harfi, olduğu gibi alıp devam ediyo.

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


            string metinselSayiDegeri = "1000,50";
            float sayisalFloatDegeri = Convert.ToSingle(metinselSayiDegeri);        //Convert.ToDouble ve Convert.ToDecimal var ancak Convert.ToFloat yoktur ve onun                                                                          yerine Convert.ToSingle kullanılır.
            Console.WriteLine("Float'a dönüştürülmüş sayı değer: " + Convert.ToString(sayisalFloatDegeri));
            Console.WriteLine("Float'a dönüştürülmüş sayı değer: " + sayisalFloatDegeri);

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");


            string girilenDeger1 = "Bilge Adam";
            string girilenDeger2 = " Boost";

            string toplam1 = girilenDeger1 + girilenDeger2;
            Console.WriteLine(toplam1);     ////metinsel ifadeler olduğundan 2'sini yanyana birleştirme yapıcak.


            string girilenDeger3 = "234242";
            string girilenDeger4 = " 5462338";

            string toplam2 = girilenDeger3 + girilenDeger4;
            Console.WriteLine(toplam2);         //metinsel ifadeler olduğundan 2'sini yanyana birleştirme yapıcak.

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");


            int c = 3;
            Console.WriteLine(c++);         //Önce işlem yapar sonra artırır. (3)
            Console.WriteLine(c);       //(4)

            int a = 6;
            a++;
            Console.WriteLine(a);       //(7)

            int b = 83;
            b++;
            Console.WriteLine(b);       //84
            Console.WriteLine(new string('*', 20));          //Önemli: 20 tane yıldız karakteri yazdırdık.

            int d = 329;
            Console.WriteLine(++d);      //(330)                   //Önce artırır sonra işlem yapar.
            Console.WriteLine(d);       //(330)

            int e = 3;
            Console.WriteLine(e++ + ++e);   //(3+5)
            Console.WriteLine(e);       //(5)

            int f = 4;
            f += f++;
            Console.WriteLine(f);   //(8)

            int g = 3;
            g = g++;
            Console.WriteLine(g);   //3

            int h = 2;
            h = h-- + (h++ * ++h);  //2+(1*3)=5
            Console.WriteLine(h);       //

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");


            string metinsel1 = "Merhaba Dünya!";
            Console.WriteLine("Metinsel 1: " + metinsel1);

            string metinsel2 = "";
            Console.WriteLine("Metinsel 2: " + metinsel2);

            string metinsel3 = string.Empty;                    //Yaz.  //boş
            Console.WriteLine("Metinsel 3: " + metinsel3);

            string metinselBool = false.ToString();                 //Yaz.  //False
            Console.WriteLine("Metinsel Bool: " + metinselBool);

            string metinselString = "abc".ToString();                   //Yaz.  //abc
            Console.WriteLine("Metinsel String: " + metinselString);

            string metinselUcret = 3.5.ToString();
            Console.WriteLine("Ucret: " + metinselUcret + " TL");

            string metinsel12 = 3 + "3";
            Console.WriteLine(metinsel12);      //33
            Console.WriteLine("Test:" + 3 * 3);     //9
            Console.WriteLine("Test" + 3 + 3);      //33

            string metinsel13 = "haVA";
            Console.WriteLine(metinsel13.ToUpper());    //HAVA
            Console.WriteLine(metinsel13.ToLower());    //hava

            metinsel13 = metinsel13 + "sız";
            Console.WriteLine(metinsel13);  //haVasız

            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------");


            double sayi1 = 106;
            double sayi2 = 14;
            double toplam = sayi1 + sayi2;
            double bölüm = sayi1 / sayi2;
            double mod = sayi1 % sayi2;

            Console.WriteLine("Toplama işlemi sonucu: " + toplam);      //120
            Console.WriteLine("Toplama işlemi sonucu: " + (sayi1 + sayi2));   //120
            Console.WriteLine("Toplama işlemi sonucu: " + sayi1 + sayi2);   //10614
            Console.WriteLine("Toplama işlemi sonucu: " + sayi1.ToString() + sayi2.ToString()); //10614

            Console.WriteLine("Toplama işlemi sonucu: " + Convert.ToString(bölüm)); //7,57
            Console.WriteLine("Toplama işlemi sonucu: " + Convert.ToDouble(bölüm)); //7,57
            Console.WriteLine("Toplama işlemi sonucu: " + Convert.ToInt32(bölüm));  //8
            Console.WriteLine("Toplama işlemi sonucu: " + bölüm);   //7,57
            Console.WriteLine("Toplama işlemi sonucu: " + Convert.ToDouble(mod));   //8

            sayi1 = sayi1 + 1;
            Console.WriteLine("Sayının yeni sonucu: " + sayi1); //107

            sayi1++;
            Console.WriteLine(Environment.NewLine + "Sayının yeni sonucu: " + sayi1); //108         

            sayi1 += 1;
            Console.WriteLine("Sayının yeni sonucu: " + sayi1);     //109

            Console.Read();
        }
    }
}
