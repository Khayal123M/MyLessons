using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class _9
    {
       /* C# dili içindeki bir yapı türüdür ve sınıflarla benzer özellikler taşırlar.

      Sanal yapılar, diğer sınıflar gibi özellik ve davranışlara sahip olabilirler.Ancak sanal yapılar, nesne olarak örneklendirilemezler.Yani, sanal yapılar sınıf türünden olmalarına rağmen, bu sınıfların bir örneği oluşturulamaz.Bu nedenle, sanal yapılar da soyut yapılar olarak kabul edilebilir.

      Sanal yapılar, özellikle arayüzlerle birlikte kullanıldığında oldukça faydalıdırlar. Arayüzler, belirli bir işlevi yerine getiren sınıfların bir koleksiyonudur ve bu sınıfların genellikle bir arayüzü uygulayan bir sınıf türüyle ilişkisi vardır. Sanal yapılar, arayüzlerin özelliklerini ve davranışlarını genişletmek için kullanılabilirler. 
       
        
        */



    }

    public virtual struct SanalYapi
    {
        public int x;
        public int y;

        public SanalYapi(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void BilgiVer()
        {
            Console.WriteLine("Sanal Yapi: x = {0}, y = {1}", x, y);
        }
    }


    /*Yukarıdaki örnek, "SanalYapi" adında bir sanal yapı tanımlar. Bu yapı, iki tamsayı alan ve bunları birbirine bağlı olan "x" ve "y" adında iki değişken içinde saklayan bir yapıcı metoda sahiptir. Ayrıca, "BilgiVer" adında bir sanal yöntemi de içerir. Bu yöntem, "SanalYapi" örneğinin "x" ve "y" değerlerini konsola yazdırır.*
     * 
     * Sanal yapılar, özellikle arayüzlerle birlikte kullanıldığında faydalıdırlar. Arayüzler, belirli bir işlevi yerine getiren sınıfların bir koleksiyonudur ve bu sınıfların genellikle bir arayüzü uygulayan bir sınıf türüyle ilişkisi vardır. Sanal yapılar, arayüzlerin özelliklerini ve davranışlarını genişletmek için kullanılabilirler.

      Sanal yapılar ayrıca, bir sınıfın içindeki diğer sınıfların kullanımını sınırlamak için de kullanılabilirler. Örneğin, bir sınıf içindeki bir sanal yapı, yalnızca bu sınıfın örneği tarafından kullanılabilir olabilir.

      Sanal yapılar, özellikle performans açısından, bazı durumlarda sınıflardan daha avantajlı olabilirler. Çünkü sanal yapılar, bellekte daha küçük boyutlarda saklanabilirler ve bellek yönetimi daha kolay olabilir.

      Genel olarak, sanal yapılar, C# programlama dili içindeki birçok senaryoda kullanılabilen faydalı bir yapı türüdür.*/


    // Bir nesne uzerinde var olan tum memberlerin tamami derleme zamaninda belirgindir.

    //Yani derleme asamasinda hangi nesne uzerinde hangi metotlarin cagirilabilecegi bilinmektedir.

    //Sanal yapilar ile derleme zamaninda kesin bilinen bu bilgi run time(calisma zamanin)da belirlenebilmektedir.Yani ilgili nesnenin hangi metodu kullanicagi bilgisi kararlastirilir.

    //Sanal yapilar bir sinif icerisinde bildirilmis olan ve o siniftan tureyen alt siniflarda da tekrar bildirilebilen yapilardir.

    //Bu yapilar metot yada property olabilir.

    //Evet Name Hiding ile bir siniftaki herhangi bir memberi ondan tureyen torunlarda olusturabiliyoruz ve buradaki yasanan cakismayada Name Hiding diyoruz.

    //Lakin sanal yapilarda olay bu sekilde degildir.Bir sinifta bildirilen sanal yapi(metot yada property) bu siniftan tureyen torunlarinda ezilebilmekte yani devre disi birakilip yeniden olusturulabilmektedir.

    //Yani atadan gelen bir ayni isimli bir memberin  torunda  varolmasini fakat degismesini istiyorsak bu sanal yapilanmadir.Bu islem Atadaki memberi ezmez ve degistirmez o oldugu gibi durur ama torunda farklilasir istedigimiz gibi

    //Yani sanal yapilarda Name Hidingde oldugu gibi bir isimsel cakismadan ziyade ustten gelen bir yapinin islevini iptal edip yeniden yapilandirmak vardir

    //Iste burada bir ssinifta tasarlanmis sanal yapinin islevinin iptal edilip edilmeme durumuna gore tanimlandigi siniftanmi yoksa bu sinifin torunlarindanmi cagiriacaginin belirlenmesi run time da gerceklesecektir.

    // Ornek:

    /* A)Object Member1,Member2,SanalMember3
     * B)Object : A
     * 
     * Member1 ve Member2 sanal olmadigi icin derleme zamani hangi nesneden cagirilabilecekleri bilinmektedir.
     * Lakin bu Member3 sanal oldugu icin A dan miras alan B clasinda ezilip ezilmeme/iptal edip yeniden yazilma durumuna gore ya A Object den cagirilacaktir yada B Objectden cagirilacaktir.Eger Adan cagirirsak memberin ilk versiyonunu eger B den cagirirsak memberin istedigimiz gibi degistirdigimiz versiyonunu cagiricaz.Iste bu davranisin karari ancak Run Time de anlasilir derlemede belirlenemez.
     * 
     * 
     * Eger ki bu sanal member ezilmezse/iptal edilmezse B Objectine miras edilecek lakin tanimlandigi A Objectinden cagirilicaktir.
     * Yok eger ezilir/iptal edilir ve yeniden yazilirsa,artik bu islemin yapildigi torununun (B) bir memberi olacaktir ve B Objectinden cagirilacaktir.
     * 
     * Sanal yapilarda cagirilan memberin hangi ture ait oldugu Run Time da belirlenir.
     * 
     * Metot ya da Property fark etmez.Bir sanal memberin hangi ture ait oldugunun bu sekilde run time da belirlenmesine (Gec Baglama - Late Binding) denir
     * 
     * 
     * 
     */


    // Sanal Yapilar Ne Icin Kullanilir ?  ---------

    /*Bir sinifta tanimlanmis olan herhangi bir memberin kendisinden tureyen alt siniflarda Name Hiding durumuna dusmeksizin ezilip/yeniden yapilandirilmasi icin kullanilir.
     * 
     * Peki bu zorunlumudur?Yani bir sanal yapi illaki kendisinden tureyen torunlarda ezilmek/yeniden yazilmak zorundamidir?
     * 
     * Tabikide hayir.Yani bir member sanal yapildi diye illaki kendisinden tureyen alt siniflarda ezilmek zorunda degildir.Ama ezilmek istenirse de Name Hidinge bulasmadan direk ilgili sinifin bir memberi olacak sekilde calismasini saglamis olur.
     * 
     *Eger bir memberin ezilmesi ve davranisinin degistirilmesi isteniyorsa bu member kesinlikle sabal olmalidir.Mumkun mertebe Name Hiding den kacicaz    * 
     * 
     */

    // Bi Sinifta Sanal Yapi Nasil Olusturulur:   virtual  KEYVORDU -----------


    //Bir sinifta sanal yapi olusturabilmek icin ilgili member in(metot ya da property) imzasini virtual keywordu ile isaretlemek yeterlidir.
    //public virtual  yada  virtual public

    //Ornek:

    class MyClass
    {
        public void MyMethod() // Normal Metot
        {

        }
    }


    class MyClass
    {
        public virtual void MyMethod() // Virtual Metot
        {

        }
    }


    // Ornek

    class MyClass
    {
        public int MyProperty { get; set; } // Normal property
    }


    class MyClass
    {
       virtual public int MyProperty { get; set; } // Virtual property
    }


    // Sanal Yapilar Nasil Ezilir ?  Override Keywordu -------------

    /*Bir class ta virtual ile isaretlenerek sanal hale getirilmis bir member(metot yada property) bu class tan miras alan torunlarinda ezilmek/yeniden yazilmak isteniyorsa eger ilgili class ta imzasi override keywordu isaretlenmis bbir vaziyetde tekrardan ayni member olusturulur
     * 
     */

    //Ornek :

    class MyClass
    {
        public virtual void MyMethod()  
        {
            //Bu ata classda  alt classda degistirmek istedigimiz fonksionu virtual ile isaretledik
        }

    }


    class MyClass2 : MyClass
    {
        public override void MyMethod()
        {
            // Bu torun classda ata clasda virtual ile isaretledigimiz metodu override ile degistirmek icin hazirladik
        }
    }

    // Base class ta ya da atalarda virtual ile isaretlenerek sanallastirilmis herhangi bir member torunlarda illaki override ile ezilmek zorunda degildir.

    //Ama bir torun class base classdaki herhangi bir memberi override edecekse eger o memberin kesinlikle virtual ile isaretlenmis olmasi gerekmektedir.

    //Virtual ile isaretlenmemis bir member kesinlikle override edilemez

    //virtual bir memberin override ile ezilmesine direkt olarak override etmek diyecegiz.

    //Override keywordunu ilerde Abstract Class larin impelemantosyonunda da kullanicagiz.simdilik ne oldugunu salla.Zamani gelince konusacagiz.


    // Ornek:


    class Obje
    {
        public virtual void Metot()
        {
            Console.WriteLine("Ben bir objeyim");   // 1) Obje adinda Base class olusturup degistirilebilir virtual metot yazdik
        }
    }

    class Kalem : Obje
    {
        public override void Metot()
        {
            Console.WriteLine("Ben bir kalemim"); // 2)Inheritance ile Obje base clasindan gelen Metot adli Baseclass Metodumuzu  override ile degistirdik

        }
    }

    class Terlik : Obje
    {
        public override void Metot()
        {
            Console.WriteLine("Ben bir terligim"); //3)Inheritance ile Obje base clasindan gelen Metot adli Baseclass Metodumuzu  override ile degistirdik
        }
    }


    static void Main(string[] args) // 4) Kalem ve Terlik claslarimizin nesnelerini olusturduk ve override ile degistirdigimiz metotlarimizi cagirdik
    {
        Kalem kalem = new Kalem();
        kalem.Metot();

        Terlik terlik = new Terlik();
        terlik.Metot();


    }



    // IKIDEN COK HIYERARSIK KALITIM DURUMUNDA OVERRIDE DURUMU: -----------------------

    /*Bir classta virtual ile isaretlenmis herhangi bir member illaki direkt o class tan tureyen 1.ci dereceden classlar da override edilmek mecburiyetinde degildir
     * 
     * Ihtiyaca binaen alt seviyedeki torunlardan herhangi birinde override edilebilir.
     * 
     * Lakin boyle bir durumda kritik bir durum vardir.Oda ilgili soyut memberin en son override edildigi Object den sonra gecerli olduudur.
     * 
     * Ve o objectden sonra hiyerarsik olarak turetilen siniflar varsa onlardada override islemi gerceklestirilebilir.
     * 
     * Ornek:
     * 
     * A Object
     * virtual 
     * 
     * B Object : A
     * 
     * C Object : B
     * Override
     * 
     * D Object : C
     * 
     * E Object : D
     * Override 
     * 
     * Yukaridaki ornekte C clasinda (B den gelen onada A dan aktarilmis) virtual memberi override ile degistirdik.
     * 
     * Daha sonra C den D ye ve ondanda E ye aktarilan degistirilmis Memberi tekrar degistirdik E de override ile.Tabiki C den alinan ve ya C nin alkt claslarindan alinan member artik C de degistirilmis versiyon olacaktir.
     * 
     * Her nekadar override edilmis olsada ozunde virtual oldugu icin kalitimsal acidan hiyerarsik olarak devamindaki class lardan override edilebilmektedir.
     * 
     */


    // Ornek :


    class Memeli
    {
        public virtual void Konus()
        {
            Console.WriteLine("Ben konusmuyorum");   
        }
    }

    class Maymun : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben bir Maymunum"); 
        }
    }

    class Inek : Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("Ben bir Inegim"); 
        }
    }


    static void Main(string[] args) 
    {
        Maymun maymun  = new Maymun();
        maymun.Konus();

        Inek inek = new Inek();
        inek.Konus();


    }



    //Ornek  2 : Geometrik Hesaplamalar

    // Protected - ile isaretlenmis herhangi bir member sadece ilgili sinifta yahut o siniftan kalitim almis olan siniflarin icerisinde erisilebilir.Amma ve Lakin nesne uzerinden erisilemez.

    static void Main(string[] args)
    {
        Ucken u = new Ucken(3,4);
        Console.WriteLine(u.AlanHesapla());

        Dortken d = new Dortken(3,4);
        Console.WriteLine(d.AlanHesapla());

        Dikdortken dd = new Dikdortken(3, 4);
        Console.WriteLine(dd.AlanHesapla());
    }




    class Sekil  //  Sekil isminde Base clasimizi olusturduk 
    {
        protected int _boy;
        protected int _en;

        public Sekil(int boy, int en) // ctor ile boy ve en bilgilerini alacagimizi belirtdik
        {
            _boy = boy;
            _en = en;
        }

        public virtual int AlanHesapla()  // Metot olusturduk virtual yaparak degistirilebilir ozellik atadik
        {
            return 0;
        }

    }


    // Asagida 3 sekil icin classlar olusturduk ve ctorlarindan base clasin ctoruna boy ve en leri gonderdik.Daha sonra hepsine Sekil clasini kalitim ile atadik tabi once.Daha sonra sekil clasimizda virtual yaptigimiz Alanhesapla() metodunda herbir sekil clasimizda override ile degistirdik.


    class Dortken : Sekil   
    {
        public Ucken(int boy,int en):base(boy,en)
        {
           
        }

        public override int AlanHesapla()
        {
             return boy * en / 2;
        }
    }

    class Kare : Sekil
    {
        public Kare(int boy, int en) : base(boy, en)
        {
            
        }

        public override int AlanHesapla()
        {
            return boy * en;
        }
    }

    class Dikdortken : Sekil
    {
        public Dikdortken(int boy, int en) : base(boy, en)
        {
            
        }

        public override int AlanHesapla()
        {
            return boy * en;
        }
    }



    // Ozet

    // 1) Sanal yapilar OOP de Poliformizm(Cok Bicimlilik) uygulayan yapilardir(Ileride gorecegiz)
    // 2) Sanal yapilarin en onemli ozelligi Gec Baglam(),Late Binding
    // 3) Eger bir member sanal olarak bildirilmemisse derleyici nesnelerin tur bilgisinden faydalanarak derleme zamaninda hangi nesneden ilgili memberin cagirilacagini bilir.
    //4) Eger bir member sanal olarak bildirilmisse ilgili memberin hangi nesne uzerinde cagirilacagi run time de belirlenir.
    //5) Hangi memberin Run time de belirlenmesine Late Binding denir.
    //6) Sanal yapi olusturabilmek icin ilgili memberi virtual keyvordu ile isaretlemeliyiz.
    // 7) Tureyen yapilarda sanal yapiyi ezebilmek icin override kullanilir

    //8) Tureyen siniflar sanal yapilari override etmek zorunda degiller
    // 9)Ilerde gorecegimiz  Static yapilanmalar sanal olarak bildirilemezler.









}
