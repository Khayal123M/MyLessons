using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class _94_Poliformizm // Cok Bicimlilik
    {
        /*Biyolojide Polimorfizm nedir ? -----
         * 
         * Mes: Kelebek bir canli turudur ve bu turden bircok farkli kelebek turleri vardir.Yada Kedigiller bir hayvan sinfidir icerisinde kaplan,leopar ve s vardir.
         * 
         *Aynı türdeki bireylerin genetik varyasyonlarına dayanan farklı morfolojik, fizyolojik veya davranışsal özelliklere sahip olması durumudur. Bu farklılıklar, doğal seleksiyon gibi faktörler tarafından etkilenerek, türlerin adaptasyonu ve evrimi için önemli bir rol oynar.

        Örneğin, bir türdeki bireylerin deri rengi, vücut boyutu, göz rengi gibi özellikleri farklılık gösterebilir. Bu farklılıklar, genetik varyasyonlardan kaynaklanabilir. Örneğin, insanlarda kahverengi, mavi, yeşil, gri göz rengi gibi farklılıklar bulunur. Bu farklılıklar, iris pigmentasyonu ile ilgili genetik farklılıklardan kaynaklanır. Ayrıca, insan boyu da genetik olarak kontrol edilir ve bireyler arasında farklılık gösterir.

        Biyolojik polimorfizm aynı zamanda türlerin adaptasyonu ve evrimi için önemli bir rol oynar. Örneğin, bir böcek türünde bazı bireylerin kısa kanatları ve bazılarının uzun kanatları olabilir. Uzun kanatlı bireylerin genellikle daha hızlı uçabildiği ve kısa kanatlı bireylerin ise daha iyi gizlenebildiği görülmüştür. Bu farklılıklar, türün hayatta kalması ve uygun ortamlarda daha iyi adapte olabilmesi için önemlidir.

        Bu örnekler, biyolojik polimorfizmin türlerin çevresel koşullara uyum sağlamasına ve doğal seçilim yoluyla evrimleşmesine yardımcı olan bir mekanizma olduğunu gösterir.
         * 
         * 
         */

        //Cok Bicimlilik bir nesneyi birden fazla formla tarif ede bilmektir.

        // Mes: Ben Hayalim, Biryandan Insanim,Biryandan Erkeyim

        // OOP de ise poliformizm:
        // Iki yada daha fazla nesnenin ayni tur sinif tarafindan referans edile bilmesidir.

        //Bir baska degisle. Bir nesnenin birden fazla farkli turdeki referans tarafindan isaretlenebilmesi poliformizmdir.

        //Poliformizm, bir nesnenin kalitimsal olarak iliskisi olan diger nesnelerin referansiyla isaretlenebilmesini saglar.

        //Poliformizm, OOP tasarimda gelistirilen koda daha manevrasal bir sekilde nitelik kazandiran ve yaklasim sergilememizi saglayan bir ozelliktir.

        //Poliformizm, programlamadaki temel prensip olan "Referansla isaretleme prensibini asip eldeki nesnenin birden fazla referansla isaretlenebilmesini saglar."

        A a = new A();  // Normal referansda A turunden bir nesne icin A sinfindan karsilama gerekli

        // Bir nesnenin bir den fazla referansla isaretlenmesi, o nesnenin,birden fazla turun davranisini sergilemesini saglar.

        // Kus cinsinden olan tum hayvanlarin kendi turlerinin disinda bir yandanda Kus olarak tarif edilmeleri cok bicimliliktir.Peki kus olmayan bir hayvana Kus diyemiyoruz.Mesela Maymun.Bir Kus degildir.Buradan soyle bir sonuca varabiliriz.

        //Ortak atadan gelen,kalitimsal olarak Kus tan tureyen tum hayvanlar kendi turleri yahut Kus turu ile referans edilebilir..

        // Bir nesnenin farkli bir nesnenin referansi ile isaretlene bilmesi icin o classdan turuyor olmasi lazim yani kalitim sart

        //Evet Bir nesnenin baska bir nesne ile isaretlenebilmesi icin kesinlikle arada kalitimsal bir iliski olmasi lazim.

        //Yani bir baska degisle ,Nesne tabanli programlamada Poliformizm uygulamak istiyorsaniz turler arasinda kalitim uygulanmis olmalidir.

        //Ya da bam baska bir degisle.Nesne Tabanli programlamada poliformizm aralarinda kalitimsal iliski olan siniflarda uygulanabilir.Aksisi mumkun degildir.

         // Ornek:



    }

    class Program
    {
        static void Main(string[] args)
        {
            Ornek_Class2 m = new Ornek_Class1();
        }
    }


    class Ornek_Class1 : Ornek_Class2
    {

    }

    class Ornek_Class2
    {

    }

    // Yukaridaki ornekte 2 ornek Class olusturduk.Daha sonra 2 yi 1 e base olarak atadik.Bu sayede artik m ile referans olustururken Ornek_Class 1 icin onu Ornek_Class2 ilede karsilaya biliyoruz.Cinki 2 - 1 in ust sinifi oldu artik.Buda poliformizm ornegidir.

    // Burada aslinda Ornek_Class1 kendisi olmakla birlikte ayzi zamanda Ornek_Class2 dir diyoruz.Yani kendi ozelligini kaybetmez sadece cokbicimli olur artik

    // Ornek

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            B b = new B(); // B ayni zamanda tabiki B den tureyebilmekte
            C c = new B();

        }
    }





    class A : C  // C tipi ile B clasini referans edebilmemiz icin B ye 2 tane Base ataya bilmeyecegimiz icin daha ust bir siniflarindan birine yani A ya C yi Base olarak atamamiz gerekdi
    {

    }
    class B : A // A tipi ile B clasini referans etmek icin B ye A yi base olarak atadik
    {

    }
    class C
    {

    }




    //Ornek : Asagidaki nornekte Insan clasini Erkek ve Kadin claslarina Base class olarak atadik bu sayede Erkek ve Kadin classlarinin referanslarini Insan clasinin i1 ve i2 referanslari ile referansladik.

    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Erkek();
            Insan i2 = new Kadin(); 
           

        }
    }



    class Insan
    {

    }

    class Erkek : Insan
    {

    }

    class Kadin : Insan 
    {

    }



    // Poliformizm Neye Yarar ? ----------------

    //Daha oncede soyledigimiz gibi Bir nesnenin birden fazla referansla isaretlenmesi o nesnenin birden fazla turun davranislarini gosterebilmesini saglar.

    // Ornek  - Asagidaki ornekte  A clasi B clasina oda C clasina Base class olarak atandigi icin c referansi ile kendisinden onceki classlarin metodunada ulasa biliyoruz.
    // Eger B ile C nesnesinin referansini karsilarsak buzaman sadece A ve B de olan X ve Y metodlarina ulasa biliriz.Aslinda Z de mevcut C de ama B ile Referansladigimiz icin sadece B nin davranislarini gore biliyoruz bu nesnede
    // Ayni sekilde A ilede referanslarsak C de Y,Z olsada sadece A nin ulasa bileceki X metoduna ulasabiliyoruz.


    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            c.X();
            c.Y();
            c.Z();

            B b = new C();
            b.X();
            b.Y();

            A a = new C();
            a.X();


        }
    }


    class A
    {
        public void X() { }
    }
    class B : A
    {
        public void Y() { }
    
    }
    class C : B
    {
        public void Z() { }
    }

    // Yani Poliformizmin esas amaci gelecekte bizim icin farkli classlardan gelecek onlarca niteliyi ozelliyi eleyerek isimize yarayanlari sece bilmek kabiliyeti olacaktir














    // POLIFORMIZMI N TURLERI VE TUR DONUSUM OPERATORLERI ---------------

    // BUNDAN SONRA POLIFORMIZM HAKKINDA OGRENECEKLERIMIZ PRATIKDE FAZLA KULLANILMAYAN KISIMLARI.YANI BUNLARSIZDA SAGLIKLI SEKILDE KOD YAZA BILIRIZ

    // 1) STATIC POLIFORMIZM

    //Static ilerde gorecegimiz bir kavramdir.

    //Simdilik sadece Poliformizm cercevesinde Static Poliformizm degerlendirecez.

    //Static poliformizm; derleme zamaninda sergilenen poliformizmdir.Hangi fonksiyonun cagrilacagina derleme zamaninda karar verilir

    //C# da static poliformizm deyince aklimiza METOT OVERLOADING terimi gelmektedir.(Bir metot ismine 1 den fazla metot olusturmak)

    //Metot Overloading: ayni isimde birbirinden farkli imzalara sahip olan metotlarin tanimlanmasidir.Yada baska degisle bi isme birden fazla farkli turde metot yuklemektir.Haliyle burada bir metodun birden fazla formunun olmasi Poliformizm iken,bunlardan kullanilicak olanin derleme zamaninda bilinmesi Static Poliformizm olarak nitelendirilir.

    // 2) DINAMIK POLIFORMIZM

    // Dinamik poliformizm; calisma zamaninda sergilenen polifprmizmdir.Yani hangi fonksionun calisacagina RunTime da karar verilir.

    // C# da dinamik poliformizm deyince akla METOT OVERRIDE gelmektedir.(Yani Virtual Metodun ALt sinifta Override ile ezilmesi)

    // Metot Override; base class ta virtual olarak isaretlenmis metotlarin derived classda override edilerek ezilmesi/yeniden yazilmasi islemidir.Haliyle burada ayni isimle birden fazla forma sahip fonksionun olmasi poliformizm ken bunlardan hangisinin kullanilacaginin calisma zamaninda bilinmesi dinamik poliformizm olarak nitelendirilir.

    // 3) TUR DONUSUMLERI 

    //Poliformizm, OOP de bir nesnenin kalitimsal acidan atalari olan referanslar tarafindan isaretlenebilmesidir.Haliyle ilgili nesne , bu atalari olan referans turlerine gore donusturulebilmektedir.

    //Ogrendigimiz gibi Eger A nesnesiyle B yi B ilede C yi kalitim ile atadiysak artik A ile hem A yi hem B yi hemde C yi cagira biliriz.Ama B aslinda B dir C aslinda C dir.

    // Ornek:

    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            A a = new C(); // Bu nesne A referansinda tutulan bir C turunden nesnedir. Haliyle ihtiyac duyuldugunda A referansi uzerinden diger katilimsal iliskide oldugu referanslara yahut kendi referansina donusturulebilmektedir.

            C c = (C)a; // Misal olarak,burada goruldugu uzere A turunden olan a referansindaki ozunde C turunden nesne kendi turunden bir referansla isaretlenmistir.
                        // Buradaki () operatoru Cast operatoru adlanir.C# Cast operatörü, bir veri türünü başka bir veri türüne dönüştürmek için kullanılan bir operatördür. Cast operatörü, değişkenlerin ve nesnelerin türlerini dönüştürmek için kullanılır. Bu operatör sayesinde, bir türden diğer bir türe değişken değeri aktarabilirsiniz.
                        //Bu durumun terside gecerlidir.Yani ilgili nesne kendi turunden kalitimsal olarak atalari olan diger turlere Cast edebilir.

            C c = new C(); // Bu islem ve asagidaki Cast operasyon ayni islevi gorurler.
            A a = new C();

            C c = (C)a; //





        }
    }


    class A
    {
        public string X { get; set; }
    }
    class B : A
    {
        public string Y { get; set; }
    }
    class C :B
    {
        public string Z { get; set; }

    }




}
