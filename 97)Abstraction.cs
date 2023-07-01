using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.UserProfile;

//Abstraction - Soyutlama

//Abstraction,bir sinifin memberlerinden ihtiyac noktasinda alakali olanlari gosterip,alakasi olmayanlari gostermemek demek oluyor.

/* Abstraction bir mantikdir,davranstir yani bir programlama ozelligi degildir.
 * Interface ve Abstract classlari anlaya bilmemiz icin oncelikle Abstraction mantigini anlamamiz gerek.
 * 
 * Kullanici islemlerinden sorumlu olan bir sinif dusunelim
 * 
 * Bu sinifi kullanarak bir kullanici dogrulamasi gerceklestirmek istedigimizi varsayalim.
 * 
 * Bu islem icin ilgili siniftan uretilmis bir instance(nesne) ihtiyacimiz oldugu asikardir.
 * 
 * Kullacnici dogrulamasi yapmak istiyoruz ama Dogrulama isleminin disinda bu sinifdaki kullanici islemlerine dair tum memberler karsimizda.
 * 
 * Sizce kullanici dogrulamasi yapmak istedigimiz bir anda dogrulama isleminin disindaki memberlerin gelmesi nekadar saglikli?
 * 
 * Bir Class icerisinde onlarca belki yuzlerce member ola bilir buzaman bize gerekli memberleri nesnemizi kullandigimizda . dan sonra gelen memberler arasindan bulmak zorlasi ve hatali member secmek ihtimalimiz artar.
 * 
 * Kullanici eger dogrulama yapacaksa en ideali sadece dogrulama icin gerekli memberlere erise bilmemiz.
 * 
 * Yani bu durumu soylede dusune biliriz.Bir tesisatcinin is yaparken o anda ihtiyaci olan aletlerin gozunun onunde kalmasi isini kolaylastirir.
 * 
 * Ayni mantik yazilimcilar icinde gecerli.O anda ihtiyac duydugu memberleri ayirt etmek yazilimcilar icin sikintili durum yarata bilirki yazilimcilar ister istemez yalnis metodu sece bilir yahut konuyla alakasiz memberler konsantrasyonu boza bilir.
 * 
 * Abstraction sadece Interface ve Abstract class demek degildir.Jersekilde uygulana bilir ama en rahat uygulana bilecek araclar bu ikisidir.
 * 
 * 
 * 
 *                      Abstraction Nasil Uygulanir ? 
 *                      
 * 1)Bir operasyon aninda,kullanilicak sinifin sadece o anki operasyona uygun memberlerini getirebilmek icin (Yani Abstraction uygulaya builmek icin ) ilgili memberleri temsil ede bilecek referanslara ihtiyacimiz olacak
 * 
 * 2)Bunu normal siniflarla oyle yada boyle gerceklestirebilirsiniz lakin bu davranisi uygularken sadece interface ler yahut abstract classlar diger yapilara gore daha elverisli olabilmektedir
 * 
 * 3)Siniflarin birden fazla interface ile implement edilebilmeleri,ilgili sinifin birden fazla referansla refere edilebilmesi anlamina geleceginden dolayi,interface lerin abstraction islemi icin oldukca yaygin olarak kullanilan yapilar oldugunu dusunebiliriz.
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */




namespace Dersler.Dersler
{
    UserService userService = new();

    IUserValidateService userValidateService = userService;
    userValidateService.
    //Sadece IUserValidateService interfacesinde imzasi olanlar gelir

    
    IUserProcessService userProcessService = userService;
    userProcessService.
    // Nokta ile birlikte sadece IUserProcessService interfacesinde imzasi olan metotlar geler.










    interface IUserValidateServise
    {
        bool ValidateUser(UserInfo userInfo);
    }

    interface IUserProsessService
    {
        void CreateUser(UserInfo userInfo);
        void RemoveUser(int userId);
        List<User> User { get; set; }
    }


    
    class UserService : IUserValidateServise, IUserProsessService
    {
        public void Create(UserInfo userinfo)
        {
            //...
        }
        public void RemoveUser(int userId)
        {
            //...
        }
        
        public List<User> Users { get; set; }

        public bool ValidateUser(Userinfo userinfo)
        {
            //...
        }
    }

    //Yukaridaki Interface kullanimi orneginde Validate(Onaylama) ve Proses(Ekleme,SIlme...) islemlerin farkli 2 Interface de imzalarini olusturduk.Daha sonra Class olusturduk ve bu 2 interface mi base olarak Implement ile clasima atadim. (Class oldugunda Inheritance Interface oldugunda ise Implementasyon denir)

    //Clasimin icerisinde Interface lerde imzalarini olusturdugum elemanlarimin bodylerini yazdim.

    // Bir Clasa 1 den fazla Interface uzerinden ulasila bilir.Bu sayede artik metotlarini kullanmak istedigim interfacemi instance ederek icerisinden Clasimin icindeki hedef metotlarima ulasabilecegim.

    //Dikkat ederseniz eger abstraction davranisi ,memberleri ayikladigi icin (encapsulation),kalitimsal islem gerektirdigi icin(inheritance), ve farkli referanslar kullandirdigi icin (poliformizm) kavramlariyla dogrudan bagantili bir davranistir.

}

//                  Abstraction'in Etkisi Nedir?

//Abstraction davranisinin uygulandigi noktalarda,ilgili nesnelerin islevi nasil yapildigindan ote,ne yaptigiyla ilgilendigimizi ifade etmis oluyoruz.

//Bunuda genellikle interfaceler kullanarak bu davranisi gerceklestirdigimizden dolayi soyleyebiliyoruz.

//Ilgili Interface bizlere refere ettigi instance deki niteligi imza olarak soylemekte ama nasil bir islevsellik gosterdigine dair bilgi vermemektedir.

//Dolayisiyla abstraction,nesnenin isleri nasil yaptigini degil,hangi gorevleri yapabilecegini soylememizi saglamaktadir.

//Bu durumdanda su sonucu cikarabilirizki abstraction,bir sinifin belirli bir davranisinia sahip oldugunun garantisini saglamaktadir.

// Yani X, Y ve Z davranislarina sahip olan bir sinifin,abstraction ile sadece Y memberi erisilebilir ise bu durumda kesinlikle bu sinifta Y davranisinin oldugu garanti ediliyor anlamina gelmektedir.

//Bu garantiyi,ilgili sinifa abstraction mantigini Interface yahut abstract classlarla uyguladigimizda implementasyon zorunlulugu neticesinde saglayabiliyoruz


//                Abstractionun Hedefleri:

//Gereksiz ayrintilari Gizlemek gelistirici icin.

//O Siniftan uretilmis Instansi kullanirken sadece ne yapabilecegini gostermek ama nasil yapabilecegi ile ilgili bilgi vermemektir.

//Yerine gore uygulama ayrintilarini gizleyerek sadece ilgili davranislara erisilebilir olmasini saglamakta bir hedeftir.


























/* Abstraction (Soyutlama), C# programlama dilinde ve nesne yönelimli programlamada önemli bir kavramdır. Soyutlama, bir nesnenin önemli özelliklerini vurgulayarak ve gereksiz ayrıntılardan kaçınarak karmaşıklığı gizlemeyi ve daha yüksek bir seviyede anlaşılabilirlik ve kullanılabilirlik sağlamayı amaçlar.

Soyutlama, bir sınıfın veya veri yapısının yalnızca gerekli bilgileri ve işlevleri ortaya çıkarmasını sağlar. Bu, ilgilenilen özelliklere ve işlemlere odaklanarak, kullanıcıların nesneleri daha kolay anlamasını ve kullanmasını sağlar. Soyutlama, veri ve işlevlerin bir araya getirilerek daha yüksek seviyeli bir anlayış sunmasını sağlar.

C# dilinde soyutlama genellikle arayüzler (interfaces) veya soyut sınıflar (abstract classes) kullanılarak gerçekleştirilir. Bu soyutlama mekanizmaları, bir nesnenin belirli davranışlarını veya işlevlerini tanımlar ve somut sınıfların bu arayüzleri veya soyut sınıfları uygulayarak bu davranışları gerçekleştirmesini sağlar.

Soyutlama, programlamanın SOLID prensiplerinden biri olan "Liskov'un Yerine Geçme Prensibi"ne (Liskov Substitution Principle) de uyum sağlar. Bu prensip, bir nesnenin bir soyutlamayı yerine geçebilmesi gerektiğini belirtir. Yani, bir arayüz veya soyut sınıfı uygulayan herhangi bir sınıf, o soyutlama üzerinde çalışan kodla uyumlu bir şekilde kullanılabilmelidir.

Soyutlama, kodun daha modüler, yeniden kullanılabilir ve bakımı daha kolay hale gelmesini sağlar. Gereksiz ayrıntılardan kaçınarak, nesnelerin özünü ve temel işlevlerini vurgular ve daha anlaşılır ve esnek bir kod tabanı oluşturur.
 * 
 */





