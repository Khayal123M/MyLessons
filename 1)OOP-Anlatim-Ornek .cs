using Android.Opengl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class OOP_Anlatim_Ornek
    {
    }


    /*Nesne yönelimli programlama (OOP), bir programlama paradigmasıdır ve programlama dünyasında oldukça yaygın olarak kullanılmaktadır. OOP, nesnelerin ve bunların birbirleriyle etkileşimlerinin merkezinde olduğu bir yaklaşımdır.

    OOP, veri ve işlevselliği bir arada tutarak, programlama sürecini daha organize ve modüler hale getirir. Bu yaklaşımın temelinde, nesnelerin birbirleriyle etkileşimi ve veri işleme yöntemleri yer alır. Nesneler, bir sınıfın örnekleri olarak tanımlanır ve her bir örnek birbirinden bağımsız olarak çalışabilir.

    OOP, birçok avantaj sunar. Örneğin, kodun tekrar kullanımını kolaylaştırır, hataları azaltır ve programlama sürecini daha kolay ve anlaşılır hale getirir. Ayrıca, OOP kullanarak, büyük projeleri daha küçük parçalara ayırarak yönetmek mümkündür.

    OOP'nin temel özellikleri arasında miras alma, çok biçimlilik ve kapsülleme yer alır. Miras alma, bir sınıfın özelliklerini başka bir sınıfa aktarma yeteneğini ifade eder. Çok biçimlilik, aynı sınıftan türetilmiş nesnelerin farklı davranışlara sahip olabilmesini sağlar. Kapsülleme, nesnelere ait verilerin ve işlevlerin gizlenebilmesini sağlar. Bu özellikler, OOP'nin esnekliği ve gücüne katkıda bulunur. 
    
     
     Nesne yönelimli programlama (OOP) kavramını, bir tiyatro sahnesiyle karşılaştırabiliriz.

    Bir tiyatro sahnesinde, her karakter bir nesneye benzer. Her karakter, belirli bir rolü oynar ve diğer karakterlerle etkileşime girer. Bu karakterlerin her biri, kendi özellikleri, davranışları ve iletişim şekilleriyle farklıdır. Bu benzerlikler, OOP'nin nesnelere dayalı yaklaşımıyla paralellik gösterir.

    Aynı şekilde, OOP'de de her nesne, kendi sınıfına ait özelliklere sahip olan bir varlık olarak düşünülebilir. Sınıflar, nesnelerin özelliklerini tanımlar ve nesneler, bu özelliklerin birer örneği olarak ele alınır. Nesneler, diğer nesnelerle etkileşim halinde olabilir ve belirli bir işlevi yerine getirebilir.

    Örneğin, bir araba nesnesi, bir sınıfın örneği olarak düşünülebilir. Bu nesne, özellikleri (renk, model, hız vb.) ve davranışları (hareket etme, durma vb.) olan bir varlık olarak ele alınabilir. Ayrıca, bu araba nesnesi, diğer nesnelerle etkileşim halinde olabilir, örneğin bir sürücü nesnesiyle veya diğer araç nesneleriyle.

    Bu benzetme, OOP kavramının temelini anlamamıza yardımcı olabilir. Nesne yönelimli programlama, nesnelere dayalı bir yaklaşımı benimseyerek, programlama sürecini daha organize, modüler ve yönetilebilir hale getirir.


    Nesne yönelimli programlama (OOP), nesnelerin birbirleriyle etkileşimleri üzerine kurulu bir programlama paradigmalarından biridir. OOP'nin temel özellikleri şunlardır:

    Sınıflar: Sınıflar, nesnelerin özelliklerini ve davranışlarını tanımlayan bir şablon olarak düşünülebilir. Bir sınıf, nesnelerin özelliklerini, metotlarını ve diğer niteliklerini içerir.

    Nesneler: Nesneler, bir sınıfın örneği olarak düşünülebilir. Her nesne, kendi özelliklerine ve davranışlarına sahip bir varlık olarak ele alınır.

    Miras alma: Miras alma, bir sınıfın özelliklerinin başka bir sınıfa aktarılmasıdır. Bir sınıf, başka bir sınıftan miras alarak, o sınıfın özelliklerini kendi bünyesinde kullanabilir.

    Kapsülleme: Kapsülleme, nesnelere ait verilerin ve işlevlerin gizlenmesini sağlar. Bu özellik, nesnelerin özelliklerine ve davranışlarına erişimi kontrol eder.

    Çok biçimlilik: Çok biçimlilik, aynı sınıftan türetilmiş nesnelerin farklı davranışlara sahip olabilmesini sağlar. Bu özellik, aynı sınıftan türetilen nesnelerin farklı özelliklerini kullanarak, farklı işlevleri yerine getirmelerini sağlar.*/


    /*  
       ----------------------- CLASIN ICERISINDE NELER TANIMLAYA BILIRIZ  (CLASS MEMBERS)---------------------

    1) Field : Nesne icerisinde veri depoladigimiz/tuttugumuz alanlardir.
               Class icerisindeki degiskenlerdir.Herhangi bir turden ola bilirler.  Mes:*/


    class MyClass
    {
        public int a;
        public string b;
    }

    // Olusturdugumuz clasa erismek icin  new kullanarak MyClass() nesnesi olusturub bunu MyClass tipinden n1 adlandirdigimiz bir referansa esitlicez.   Mes:
   
    MyClass n1 = new MyClass(); //Nesne Olusturduk

    //Artik n1. yazdigimida icerisindeki butun elemanlara erise bilicez.

    //Classlarin icerisindeki field lerimize erise bilmek icin public olarak isaretlenmis olmalari lazim . 

    // 1 Classdan istedigimiz kadar nesne turete biliriz.

    MyClass n1 = new MyClass();
    MyClass n2 = new MyClass();

    //Int olarak bir field olusturdukta eger bir deger atamamissak default olarak 0 dir.Ama bir Clas icinde olmayan deger atanmamis bir degisken default olarak 0 degildir.


    /* 
     * 
     2) PROPERTY :   
    Nesne icerisinde ozellik saglar ve esasinda bir metottur.Yani programatik/algoritmik kodlarimizi insa ettigimiz bir metot.
    Lakin fiziksel olarak metottan farki parametre almamasi ve icerisinde get ve set olmak uzere iki adet blok barindirmaktadir.
    Mes: Asagida int deger donduren bir metodumuz ve bunun proporty karsiligi var: 
     */

    //Metot
    public int x()
    {
        return 0;

    }

    //Prop
    public int x
    {
        get
        {
            return 0;
        }
        set
        {
            //Atanan veri buradan yakalanir
        }
    }

    //Proporty ye deger atanmak istedikte set blogundan degeri okunmak istedikte get blogundan okunur.
    //Proporty nin islevsel acidan metotdan bir farki yok.Lakin davranissal acidan nesne uzerinde bir deger okumak ve deger atama islemlerinde kullanilir.
    //Keza bu bloklar compile neticesinde get ve set isimli metotlar olarak karsimiza cikar.
    //Biz yazilimcilar nesnelerimiz icerisindeki fieldlere direk erisilmesini istemeyiz.
    //Dolayisiyla fieldler da ki verileri kontrollu bir sekilde disariya acmak isteriz.
    //Iste boy durumlarda proportyleri kullaniriz.Tabi bunun icin fieldlerimizi private olarak isaretlememiz lazim.

    //Iste biz proporty lerin bu oslevine Encapsulation(Kapsulleme/Sarmallama) diyecegiz.


    /*  ENCAPSULATION (KAPSULLEME/SARMALAMA)
     *   Encapsulation,bir nesne icerisindeki datalarin(field lerdeki verilerin) disariya kontrollu bir sekilde acilmasi ve kontrollu bir sekilde veri almasidir. 
     *   Eger proporty kullaniyorsak aslinda enkapsulation kullaniyoruz demektir
     *   
     *   PROPORTY IMZALARI :
     *   
     *   -Full Property  
     *   -Prop
     *   -Auto Property Initilaizers
     *   -Ref Readonly Returns
     *   -Computed(Hesaplanmis) Properties
     *   -Expression-Bodied Property
     *   -Read Only Property
     *   -Init-Only Properties ve Init Accessor 
     *   
     */

    // Full Property  : En sade property yapilanmasidir.Icerisinde get ve set bloklari tanimlanmalidir.

   /* [erisim belirleyicisi][geri donus degeri][Property adi]
    {
          get{     }  Propertyden veri istendiginde tetiklenir.
          set{     }  Propertiye veri gonderildiginde tetiklenir.Gonderilen veriyi Value keywordu ile yakalar
    }

   - Full propertylerde set blogu tanimlanmazsa sadece okunabilir(read only) bilakis get blogu tanimlanmazsa sadece yazilabilir(write only)olacak.
   - Property ler hangi fielde atanacaksa ayni tur olarak atanmasi lazim.Field int se Propertyde int.
   - Propertylerimize disardan ulasa bilmemiz icin fieldimiz private olsada propertymizi public yapmaliyiz.
   - Genellikle Property isimlerini temsil ettikleri fieldlerin bas harfi buyuk olarak veririz.
    Mes:
   */

    class MyClass
    {
        int yas;
        

        public int Yas
        {
            get 
            {
                return yas; //Burada istersek direk fieldimizi gondere biliriz yada uzerinde istedigimiz herhangi bir islem yapip onun sonucunu gondere biliriz.
            }

            set
            {
                value    = yas;// Property uzerinden deger fieldimize deger gonderildiginde set calisir.Encapsulation ile fieldimize disardan atanan degeri once sete aliriz.sonra istersek ustunde islem yapip yada fieldimize direk atariz.Propertynin degeri neyse value o turde degeri getirir
            }
        }
    }

    //Bu propertymize disardan ulasmak icin MyClass.yas  yazildiginda erisile bilir
    //Yas a deger ataya biliriz bu sekilde set blogunu tetikleriz.

    MyClass myClass = new MyClass(); //Referans ile Clasimizi cagirdik ve nesne olusturduk.

    Console.WriteLine(MyClass.Yas); // Propertymizin fieldinnen bilgi almak istedigimiz icin get metodu tetiklenir
    MyClass.yas = 65;  // Propertymizin fieldine bilgi gondermek istedigimiz icin set metodu tetiklenir.
    
        // ORNEK   : Bankamizdaki bakiye bilgilerini gostermeden uzerinde baska bir yazilimciya islem yapmasi icin ulasa bilmesini saglamak icin kapsulleme yaptik property ile


    class Banka
    {
        int bakiye;

        public int Bakiye
        {
            get
            {
                if (bakiye > 0)  //Bizden bakiye fieldimizdeki bilgi istendikte eger bakiye 0 dan buyukse bu islemi yap ve 10% ni gonder rakamin
                    return bakiye * 10 / 100;
                return 5;  
            }

            set
            {
                if(value < 10) // EGer fieldimize ekleme yapacaksa 10dan kucuk olmasi durumunda ata degilse 5% ni ata
                    bakiye = value;
                else
                    bakiye = value * 5 / 100;

            }
        }

    }

    // ReadOnly property: Eger bir propertynin set bloku atanmazsa ozaman get bloku ile disardan okuna bilir ama birsey atanamaz.

    // WriteOnly property : Eger bir propertynin get bloku atanmazsa ozaman set bloku ilde disardan deger atana bilir ama icindeki deher okunamaz.

    // Prop : Bir property encapsulation yapsada temsil ettigi fielddeki datayi hic mudahele etmeden erisilmesini ve veri atanmasini sagliyorsa boyle bir durumda kullanilan property imzasidir.
    //Prop propertyler compile edildiklerinde arkaplanda kendi fieldlerini olustururlar.Dolayisiyla bir field tanimlamaya gerek yoktur.
    // Prop imzalarda ilgili property read only olabilir lakin write only olamaz


    //       [erisim belirleyicisi][geri donus degeri][property adi]{ get; set }


    
    public int Yas { get; set; }
    //


    // Auto Property Initializers : 
    // Bir property nin ilk degerini nesne ayaga kaldirilir kaldirilmaz vere biliriz.
    // Ilk degeri probun sonunda vere bilmemizin sebebi prop arkada field de olusturur otomatik olarak ve bu deger o fielde atanir.
    //// Prop imzalarda ilgili property read only olabilir lakin write only olamaz.Yani set siz kullana biliriz ama getsiz kullanamayiz.

    class InsanEntity
    {
       
        public string Adi { get; set; } = "Gencay";
        public string Soyadi { get; set; } = "Yildiz";
        public int Yasi { get; set; } = 23;


    }

    //Eger fieldimize gelecek ve gonderilecek degerilerde bir mudahele yapmicaksak ozaman Prop kullanicaz ve Field kullanmicaz.
    //Eger herhangi bir degisiklik yapmak istiyorsak ozaman Field kullanicaz ve get set metodlarinda cikan sonuclarimizi bu fielde gondericez


    // Computed (Hesaplanmis) Properties :
    // Icerisinde turetilmis bir baglanti tasiyan propertylerdir. 
    // Mes : s1 = 5 ve s2 =  3 fieldleri olusturalim.Propertimizde get blogumuzda bunlari toplama islemi yapalim.Her tetiklenmede toplama islemini yaparak gonderecektir.
    //Terminolijik olarak bir isim verilsede normal get ve set uzerinde islem yaptigimiz propertylerden bir farki yoktur.
    int s1 = 5;
    int s2 = 3;

    public int Topla
    {
        get
        {
            return s1 + s2;
        }
    }

    
    //Expression-Bodied Property :
    //Tanimlanan propertyde LAmbda Expression kullanmanizi saglayan soz dizimidir.Mes:

    public string Cinsiyyet
    {
        get
        {
            return "Erkek";
        }
    }
    // Ustdeki gibi Cinsiyyet propertymize Erkek cinsiyet atayarak gondericeksek bunun yerine asagidaki gibi Lambda Expressionda kullanila bilir
    //Size sadece read only bir property saglayacaktir
    public string cinsiyyet => "Erkek";



    // Init-Only Properties - Init Accessor :
    //Developer acisindan surec icerisinde degistirilmemesi gereken property degerlerinin yalnislikla degistirilmesinin onunu gecmekte ve boylece olasi hata ve buglardan yazilimiu arindirmaktadir.



    // 3) METOT  :

    //Nesne uzerinde, fieldlerdeki yahut disardan parametreler esliginde gelen degerler uzerinde islemer yapmamizi saglayan temel programatik parcalardir.Mes:
    //Propertyler ile metotlar arasindaki fark ,Proportylerin kesinlikle bir turu olmali.Hicbir property void olamaz.Metotlar void ola bilir yani illa herhangi bir geri donus tipine sahip olmak zorunda degil.

    class  MyClass {

        int a;
        int b;

        public void X()
        {
            a + b;
        }

    }

    //Metodlara ulasmak icinde parantez calistirmak zorundayiz.

    MyClass myClass = new MyClass(); 

    MyClass.X();


        // 4) INDEXER :

        //Nesneye indexer ozelligi kazandiran,fitrat olarak propertyler ile birebir ayni olan elemandir.

        //[erisim belirleyicisi][geri donus degeri] this [parametreler]

        //Eger isim verirsen normal property olur eger this kullanirsan isim vermeden Indexer olur.

        public interface this[int a]
        {
            get
            {
            return a;
            }
            set
            {

            }
        }


    // Bu indexere asagidaki gibi ulasip parametre ataya biliriz

    MyClass myClass = new MyClass();  // MyClass in icerisinde oldugunu farz ederek once Clasina referans olusturuyoruz

    myClass[5] = 10;



        //    ----  ELEMANLARA ACIKLAMA EKLEME   -----


        /// <summary>
        ///   Aciklama bu kisma eklemek istedigimiz elemanin uzerinde yazilir 3 slas kullanarak.Eger mausla uzerine gelirsek aciklamayi goruruz
        /// </summary>  
        public int hayal { get; set; }



    //    ----    CLAS ICERISINDE CLASS OLUSTURMAK MUMKUN.BU CLASA ULASMAK ICIN UST CLASS.IC CLASS OLARAK ULASA BILIRIZ AMA BUNU OLUSTURMANIN HERHANGI BIR ISLEMSEL AVANTAJI YOKTUR.CLASS LARI IC ICE DEGILDE AYRI AYRI OLUSTURMAK MAKBULDUR.-----


    //       ----  THIS KEYWORDU  ----




    /*  This keywordu 3 ana amaca hizmet eder.
     *  
       C# "this" anahtar kelimesi, bir sınıfın içindeki bir yöntem veya özellik tarafından, sınıfın kendi kendine referansı olarak kullanılır. Yani, sınıfın özelliği veya yöntemi içinde olduğunuzda, "this" anahtar kelimesi, o anki sınıfın örneğini temsil eder. Bu, aynı sınıf içindeki diğer özellikleri ve yöntemleri çağırmak için kullanışlıdır. Ayrıca, sınıfın dışındaki bir özellik veya yöntem adı ile aynı isme sahip olan bir parametreyi belirtmek için de kullanılabilir.

     1)Sinifin Nesnesini temsil eder .
    This keywordunu heryerde cagiramayiz.SAdece Class memberleri(Elemanlari) icerisinde cagira biliriz.


     2)Ayni isimde Field ile Metot parametrelerini ayirmak icin kullanilir:

     3) Bir constructordan baska bir constructoru cagirmak icin kullanilir


     ORNEK  */

    class Person
    {
        private string name;

        public void SetName(string name)
        {
            // "this" anahtar kelimesi, sınıfın örneğini temsil eder
            // Bu nedenle, sınıfın name özelliğine atama yapmak için "this" kullanabiliriz
            this.name = name;
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, my name is " + this.name);
        }
    }

    Person person1 = new Person();
    person1.SetName("John");
person1.SayHello(); // Output: Hello, my name is John

//Yukarıdaki örnekte, "SetName" yöntemi "name" özelliğine atama yapmak için "this" anahtar kelimesini kullanır. "SayHello" yöntemi ise "this.name" kullanarak "name" özelliğine erişim sağlar.








