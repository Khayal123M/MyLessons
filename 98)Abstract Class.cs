using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*               Abstract Class Nedir?
 *   icerisinde normal memberler barindirabilecegi  gibi kendisini uygulayan classlara zoraki      uygulatabilecegi memberlerin izmalarinida      barindiran bir yapidir.
    *               
    *Nesne tabanli programlamanin onemli kavramlarindan  ve davranislarindan biri inheritance (kalitim) dir.Kalitim sayesinde bizler siniflar arasinda hiyerarsik iliskiler olusturanilmekte ve nesneler icerisindeki elemanlarin miras yoluyla birbirlerine aktarabilmekteyiz
    *
    *Boylece ortak islevselliklerde sahip olam siniflari kalitimsal davranisla sekillendirerek tekrarli kod yazimini azaltmakta ve okunabilirlik ile yeniden kullanilabilirligi arttirabilmekteyiz.
    *
    *Abstract Class i, bu niyetle kullandigimiz kalitimsal davranisi daha farkli manevralarla kullanabilmek icin dusunulmus ve gelistirilmis olan bir nesnel yapi olarak tanimlaya biliriz.
    *
    *Abstract Class, ozunde kalitimsal davranis gostererek bir sinif uzerinde implemantasyon yapmamizi saglayan ozel bir yapilanmadir.
    *
    *Simdilik odaklanacagimiz nokta Abstract Clasin varlik sebebidir.Abstract class, bizlere yari somut bir sinif vermektedir.
    *
    *Yari somut siniftan kasdedilen ise icerisinde normal memberler barindirabilecegi gibi kendisini uygulayan classlara zoraki uygulatabilecegi memberlerin izmalarinida barindiran bir yapidir.
    * 
    * 
    */


namespace Dersler.Dersler
{

    abstarct class MyClass
    {
        public void X()
        {
            //...
        }

        public void Y() 
        {
           //...
        }

        public int Z { get; set; }

        abstract public void W();
        abstract public int Q();
        abstract public int H{ get; set; }
    }

    // Yukaridaki ornekte goruldugu uzere bir abstract class icerisinde normal member'lar tanimlanabilecegi gibi ,kalitimsal olarak bu abstract Clasi uygulayan siniflara zoraki olarak uygulattiracak member imzalarida tanimlanabilmektedir.

    //                       Abstract Class Neden kullanilir?


    //Yazilim surecinde abstract classlari kullanma nedeni herhangi bir ihtiyaca istinaden degildir.Bunlar tercihen kullanilan yapilardir.Eger hem normal Class gibi metot property belirte bileceyin hemde kendisini implemente edecek Classlara zorunlu olarak yaptirmak icin belirlediginiz memberlerinizin imzalarini tuta bilecek bir Clasa ihtiyaciniz varsa Abstract Class kullana bilirsinz.


    //              Abstract Clasin Yapisal Ozellikleri:

    /*Abstract Clasin ilk bilinmesi gereken ozelligi her nekadar abstract olsada ozunde bir classtir.Yani referans turlu bir yapilanmadir.Dolayisiyla abstract class turunden bellegin stack bolgesinde bir referans noktasi edinilebilir ve bu referansla heap te ki uygun nesneler isaretlenebilir.
     * 
     * --- Abstract Class ile Nesne arasindaki Iliski.
     * 
     * Abstract Classlar soyut yapilanmalar olduklari icin yapisal olarak iradeli bir sekilde (new operatoru ile ve.s) nesne uretilebilir bir tur degildir.
     * 
     * Ama bu Abstract Class turunden bir nesne hicbirzaman olamaz anlamina gelmemektedir.
     * 
     * Kalitimsal olarak bir abstract class herhangi bir sinifa miras verdigi taktirde buradaki davranis soyle olacaktir;
     * 
     * 
     */

    abstract class MyClass
    {

    }

    class MyClass2 : MyClass
    {

    }

    //Yukaridaki gibi kalitimsal durumun soz konusu oldugu durumlarda new MyClass2(); komutu ile MyClass2 isimli siniftan bir nesne uretilirse eger burada kalitimsal hiyerarsinin geregi olarak abstract classinda dahil normal class'in nesneleri uretilicektir.

    //Iste bu durumda abstract classlarin nesneleride varlik gostermektedir.


    //  ------     Abstract Classta Constructor Tanimlama:

    abstract class MyClass10
    {
        public MyClass10()
        {
            //...
        }
    }

    // Kalitimsal durumlarda abstract class larin nesneleri olusturuluyorsa eger bu constructorlari tetikleniyor demektir.Haliyle bizler irademizle her nekadar abstract classlardan nesne uretemesekte,icerisinde constructor tanimlayabilir ve kalitimsal sureclerdeki uretilecek olan nesneyi yapilandirabiliriz.

    // Ornek Olarak: Eger 1 Abstract Clasi bir Clasa implement etdiysek Clasimizdan nesne olusturdugumuzda once Abstract clasimizin Ctor u calisir sonra Clasimizin.Inheritance orneginde oldugu gibi.




    //                Tanimlama Ve Insa Etme :

    //1)Bir Abstract Clasi tanimlaya bilmemiz icin abstrect keywordu kullanmaliyiz.

    //2)Bir abstract clasi icerisindeki normal memberler bilinen normal kurallari ile eklenirler.

    //3)Bir abstract clasi implemente edecek classlarda zoraki tanimlanmasini isteyecegimiz member imzalarida eklenebilir.Bu imzalar,govdeleri ilgili alt siniflara birakilacak sekilde abstract keywordu ile isaretlenerek tanimlanmalidir.Tabi abstract keywordu ile tanimlanmis olan member imzalari kendilerini uygulayan siniflar tarafindan erisilecegi icin zoraki public olmak zorundadir.

    //4)Bir abstract class i uygulayan sinif icerisine normal memberler direk miras yoluyla aktarilirken,abstract ile isaretlenmis olan memberlar ise ilgili sinif icerisinde override edilmek zorundadirlar.

    //5) ctrl + . + enter    
    //overraid islemini implementa alan Class icersinde otomatik yapmak icin ya yukardaki kombinasyonu yada abstract class uzerine mausu getirdigimizde cikan hata bildiriminde ampule tiklayarak birinci secenegi secerek yapa biliriz.

    //6)Butun imzalar clas icerisinde override edilmezse derleyici calismaz hata verir.

    //7)Override edildikten sonra eger tekrardan bir imza eklenmisse o sonradan eklenen imzada mutlaka override edilmelidir.

    //8)Ayrica bir Class ayni anda birden fazla siniftan kalitim alamayacagi gibi abstract class i da uygulayamaz.

    //9)Abstract Clasi uygulayan/implemente eden Clasa terminolojik olarak Concrete Class denir.

    // Ornek :


    abstract class MyAbstractClass
    {
        int a;

        public void X()
        {

        }

        public int MyProperty { get; set; }

        abstract public void Z();

        abstract public void W(string a,int b);
        abstract public int Y { get; set; }
    }

    class MyClass11 : MyAbstractClass
    {
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void W(string a, int b)
        {
            throw new NotImplementedException();
        }

        public override void Z()
        {
            throw new NotImplementedException();
        }
    }

    //        Abstract  Clasin Abstract Clasa kalitim vermesi:

    //Bir Abstract Class baska bir Abstract Clasa kalitim vere bilir.

    //Burada dikkat ederseniz miras vermekten bahs ediyoruz implemantasyondan degil.

    //Bu dupeduz bir kalitimdir.Cunki abstract classlar iclerinde abstract olarak isaretlenmis olan yapilari zoraki olarak sadece kendilerini uygulayan Classlara uygylattira bilirler.Abstract Classlara degil.

    // Ornek :

    abstract class X
    {
        public void A() { }
        public void B() { }
        public void C() { }
        public abstract void D();
        public abstract void Z();
    }

    abstract class Y : X
    {
        public void E() { }

        abstract public void F();
    }

    class Z : Y
    {
        public override void D()
        {
            throw new NotImplementedException();
        }

        public override void F()
        {
            throw new NotImplementedException();
        }

        public override void Z()
        {
            throw new NotImplementedException();
        }
    }

    // Yukaridaki ornegimizde 2 Abstract Class 1 de normal Class olusturduk.X Abstract Y Abstracta inheritance verdik bu sayede hem X in normal memberlerini hemde abstract memberlerini tutdu ve ikiside abstract olduklari icin Override islemi gerceklestirilmedi.
    //Z Clasima ise Y Abstract Clasimi implemente ettigimde hem X deki hemde Y deki abstract metot imzalarini override etmemiz gerekti
    

    //  Ozetlersek:

    //-- Bir sinifin uymasi gereken temel yapiyi tanimlamak icin abstract class yapisini kullanabilir ve gerekli modellemeyi gerceklestirebilirsiniz.

    //--Abstract classlar bir cesit abstraction yapilanmasidir.Davranislarin var oldugunu garanti eder lakin davranisin implementasyonunu interfacelerde ki gibi zorunlu kilmaz.

    //--Abstract Classlar Interfaceler ile normal classlar arasinda bir yapidir.

    //--Abstract classlar bircok senaryo icin gecerli olabilecek genel davranislar saglayabilecegi ancak kimi senaryolar icin ise ozel davranislar barindirabilecegi bir sozlesmedir.

    //--Abstract class, dogrudan inheritance ve poliformizm ile baglantili bir kavramdir.Ozellikle Inheritance olmaksizin abstract class kullanilamaz.Keza inheritance amacli kullanilan yapi abstract class ise ozaman ordaki ifadeyi implementation denir.

    //Abstract classlar(interface ler de ayni sekilde) loose couplingi destekler.










}

