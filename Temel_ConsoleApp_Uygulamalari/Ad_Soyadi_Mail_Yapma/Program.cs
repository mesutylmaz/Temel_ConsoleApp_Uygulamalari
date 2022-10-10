using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ad_Soyadi_Mail_Yapma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion
            //Soru 5:
            //Dışarıdan girilen kullanıcı adı ve soyadını ayrı ayrı alınız ve adi.soyadi.@mail.com şeklinde mail adresini oluşturup kullanıcıya gösteren programı yazınız.


            Console.WriteLine(Environment.NewLine + "Lütfen Kullanıcı Adını Giriniz:");
            string kullaniciAdi;
            kullaniciAdi = Convert.ToString(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Kullanıcı Adı: " + kullaniciAdi);

            Console.WriteLine(Environment.NewLine + "Lütfen Kullanıcı Soyadını Giriniz:");
            string kullaniciSoyadi;
            kullaniciSoyadi = Convert.ToString(Environment.NewLine + Console.ReadLine());
            Console.WriteLine(Environment.NewLine + "Kullanıcı soyadı: " + kullaniciSoyadi);

            string mailAdresiOlustur = (Convert.ToString(kullaniciAdi) + "." + Convert.ToString(kullaniciSoyadi) + "@mail.com");
            Console.WriteLine(Environment.NewLine + "Kullanıcı Mail Adresi: " + mailAdresiOlustur);

            Console.Read();

            #endregion
        }
    }
}
