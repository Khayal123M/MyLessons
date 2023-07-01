using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{


    internal class Nesne
    {
        // NEsne NEdir ?

        /*Nesne, yazılım geliştirme ve programlama terminolojisinde, veri ve işlevselliği birleştiren bir programlama yapı taşıdır. Bir nesne, belirli bir tür veya sınıfın örneğidir ve özellikleri (alanlar) ve davranışları (metodlar) olan bir veri yapısıdır.

         Nesneler, özellikleri ve davranışları bir arada bulundurarak, yazılım geliştiricilerin daha karmaşık sistemler ve uygulamalar oluşturmasına olanak tanır. Nesneler genellikle birbirleriyle etkileşim halinde olurlar ve bir nesnenin davranışı, diğer nesnelerin durumunu etkileyebilir. Nesne yönelimli programlama, birçok modern programlama dilinde kullanılan bir programlama paradigmasıdır ve nesnelerin kullanımı ile karakterizedir.
         * 
         
        NEsne Tapanli programlama uygulamasak programlamada degerler artdikca bunlarin yonetimi oldukca zorlasir.Daha kolay yonete bilmemiz icin Class lar olusturup icerisinde fieldler ve metotlar yerlestirerek bu classlari yonetmeye calisiyoruz.

        Nesnelerde Bu Class yapilarindan uretilen verilerdir.Ama Daha kompleks verilerdir.

        -MES: Bir personelin Ismi,Soyismi,Yasi  bir Personel nesnesine dahil edile bilir.Ama personelin araba markasi adinda bir Field olusturamayiz.Cunku her personelin arabasi olmak zorunda degil.NEsnenin icerisinde luzumsuz bir degere yer yoktur.

        -Nesneler kompleks degerlerdir.Cunki iclerinde 1 den fazla deger tasir.

        -Class lar ise nesneleri olusturmamiza yardim eden kompleks Types lerdir.   Complex types, bir programlama dilinde, birden fazla veri tipini içerebilen ve kendi özelliklerine sahip olan yapı tipleridir. Bu tür yapılar, farklı tipteki verileri birleştirerek daha karmaşık yapılar oluşturmak için kullanılır.

        Örneğin, bir müşteri veritabanında bir müşterinin adını, adresini ve telefon numarasını saklamak için bir kompleks veri türü kullanılabilir. Bu veri türü, bir dize (string) türü için ad ve adres, bir sayı (integer) türü için posta kodu ve bir telefon numarası (string veya integer) türü için alanlar içerebilir.

        Bir başka örnek, bir kitap veritabanında bir kitabın başlığı, yazarı, yayıncısı ve fiyatını saklamak için bir kompleks veri türü kullanılabilir. Bu veri türü, bir dize türü için kitap başlığı ve yazar adı, bir yayınevi verisi için bir kompleks veri türü ve bir ondalık sayı (float) türü için fiyat alanlarını içerebilir.
         
         -Bir nesne olustura bilmek icin mutlaka Classa ihtiyac vardir.Interface,Abstrack classlar ve s ile Nesne olusturulamaz.


        - --------  OLUSTURDUGUMUZ BIR CLASSDAN NESNE OLUSTURA BILMEK ICI     NEW     OPERATORUNE IHTIYACIMIZ VARDIR ----------------------------
        ----------  BIR NESNE OLUSTURMAK ICIN NEW  SAGINA      NESNE_TYPE()    YAZMAMIZ GEREKIYOR MUTLAKA  ----------------------------
        DAha once Class isimlerininde bir veri typi oldugunu ogrendik.Yani clasimizin ismini yazmamiz lazim aslinda.
        ---------- NESNE_TYPE MIZIN SAGINDAKI ()  PARANTEZ ISE CONSTRACTORUMUZUN METODUDUR               -----------------------------
        ORNEK  1)
         */

    }

    //2) Buradada Clasimizdan nesne olusturmak icin new NesneType() kullandik

    new MyClass();


    //1) Burada Nesne olusturacagimiz Clasimizi olusturduk
    class MyClass
    {
        public int A { get; set; }

        public void X()
        {

        }


    }

    /*
     * 
     Bir NEsne olusturdugumuzda bu Nesnemizin Type si Ramde HEAP kisminda bir yer kaplar.
    Heap daki nesnelere developer olarak bizim kesinlikle erisim iznimiz yoktur.Bu sebeple Stack hafizadaki bir referansla isaretlememiz lazim.
    Burdaki Nesneyi isaretleye bilmem icin olusturdugum referansimin turude ayni olmali.

    ORNEK :
     
     */

    MyClass x = new MyClass();

    // MyClass tipinde x adli referansimizi MyClass adli Clasimizdan new kullanarak bir nesne olusturduk ve x referansimiza atadik

    // Bir nesneyi illaki bir Referans ile isaretlemek zorunda degiliz.Bir Classdan new MyClass() ile 5 nesnede olustura biliriz ve sadece birini MyClass x = ile referans yaparak ataya biliriz.
    // Mesela asagidaki ornekte  hazir gelen Random()  adli sinifimizida kullanmak icin new operatoru ile Nesnelestiriyoruz oncelikle
    new Random();

    

    /*  -------------------- Target - Typed New Expressions (C# 9.0)-----------------
     *  NEsne olusum surecinde olusturalacak olan nesne eger ki direk bir referansa atiliyorsa eger burada hangi nesnenin olusturuldugu referans sayesinde biline bilmektedir.Dolayisiyla ilgili nesnenin olusturula bilmesi icin
     */

    Type x = new Type()  // Semantiginden ziyade

    Type x = new() // seklindede olusturmamizi saglayan yeni bir ozelliktir.

    //Ama bu ozelligi kullana bilmemiz icin yapmis oldugumuz calisma en az .NEt 5.0 da olmalidir.

    // https://www.gencayyildiz.com/blog/c-9-0-target-typed-new-expressions/     // Ilgilii MAkale


    //  ---------------------   NESNE ILE REFERANS ARASINDA ILISKI    -------------------------------

    /*  Referans nedir ?    

    Ram in Stack bolgesinde tanimlanan ve Heap deki nesneleri isaretleyen/referans eden degiskenler/noktalardir

    Classlar,Abstract Classlar  ve Interface ler referans turlu degiskenlerdir ama Class disindakilardan nesne olusturamayiz.

    Birde Record denilen bir yapilanma var Nesneye en yakin yapilanmadir ama bir nense degildir.

    Referanslar illa bir nesne referans etmek zorunda degillerdir.Ve bir nesne referans edilmemisse bu referans Null dondurur

   * Nesne Iceerisindeki elemanlara nasil erisiriz?

    Bir nesneye referans yoluyla eristikten sonra bitisiginde  .  (nokta)  ile icerisindeki erisilebilir olan elemanlarada erise bilizir.

     ORNEK  :
     */
    //2) Clasimizdan bir nesne olusturduk ve bunu ayni tipdeki m referansina atadik.Nokta vasitasiyla m referansimizin icerisindeki property yi cagirdik ve 10 degerini atadik

        MyClass m = new MyClass();
        m.MyProperty = 10

       // 1) Class olusturduk ve icerisine bir property atadik
        class MyClass
        {
            public int MyProperty { get; set; }

        }

    //Null olan(yani nesnesi olmayan) referanslar uzerinden herhangi bir member i cagirip islemeye calistiginizda bu durumda NullReference hatasi verecektir.

    MyClass m2 = null;
    m2.Myproperty = 20;

        /*  Referanssiz nesne olustura bilirmiyiz ?
         * 
         * Bir nesne olusturuldugu an herhangi bir referans ile isaretlenmezse eger HEAP e yerlestirilir.LAkin bu nesneye tarafimizca birdaha erisemeyiz.Haliyle ilgili nesne ile aramizdaki tek diyalog olusturma anidir.
         * 
         * Referanssiz nesne uzerindeki elemanlara nasil erisicez?
         * Ornek: Diyelimki MyClass adli bir class olusturduk ve asagidaki gibi bir referans yapmadan direk nesne olusturduk.
         */ 
        new MyClass();

    /*Egerki bir nesne referanssizsa bunu olustura bilmekteyiz.Lakin bu nesne memory de luzumsuz yer kaplayacagindan dolayi belli bir sure sonra Garbage Collector dedigimiz cop toplayici tarafindan temizlenmektedir.
     * 
     * GC: Heap de referanssiz olan nesneleri imha etmekten temizlemekten sorunlu olan bir yapidir.
     * 
     * 
     */



    /*     ----------- OBJECT INITIALIAZER ILE NESNE OLUSTURMA ESNASINDA PROPERTYLERE ILK                   DEGER ATAMA:   -------------
     *     
     *     Diyelimki bir Class olusturduk ve icerisinde ulasa biliecegimiz turden prop lar ve ya field ler var.Bu Classda bir nesne olusturmamiz lazim bir nesne olusturarak bu propertylere deger aticaz.Bunun icin birinci yol (referans .) kullanarak deger atama.
     * Baska bir yol ise nesne olusturulup referans atandigi zaman parantez ile bunlara ilk degerlerini ataya biliriz
     * 
     * ORNEK  :
     
     */

    // 1) referans . ile atamak

    MyClass m = new MyClass()
        m.Myproperty = 10;

    // 2) Object Initiliazer ile ilk degerlerini atamak

    MyClass m = new MyClass()
    {
        MyProperty = 10
    }

    // 1 ci ornekte Property ler default olarak 0 atanir ve daha sonra referans ile 10 atariz.2 ci ornekte ise Default olarak 10 atariz.
    //Bir nesne eger referanssiz ise bile Object Initiliazer yontemi ile ilk referansini ataya bilirriz ve daha sonra bu elemanlara ulasamayiz.

    //MEtotlara bu usulle deger atayamayiz.Cunki metota deger atanmaz metot tetiklenir ve parametre alir.


