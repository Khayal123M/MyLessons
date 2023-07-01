using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Record_Nedir_OOP_deki_yeri
    {

        /*  ----------- Record u anlaya bilmek icin Once (Init-Only Properties) anlamamiz lazim.-------
         * 
         * --------- Init - Only Properties   nedir? ------------
         * 
         * C# 9.0 da, herhangi bir nesnenin propertylerine ilk degerlerinin verilmesi ve sonraki surecte bu degerlerin degistirilmemesini garanti altina almamizi saglayan bir ozelliktir.
         * 
         * Bu ozellik sayesinde nesnenin sadece yaratilis aninda propertylerine deger atanmakta ve boylece is kurallari geregi runtime de degeri degismemesi gereken nesneler icin ideal bir onlem alinmakta
         * 
         * Bu sayede Nesnelerimiz sadece ReadOnly olmakta.Aslinda biz zaten ReadOnly ozelligini kullana biliyoruz lakin Init-Only Property nin daha farkli ozellikleri vrdir.Burada onemli olan konu (Nesnenin sadece ilk yaratilis halinde deger atanmasidir). Read Only olan bir nesneye Ilk yaratilis halinde deger atayamiyoruz.
         * 
         * Yani Init-Only Property - hem readonly yapiyor nesnemizi hemde iilk yaratilis aninda deger atamamizi sagliyor.
         * 
         * Bunun disinda birde ierdeki derslerdeki gorecegimiz Constracture metodunda vere biliyoruz.
         */




        //Olusturdugumuz Clasimizin icindeki property sadece Get metoduyla Read Only olarak tanimladik. ve nesne olusumunda 3 degrini atadik.Bu yontemin sorunlu tarafi Referansla nesne olusturup parantez icerisinde Intiliazer yontemi ile propertye ulasip deger atyamiyoruz.
        MyClass my = new MyClass();
        {
            MyProperty =3  // Bu islemi gerceklestiremiyoruz.
        }


    class MyClass
    {
        public int MyProperty { get; } = 3 // Bu islemi gerceklestire biliyoruz
    }


    // Init Only Property Ornek

    //2) book adinda referans ile Book clasimin nesnesini olusturdum.
    // Parantez(Object Initializer) ile ilk degerlerini atadim readonly olmalarina ragmen
    //Ama  daha sonra degisiklik yapmak istedigimde izin vermeyecek.Cunki sadexe ReadOnly

    Book book = new Book
    {
        Autor = "Kutsal ISyan",
        Name = "Hasan Izzet Dinamo"
    };

    book.Name = "Sabuncuoglu Serafettin"; // Degisiklik yapmaya izin vermeyecek






    // 1)Asagida Book clasi olusturduk. Icerisinde Name ve Autor adinda 2 property olusturduk.
    
    //Her iki propertyi Init - Only yaptik(Readonly yalnizca ama disardan deger ekleye biliyoruz.
    class Book
    {
        public string Name { get; init; }
        public string Autor { get; init; }


    }


    // Eger ihtiyac duyarsak Init-Only Property lerimize ilk deger atamasini disardan referans olusturmaya gerek yoksa Clasimiz icerisindede 2 usulle yapa biliriz.
    // Otoproperty  ve Constractor
    // Ornek :


    class Book
    {
        public string Name { get; init; } = "Kutsal Isyan"; //Otoproperty 
        public string Autor { get; init; }
        public Book()  // Constaktor
        {
            Author = "Hasan Izzet Dinamo";
        }


    }


    // Yani kisacasi eger Propertymizi istersek Sadece Read Only kullanmak icin set metodunu silmemiz yeterli.
    //Ama eger disardan 1 kereye ozgun deger atamak ve birdaha degismemesini saglamak istiyorsak set metodunu silip yerine init yazmamiz gerek
    //Ozellikle Object Initilazerde (nesne baslatici parantez) deger atamak yazilimcilara cok kolaylik sagladigindan dolayi Init-Only Property bu sebeple gelistirilmistir.



    //Readonly olan bir field in sadece okuna bilir olmasi lazim.Bu sebeple proportysini olustururken set metodu ile deger atamaya calisirsak hata verir.Ama set degil init olarak degistirirsek buzaman olusum surecinde birkereye mahsus deger atamasina izin verilir.Lakin bu atanmis deger degistirilemez
    class MyClass
    {
        readonly int a;

        public int A
        {
            get
            {
                return a;
            }

            init
            {
                a = value;
            }
        }






    }



    //----------------------- Record Nedir(Ulasila bilir ama degistirilemez Classlar) -----------------------------------------

    /*Eger tek bir Propertyde Sabitlik / Degismemezlik/ReadOnlylik istiyorsak ozaman Init - ONly Propertie kullanilir.
     * 
     * Eger ki bir objeyi butunsel olarak degismez yapmak istiyorsak o zaman bu ihtiyac icin Record Turu gelistirilmistir:
     * 
     * Record , bir objenin topyekun olarak savit / degismez olarak kalmasini saglamakta ve bu durumu guvence altina almaktadir.
     * 
     * Boylece bu obje artik degeri degistiri;emeyeceyinden dolayi esasinda objeden ziyade bir deger gozuyle bakilan bir yapiya donusecektir.
     * 
     * Nesne on plandaysa bu class,nesnenin degerleri on plandaysa bu recorddur.
     * 
     * Ozunde bir referans tipli deger yani classdir aslinda
     * 
     * Recordlar,classlara istinaden objeden ziyade icerisinde bulunan datalari sabitleyerek nesneden ziyade verilerini datalarini one cikarmaktadir.
     * 
     * 
     * Record nesnelerinin en büyük avantajı, eşitlik, eşleme ve desen eşleme işlemleri için daha uygun olmalarıdır. Record nesneleri, varsayılan olarak GetHashCode, Equals, ToString ve diğer yöntemleri otomatik olarak oluşturur, bu sayede C# programlamacılarına kod yazmayı daha basit ve anlaşılır hale getirir. Ayrıca, Record nesneleri, sınıf yerine kullanılabilir ve daha az kod yazma ile daha fazla işlevsellik sağlar.

      Record nesneleri, değerleri değiştirilemeyen verileri tutmak için idealdir. Örneğin, bir müşteri adı, müşteri numarası veya bir ürün fiyatı gibi değerler, değiştirilmeden saklanabilir. Bu tür veriler, Record nesneleri kullanılarak temsil edilebilir ve daha güvenli ve tutarlı bir şekilde işlenebilir.
     * 
     * Classlarda verisel olarak nesne on plandadir bir farkli referansa sahip olan nesne farkli olarak algilanmaktadir.Dolayisiyla Equls(x,y) karsilastirmasi yalnistir
     * 
     * Rekordlar ise verisel olarak degeri on planda tutmaktadir.Sadece nesnel olarak bu veriler bir objede tutulmakta lakin degistirilememektedir.
     * Haliyle farkli objelerdede olsa,veriler(property degerleri) ayni oldugu surece Equals(x,y) onermesi dogru olacaktir.
     * 
     * 
     * 
     * Ornek : Recorddan ve Classdan turetilmis 2 nesnenin esit olmasi olmamasi ornegi
     * Record icerisinde Class icerisinde olusturdugumuz butun elemanlari olustura biliriz
     * Recordda property olustururken setlerini init yapmak onerilendir.YApilmasada ayni islevi gorur.
     * 
     * 
     */

    //2) Daha sonra Hem Classdan hemde Recorddan 2 ser nesne olusturduk
    MyClass m1 = new MyClass()
    {
        MyProperty = 5
    };

    MyClass m2 = new MyClass()
    {
        MyProperty = 5
    };

    MyRecord m3 = new MyRecord()
    {
        MyProperty = 5;
    }

    MyRecord m4 = new MyRecord()
    {
         MyProperty = 5;
    };


//3) Daha sonra Classlarimizin birbirine esit olup olmadigini sorguladik.

Console.WriteLine(m1.Equals(m2)); // Bunu dondurdugumuzde False gelecek.Yani Ayni Classdan turetilsede 2 nesne farklidir yazilimsal deger olarak

Console.WriteLine(m3.Equals(m4)); // Bunu dondurdugumuzde True gelecek.YAni Ayni Recorddan olusturulan 2 nesne biribirine yazilimsal deger olarak esittirle





    //1) Ilk once bir Class ve Bir Record olusturduk
    class MyClass //Class olusturduk
    {

    }

    record MyRecord
    {

    }

// Ornek : Icerisinde init property tanimlanmi bir record: Bu sekilde tanimlanmis Recordlara( Norminal Record )denmektedir:

public record Book
{
    public string Name { get; init; }

    public string Autor { get; init; }
}


// Class icerisinde Init kullanimi ile Recordun farki.

//Normalde Record ile yapacagimiz herseyi Class icerisinde propertylerin setlerine Init atayarakta yapa biliriz.Lakin sonradan bu propertylerde degisiklik yapmak istedikde eger normal Class kullanmissam tekrar baska referansa atayarak onun object intiliazer(sagdaki parantez) kismindan el ile property degerlerimi tekrardan yeni nesne icin girip ordada istedigim degisikliyi yapa biliriz.Eger cok sayida property degisecekse bu oldukca vakit alacak. Lakin REcord kullanilmissa butur copyalama durumlarinda ( With Expression ) dan faydalana bilmekteyiz.

// Ornek : Bir record olusturup daha sonra icerisine  3 prop tanimlayacagiz.Bu recordu referansla nesne olusturup icindeki proplara object inilitizer ile deger atayacagiz.Daha sonra With kullanarak kopyalama yontemi ile yeni nesnelere bu nesnemizi kopyalayarak icerisinde degisiklikler yapacagiz








// 1) Burada Recordumuzun proplarini tanimladik

public record MyRecord
{
    public int Yas { get; init; }
    public string Isim { get; init; }
    public string Soyisim { get; init; }
}


//2)Recordumuza referans olusturduk ve proplarinin degerlerini atadik

MyRecord m1 = new MyRecord
{
    Yas = 25,
    Isim = "Hayal",
    Soyisim = "Mamedov"
    
};



//Recordumuzda degismek istedigimiz bir bilgi oldugu icin m1 referansimizi m2 referansina atayarak With ile degisiklik yaptik istedigimiz Propun bilgisine.
MyRecord m2 = m1 with { Yas = 28 };

MyRecord m3 = m1 with { Soyisim = Aliyev };



































