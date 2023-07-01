using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Destructor
    {
        // Destructor / Finalazer nedir ?   Yikici

        //Bir classdan uretilmis nesne imha edilirken otomatik cagirilan metotdur.
        //Nesne ile isimiz bittikden sonra belleyimizde yer kaplamamasi icin imha edicez.En son garanti bir sekilde tetiklenir

        //C# yapilanmasinda Descructor sadece Class icerisinde kullanila bilir ve bir class sadece ve sadece 1 destructor icere bilir

        //Destructor fonksionu overloading yapamaz ve parametre alamaz

        /*Peki bir nesne hangi sartlarda ve kim tarafindn imha edilir?
         * 
         * Ilgili nesne herhangi bir referans tarafindan isaretlenmemisse
         * Yahut nesnenin olusturuldugu ve kullanildigi scobe sona ermisse.Yani ilgili alanda gorevi sona ermisse
         * YAni bir nesneye birdaha erisilemez hale gelmisse 
         * O nesne Garbage Collector tarafindan imha edilir.
         * 
         * Esasinda Garbege Collector C# bellek yapilanmasini tekbasina ustlenmis bir yapilanmadir.
         * Garbage Collektorun nezaman is gorecegi tahmin edilemez.
         * Garbage Collectora mudahele edile bilir lakin bu onerilmeyen birseydir
         * 
         * GArbege Collector nesneyi yokederken Destructor fonksionunu tetikliyor.
         */

        //Destructorun imzasi 

        //DEstructor tanimlamak icin basinda ~ (tilda) isareri kullanilir
        //Her ozel sinif elemaninda oldugu gibi Destructorda sinif ismiyle ayni isimde olan bir fonksiondur
        //Bir sinif icerisinde sadece 1 adet Destructor tanimlana bilir
        //Bir nesne GArbage Collector tarafindan imha edilirken bu fonksionu calistirir

        // Ornek:

        class MyClass
        {
            // Constructor
            public MyClass()
            {
                Console.WriteLine("Selam");
            }

            //Destructor
            ~MyClass()
            {
                Console.WriteLine("Selam");
            }
        }


        // Garbage Collectoru cagirarak nesneyi sildirme orneyi(Cagirma islemi onerilmemekre ornek icin )


        //  2) X adinda metot olusturduk ve MyClass2 Clasimizi referansa atamasini sagladik:
        //  3) X() metodumuzu cagirdik , Garbage Collectorumuzu cagirdik ve Destructorun tetiklenmesi sonucunda olusacak islemin sonucunu yazdirmasini istedik.
        class Program
        {
            static void Main(string[] args)
            {
                X();
                GC.Collect();         // Garbage Collectora disardan bu sekilde mudahele edilmesi tavsiye edilmez:
                Console.ReadLine();
            }


            static void X()
            {
                MyClass2 m = new MyClass2();
            }


        }


        // 1) MyClass 2 adinda bir Class olusturduk ve hem Constructor hemde Destructor elemanlarini atadik.
        class MyClass2
        {
            public MyClass2()
            {
                Console.WriteLine("Nesne Uretilmistir");

            }



            ~MyClass2()
            {
                Console.WriteLine("Nesne imha ediliyor");

            }
        }



        //    ORNEK 2 -- 


        //2) sayi degiskenine 100 atadik
        //  While dongusunde sayi 1 >= olana kadar donsun ve MyClass3 sinfimiza ctor ile gonderilen 100 sayisindan 1 eksilt her seferinde.
        // Console.Writlane ile yildizlar yazdir  daha sonra Garbage Collector cagirarak Desstructorun tetiklenmesini sagla ve sonucu yazdir.
        // Sonuc olarak once 100 kere {no} cu nesne olusturulmustur yazdirilicak 
        // Daha sonra 100 kere {no} cu nesne imha edilmistir yazdirilacak
        class Program
        {
            static void Main(string[] args)
            {
                int sayi = 100;

                while(sayi >= 1)
                {
                    new MyClass3.(sayi--);  // MyClass 3 Clasimiza ctor ile atadik 100 sayisini ve eksilicegini 1 er 1 er 
                }

                Console.WriteLine("*************************");
                GC.Collect();
                Console.ReadLine(); 
            }


           

        }








        // 1) MyClass3 adinda Class olusturduk Constructor ve Destructorlarini atadik
        class MyClass3
        {
            public MyClass3(int no)
            {
                this.no = no;
                Console.WriteLine($"{no}.cu nesne olusturulmustur");

            }



            ~MyClass3()
            {
                Console.WriteLine($"{no}.cu nesne imha edilmistir");

            }
        }


    }
}
