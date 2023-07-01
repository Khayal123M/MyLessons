using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dersler.Dersler.Constructor;

namespace Dersler.Dersler
{
    internal class Deconstruct
    {

        // Deconsruct nedir?

        //Bir sinifinizin icerisindeki onlarca propertyden istediginiz belli basli oropertyleri secerek hizli bir analiz yapmanizi saglayacak bir ozelliktir.

        // Deconstruct tek ozel sinif elemanidirki Clasimizla ayni isimde olmaz ve bir fonksiondur: ismi: "Denonstruct" olmalidir mutlaka

        //Geri donus degeri dondurmez   mutlaka " void " ile isaretlenmelidir.Constructor ve Distructorda geri donus tanimlamasi olmaz ama

        // Mutlaka disardan erisilebilir yani " public " olmasi gerekmekte

        // Disariya deger tasiyaca olmalarindan dolayi parantez icerisindeki elemanlarim ( out ) keywordu kullanilmalidir.

        //Cok onemli bir fonksion degildir.AYni islemleri Classdan referans olusturarak . ile bu propertyleri cagiripda yapa biliriz.Olursada olur olmazsada olmaz

        // Kodu daha temiz daha sik hale getirmek icin kullanila bilir bir fonksiondur

        //Bir sinif icerisinde Deconstruct ismiyle tanimlanan metot,compiler tarafindan ozel olarak algilanmakta ve sinifin nesnesi uzerinden geriye hizlica Tuple bir deger dondurmemizi saglar.

        //Bir başka benzetme olarak, bir sepet dolusu meyve düşünün. Sepeti deconstruct etmek, her bir meyveyi tek tek almak yerine sepeti birkaç parçaya ayırmak gibi olacaktır. Sepetin sapı, gövdesi ve altındaki tabanı gibi parçalara ayırabilirsiniz. Bu sayede, her parçayı ayrı ayrı ele alabilir ve daha kolay işleyebilirsiniz. Aynı şekilde, bir yapıyı veya nesneyi deconstruct etmek, farklı özelliklerine ayrı ayrı erişmek için kullanışlıdır.

        // ORNEK 1)




        //2)
        class Program
        {
            static void Main(string[] args)
            {


                Ogrenci ogrenci = new Ogrenci { Ad = "Ahmet", Soyad = "Yılmaz", Yas = 23 };

                var (ad, soyad, yas) = ogrenci; // Bu semantigi sadece Clasimizda Deconstruct kullandigimiz icin kullana biliyoruz

                Console.WriteLine(ad);    // "Ahmet"
                Console.WriteLine(soyad);  // "Yılmaz"
                Console.WriteLine(yas);   // 23

            }

        }

        //1)
        public class Ogrenci
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }

            public void Deconstruct(out string ad, out string soyad, out int yas)
            {
                ad = Ad;
                soyad = Soyad;
                yas = Yas;
            }
        }

       //









    }
}
