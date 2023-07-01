using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Static_Constructor
    {
        // Static Constructeri daha iyi anlaya bilmemiz icin oncelikle Static yapilanmasini anlamamiz lazim.Bunu ilerde inceleyecegiz daha detayli
        //C# programlama dilinde "static" kelimesi, bir değişkenin veya yöntemin sınıf düzeyinde (class-level) olduğunu belirtmek için kullanılır.

        /*Bir siniftan eger  ILK KEZ  nesne uretiliyorsa ilk tetiklenen fonksion aslinda Static Constructordur,ondan sonra normal Constructor.
         * 
         * Lakin eger daha once bu siniftan nesne uretildiyse diger nesne uretimlerinde sadece Constructor tetiklenir.
         
        Bazı durumlarda, static constructor'ın kullanımı opsiyoneldir, ancak sınıfın statik üyeleriyle ilgili bir öncelik veya sıralama gerektiği durumlarda static constructor oldukça faydalı olabilir.



        */

        static void Main(string[] args)
        {

            new ExampleClass();  // Clasimizdan ilk nesne uretimi ,hem Static ctor ilk olarak daha sonra normal ctor tetiklenir

            new ExampleClass(); // Clasimizdan 2 ci nesne uretimi, artik sadece normal ctor tetiklenir.

        }


        
            public class ExampleClass
            {
                static ExampleClass()   //  Static Ctor
                {
                    Console.WriteLine("Static Constructor tetiklendi");
                }

                public ExampleClass()   // Normal Ctor
                {
                    Console.WriteLine("Constructor called.");
                }
            }


        // Static Constructorda Geri donus degeri ve erisim belirleyici(public) bildirilmez.

        // Overloading Yapilmaz.

        // Bir sinifin icerisinde sadece 1 adet tanimlana bilir.

        // Ismi Sinif ismiyle ayni olacaktir.

        //  Uretilen ilk nesnenin  disinda birdaha tetiklenmez.

        // DIKKAT : Static Constructorun tetiklenmesi icin illa ilk kez sinifin olusulmasi disinda baska bir yolda vardir.Buda Ilgili sinfin icerisinde herhangi bir static yapilanmanin tetiklenmesi ilede Static Constructor tetiklenir.Ama daha detayli ilerdeki derslerde gorecegiz:
        // Ama yinede bu usulla bile Static Ctor tetiklenirse birdaha tetiklenmez.

        //Singleton Design Pattern
        // Bir sinifin uygulama bazinda tek bir nesne olusturmasini istiyorsak kullanabilecegimiz bir Design Pattern var  

        //2) Burada database1 olusturulan ilk nesne ve her lazim oldugunda 2 ve 3 de olusturdugumuz nesnelerde aslinda 1 ci nesneyi bana getiriyor.Boylece Clasimizdan farkli nesneler olusturmamizin onune gectik
        static void Main(string[] args)
        {

            var database1 = Database.GetInstance;
            var database2 = Database.GetInstance;
            var database3 = Database.GetInstance;

            database1.ConnectionString = "gjhgjkhgug"; // Propertye deger atadik.Artik database2 ve database3 icinde ConnectionString database1 e atanmis bu degere sahip.
            

        }






        //1)
        class Database // Burada private yazmakla hicbirsey yazmamak arasinda bir fark yoktur
        {

            Database()
            {

            }

            public string ConnectionString { get; set; } // 1 property olusturduk string veri tipinde

            static Database database;

            static public Database GetInstance
            {
                get
                {
                    return database;
                }
            }

            static Database()
            {
                database = new Database();
            }





        }











    }
}
