using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Inheritance____Kalitim_     //  Operatoru.  :
    {
        /*   Kalitim OOP nin ennn onemli ozelligidir.
         *   
         *   Nesnelerimizin bazi ozelliklerini baska nesnelere aktara bilmemiz mumkun.Boylece hierarsik bir duzenleme yapilabilmektedir
         *   
         *   Ayni aile grubundan gelen nesnelerin yada yatayda esit seviyede olan tum olgularin benzer ozelliklerini tekrar tekrar herbirinde tanimlamaktansa bir ust sinifta tanimlanmasini ve her bir sinifin bu ozellikleri ust siniftan katilimsal olarak almasini saglamaktadir.
         *   
         *   Mes: Kadin ve Erkek , Insan Aile grubuna aittirler.Her ikisindede isim mevcuttur.Her iki clasa ayri ayri isim tanimlamak yerine Ismi Insan Clasina tanimlayip daha sonra Inheritance(kalitim) yolu ile KAdin ve Erkekde kullana biliriz.
         *   
         *   Boylece hem kod maliyeti dusmekte hemde mimarisel tasarim acisindn avantaj saglanmaktadir.Ilerde ogrenecegimiz bircok Design Pattern - Kalitim uzerine kuruludur.
         *   
         *   Butun siniflar kalitimsal olarak kullanilmak zorunda degiliz ama kullana bileceklerimizi kullanmaliyiz.
         *   
         *   Mes: Canli ust sinifindan (Insan , Hayvan ) alt siniflarinna kalitim ile ozellik saglaya biliriz.Daha sonra Insan clasimizi ust sinif olarak kullanip tekrardan buradanda(Erkek,Kadin) Alt siniflarimiza kalitimsal olarak ozellik saglaya biliriz.Bunu boyle mimarisal olarak istedigimiz kadar devam ettire biliriz.
         *   
         *   Ust Siniflarin isimleri yazilimsal acidan anlasilabilirliyi kolaylastirmak icin alt siniflari kapsayici bir isim olmalidir.Mes Erkek,Kadin siniflarin ortak ozelliklerini tutan Ust sinifin adi bir Futbol takimi adi degilde Insan olmasi uygundur.
         *   
         *   Ust siniflardan alt siniflara istersek butun ozellikleri istersekde sadece sectigimiz ozellikleri kalitimsal olarak gondere biliriz.
         *   
         *   Kalitim almak,Miras Almak, Turetilmek - Bunlar ayni seylerdir 
         *   Genellenemeyen ve digerlerinde olmayan ozellikler o clasin kendisinde kullanilicaktir
         *   
         *   Kalitim operosyonunda,kalitim veren sinifin erisilebilen tum memberleri kalitim alan sinifa kalitsal olarak aktarilicaktir.Yani eger bir Ust classda erisilebilir 3 tane eleman tanimladiysaniz va bunu 3 adet alt clasa Kalitimla verdigseniz 1 clasa bunlardan sedece 2 si gonderilsin digerine sadece 1 i gonderilsin diyemezsiniz.3 Alt clasada 3 Erisilebilir Elemaniniz atanir.
         *   
         *   Public olan butun memberler kalitim alan alt classlara gonderilir
         *   
         *   Virtual,Poliformizm,Abstraction,Interface ... Bunlarin hepsi Kalitim ile mumkundur.
         *   
         *   C# PROGRAMLAMA DILINDE HANGI YAPILAR KALITIM ALA BILIRLER---
         *   
         *   C# programlama dilinde kalitim Classlara ozel bir niteliktir
         *   
         *   Yani bir sinif sadece ve sadece bir sinifdan kalitim ala bilir.
         *   
         *   Peki Recordlar ozunde bir sinif degilmidir.Onlar kalitim ala biliyormu?
         *   
         *   EVet Recordlar da kalitim alabilmekte.Lakin sadece kendi aralarinda.Kalitim alabildikleri tek istisnai sinif OBJECT sinifidir.Object Kalitimda onemli bir rol oynayan ozel bir siniftir.
         *   
         *   Ayrica sonraki derslerimizde gorecegimiz Abstract Class,Interface ve Struct gibi yapilarinda kendilerine gore kalitimsal operasyonlari mevcuttur.Ayni operatoru kullansalarda ve benzer islem gorselerde bu yapilar Class kalitimi ile ayni degillerdir.
         *   
         *   C# TA KALITIM NASIL ALINIR ? --------
         *   
         * C# da iki sinif arasinda kalitimsal iliski kurabilmek icin : operatoru kullanilmaktadir.
         * 
         * Kod icerisinde gordugunuz : operatoru kalitim degildur.Kalitimin ozel alani vardir.
         * 
         * Ornek:
         *   
         * 
         */

        class Araba
        {
            public string Marka { get; set; }
            public string Model { get; set; }
            private int KM { get; set; } 
            //Private erisim belirleyicisi yaptigimiz eleman aktarilma kalitim ile.
        }

        // Soldaki Class Sagdaki Classdan kalitim alsin.Yani; Opel sinifi,Araba sinifindan kalitim alsin demis oluyoruz.
        class Opel : Araba
        {

        }

        //Artik Opel sinifindan bir nesne urettigimizde icerisinde Marka ve Model propertyleri kalitimsal olarak Araba sinifindan aktarildigi icin artik erisilebilir olacak.

        // Ornek :

    }
    // 2) Muhasebeci clasimizdan referans ile nesne olusturduk ve icerisindeki ozellikleri cagirdik.Kendisine Ust Personel clasindan atanmis butun elemanlara muhasebeci referansimiz ile ulasa bilmemiz ile birlikte ayni zamanda Muhasebeci Clasimizin Musavir propertysinede ulasiyoruz.

    static void Main(string[] args)
    {

        Muhasebeci muhasebeci = new Muhasebeci;
        muhasebeci.Isim;
        muhasebeci.Soyisim;
        muhasebeci.Maas;
        muhasebeci.Musavir;

    }



    //1) Personel adinda ust class olusturup ortak ozellikleri : operatoru ile kalitim ile diger alt classlarima atadim
    class Personel
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Maas { get; set; }

    }

    class Yazilimci : Personel
    {
       
    }

    class Muhasebeci : Personel
    {
        public bool Musavir { get; set; }
    }

    class Mudur : Personel
    {

    }

    /*
     * BASE CLASS VE DERIVED CLASSLAR ------
     * 
     * Kalitim veren sinifa Base/PArent , Kalitim alan sinifa ise Derived / Child Class Denir.
     * 
     * Mes: Araba sinifi Base Class dir , Opel sinifi Derived Classdir.
     * 
     * 
     * Ornek:
     */

    class A
    {

    }

    class B : A
    {

    }

    class C : B
    {

    }

    class D : C
    {

    }

    // Yukaridaki gibi bir durumda butun alt Classlar A clasinin ozelliklerinide iclerinde barindirsalarda A hepsinin Base Clasi degildir.Yani Her alt Clasa Katilim yapilan kendi Ust Sinifi Base clasidir. yani A , B icin Base clas ise B , C icin Base classdir.

    //Bir sinifin sadece 1 adet Base Clasi ola bilir.

    // Bir Clasin 1 den fazla Derived clasi (yani alt Clasi,alan clasi) ola bilir.

    //Bir class ayni anda hem Derived Class hemde Base class ola biliyor

    // KALITIM ALTIN KURALI --------

    //Bir class sadece ve sadece 1 Base clasdan kalitim alir.Ayni anda 1 den fazla classdan kalitim alinmasina izin verilmez.

    //YAni Anne ve Baba adli 2 ust classdan Cocuk adli bir alt clasa ayni anda kalitim ile eleman gonderilemez.Cocuk ya tek Anneden ala bilir yada tek Babadan

    //Ileride bu sekilde 1 den fazla kalitim tanimlamasinin yapilabildigini goruceksiniz ama orada gorecekleriniz Bir sinif olmayacaktir.Onlar Arayuz yani Interface lerdir

    // Eger Cocugun hem Baba hemde Annenin ozelliklerini tasimasini istiyorsak bunun icin yatay degil dikey kalitim yapmaliyiz.Yani Anne Babadan Kalitim yapar ve ozelliklerini alir daha sonra Cocukta Anneden kalitim yapar ve boylece her ikisinin public olan butun ozelliklerini alir.

    class Baba
    {

    }

    class Anne : Baba
    {

    }

    class Cocuk : Anne
    {

    }

    // KALITIMDA NESNE URETIM SIRASI -----------

    //Bir siniftan nesne uretimi yapilirken kalitim aldigi ust siniflar varsa eger once o siniflardan Sirayla nesne uretilir.

    // Yani Yukaridaki ornekteki Cocuk clasindan nesne uretdigimizde aslinda arkada Anneden  ordanda Babaya gecer .Ilk once en ust classtan baslayarak sirasiyla once Babadan Daha sonra Anneden nesne uretilir gozukmeden Heap de.Ve bu sayede Cocuk nesnemizden . nokta ile kalitim aldigimiz elemanlari cagira biliyoruz.

    // Ornek: Asagidaki ornegimizde Siniflarimizi Constructorlarini  kullanarak Console Writlane ile her nesne olusturuldugunda Class ismini ve Nesnesi Olusturulmustur yazisini yazdiracagiz.Bu ornekle aslinda biz D clasimiz icin referans ile nesne olusturdugumuzda Compaliler in altda nasil ilk Base Class olan A ya kadar gelip sirasiyla A dan baslayarak B, C icinde nesne olusturacaginin gorecegiz ciktida.

    static void Main(string[] args)
    {
        
       
    }




    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof(A)} Nesnesi Olusturulmustur");

            // nameof - Icerisine verilen Sinifin ismini metinsel olarak ilgili alana yazdiran bir Keyworddur.
            // Sadece {A} olarakda Class ismimizi yazdira biliriz ama nameofla yazdirmak programcilik acisindan daha dogrudur.Direk metinsel olarak yazdirmak risk teskil ede bilir ve daha sonradan Class adini degistirmis ola bilirsiniz.Ozaman bu koda donerekde class adini degistirmeniz gerekecek.
        }

    }

    class B : A
    {
        public B()
        {
            Console.WriteLine($"{nameof(B)} Nesnesi Olusturulmustur");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine($"{nameof(C)} Nesnesi Olusturulmustur");
        }
    }

    class D : C
    {
        public D()
        {
            Console.WriteLine($"{nameof(D)} Nesnesi Olusturulmustur");
        }
    }


    /*
     *  BIR SINIFTAN BASE CLASS CONSTRUCTORUNA ULASIM ------   (  base  )
     *  
     *  Mademki, herhangi bir sinifdan nesne uretimi gerceklestirilirken oncelikle base class indan nesne uretiliyor, bu demektirki once base class in constructoru tetikleniyor.
     *  
     *  Haliyle bizler nesne uretimi esnasinda base class ta uretilecek olan nesnenin istedigimiz constructorlarini tetikliyebilmeli yahut varsa parametre bu degerlere verebilmeliyiz.
     *  
     *  Iste bunun icin ( base ) Keywordunu kullanmaktayiz.
     * 
     * base - nin 2 Amaci vardir.
     * 
     * 1) Base clasin constructoruna erisebilmek icin
     * 
     * 2) This Keywordune benzer bir amac
     * 
     * 
     * 
     * Ornek : Alt Classdan nesne olustururken oncelikle Base Clasa gidip gorunmeden nesne olusturuldugu icin icerisinde constructor tanimlamadigimiz yani kendi gorunmez constructoru olan MyClass dan nesne olusumunda bir sorun yasanmaz.Ama eger gorunmez Constructorunu ezip biz Ctor olusturup buna bir beklenen deger atarsak ozaman MyClass 2 den nesne olusturmak istedigimizde Heapde MyClass dan nesne olusturulmasi zamani bir deger atanmadigi icin islem gerceklesmez.MyClas ctoruna bir deger atamissak buraya mutlaka bir deger vermeloiyiz. Bunuda MyClass 2 ye ctor atayarak onun yaninda base keywordu ile MyClass Constroktoruna ulasarak yapa biliriz.
     */

    class MyClass 
    {
        public MyClass()
        {

        }
    
    }


    class MyClass2 : MyClass
    {
        public MyClass2() : base(5)
        {

        }
    }

   // Eger ki base class da bos parametreli bir Constroktor varsa Derived class dan( alt clasdan) Base ye bir bildirimde bulunmak zorunda degiliz.Cunki bos parametreli Class Basedeki bos parametreyi alir
   // 

    //Bir clasin constructorunun yaninda base(...) keywordu kullanirsak o classin base clasinin tum constructorlarini bize getirecektir (this) gibi.Haliyle ilgili siniftan bir nesne uretilirken base class dan nesne uretimi esnasinda hangi constructorun tetiklenecegini bu sekilde belirleye biliriz.

    // base keyword vs this Keyword -----

    // this, bir siniftaki constructorlar arasinda gecis yapmamizi saglar.
    // base, bir sinifin base classinin constructorlarindan hangisinin tetiklenecegini belirlememizi ve varsa parametrelerinin degerlerinin derived class tan verilmesini saglar.


    // Ayrica nasilki this, ilgili sinifta o anki nesnenin memberlerine erismemizi sagliyor, ayni sekilde base de base clasdaki erisilebilir olan memberlere erismemizi sagliyor.

    // Ornek: Asagidaki ornekte A clasini B Clasina Base olarak atadik.this keywordu ile B clasindan elemanlari cagirdik base keywordu ile ise BAse class olan A clasindan ulasilabilir olan elemanlari cagirdik

    class A
    {
        int a;
        public int MyProperty { get; set; }

        public void X()
        {

        }

        private void Y()
        {

        }
    }

    class B : A
    {
        int b;

        public int MyProperty2 { get; set; }

        private void Z()
        {
            this.b = 5;
            this.MyProperty2= 10;
            base.a = 15; // Yalnis: Erisim belirleyicisi olmadigi icin private aslinda
            base.MyProperty = 20;
            base.X();
            base.Y(); // Yalnis: Erisim belirleyicisi private
        }
    }


    //   OBJECT SINIFI ------ BUTUN NESNELERIN ATASI

    //Bir nesne olustururken . ile birlikte bizim class icerisinden ulasa bilecegimiz elemanlarin yaninda asagidaki 4 elemanda gelmektedir.Peki bunlar nereden gelmekte. Object adinda bir ana sinif var aslinda bu 4 eleman Object Clasindan inheretance ile gelmektedir.

    static void Main(string[] args)
    {
        MyClass m = MyClass();

        m.Equals
        m.GetHashCode
        m.GetType
        m.ToString
        
            object // yazdiktan sonra saga tiklayip(go to defination) secersek Object sinfinin kodlarina gideriz


    }



    public MyClass
    {

    }

// Biz bir sinif olusturdugumuzda o sinif otomatik olarak Object sinfindan turemektedir Compailer seviyesinde.

//Eger ki tanimlanan sinif herhangi bir kalitim almiyorsa default olarak Object sinifindan turetilecektir.

//Yok eger herhangi bir siniftan kalitim aliyorsa,bir sinifin ayni anda birden fazla siniftan kalitim alamama prensibinden yola cikarak biryandan da Object sinifindan turemeyecek sadece kalitim aldigi siniftan tureyecektir.   Tabi burada kalitim veren sinif herhangi bir siniftan turemiyorsa eger enn nihayetinde Object ten tureyecegi icin dolayli yoldan insan sinifida Objectden kalitim almis olur.


// Name Hiding - Isim Saklama Sorunsali

// Kalitim durumlarinda atalardan herhangi member ile ayni isimde member a sahip olan nesneler ola bilmekte.



// 1) 2 farkli clasda ayni isimde proporty olusturduk
class A
{
    public int X { get; set; }
}

class B
{
    public int X { get; set; }
}


// 2) Simdi burada X - A danmi geliyor yoksa B denmi ?


B b = new B();
b.X;

// Iste bu duruma Name Hiding denmekte. Cunki su tasarimda base class ta ki atalardaki X member ine B uzerinden erismek mumkun degildir. Yani base deki uye gizlenmistir.

// Ama Bu durumda derleyici hata vermez. Fakat Warning/uyari verecektir.

// Goruldugu uzere B sinifinin base class taki X memberini gizleyecegini ifade etmekte ve gizlenmesi icin ise "new" keywordunun kullanilmasi gerektigini soylemektedir.

// Evet eskiden name hiding durumlarinda alt sinifin icerisindeki uyeyi new ile isaretliyorduk ama Gunumuzde buna ihtiyac yoktur.

//Ihtiyac yoktur lakin biz yine de Name Hiding durumlarinda new operatorunun kullanimini inceleyelim.Cunki karsimiza cikan kodlarda bu kullanilmis ola bilir.



class A
{
    public int X { get; set; }
}

class B
{
    public new int X { get; set; }
}
// Bu sekilde new operatoru ile derleyiciye Name Hiding durumunun iradeli sekilde yaptigimi bildiriyordum eskiden

// Gunumuzde ister kullaniriz ister kullanmayiz.Eger kullanirsak derleyici uyarisini almayiz.


// RECORDLARDA KALITIM (INHERITANCE)-----------------

//Recordlar sadece Recordlardan kalitim alabilmekte

// Classlardan kalitim alamaz ve ya veremez

//Kalitimin tum temel kurallari recordlar icinde gecerlidir 

// Bir record ayni anda birden fazla recorddan kalitim alamaz

// Recordlarda temelde class olduklari icin uretilir uretilmez otomatik olarak Objectden turerler

// base ve this keywordleri ayni amacla kullanilabilmektedir

// Name Hiding soz konusu olabilmektedir


record Myrecord 
{


}

record Myrecord2 : Myrecord
{

}







































}
