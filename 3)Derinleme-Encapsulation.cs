using HealthKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Derinleme_Encapsulation
    {

        /*   ----------------- ENCAPSULATION NEDIR ? ----------------------
         * Encapsulation, bir nesnenin verilerini ve işlevselliğini dışarıdaki diğer kodlardan gizlemek amacıyla kullanılan bir nesne yönelimli programlama kavramıdır.

          Bu, nesne ile ilgili bilgilerin diğer kodlar tarafından doğrudan erişilemez hale getirilmesi anlamına gelir. Bunun yerine, nesnenin bir arayüzü oluşturulur ve sadece bu arayüzü kullanarak verilere ve işlevselliğe erişilebilir.

         Encapsulation'ın amacı, kodun daha sürdürülebilir, güvenli ve esnek hale getirilmesidir. Sınıfın içindeki verilerin doğrudan erişimi yerine, bu verilerin nasıl kullanılacağına dair kısıtlamalar getirilir. Bu, nesnenin diğer kodlar tarafından yanlış kullanımını veya verilerin değiştirilmesini engeller ve böylece nesnenin tutarlılığını ve güvenliğini korur.

         Bu nedenle, encapsulation, nesne yönelimli programlamanın temel prensiplerinden biridir ve kodun yeniden kullanılabilirliğini artırmak ve kod karmaşıklığını azaltmak için kullanılır.
         * 
         * 
         * 
         * 
         * 
         * 
         */


        //Bir kod yazarken ilk hedefimiz verinin disardan erisilememesi olacak.Veri degerl veri olmasa bile bunu aliskanlik haline getirmek gerek.

        //Elimizden geldiyi kadar kapsulleme kullanicaz cok ufak bir risk ola bilecek veriye.Hic ihtiyac yoksada prop kullanicaz.

        //Encapsulation 2 usulla yapila bilmekte. 1)Eski usul MEtot ile  2 ) Yeni Usul Property ile

        //1) Metot ile Kapsulleme

        public int a ;


        public int AGet()
        {
                // Bu kisimda istedigimiz mudahileyi yapa biliriz a daki bilgiye disardan ulasilmak istendiginde
                return this.a;
        }

        public int ASet()
        {
            //Bu kisimda istedigimiz mudahileyi yapa biliriz a ya disardan deger atanmadan once
            this.a = Value;
        }



        //------------ 2) PROPERTY ILE ENCAPSULATION ---------------


        // prop + tab + tab       : Bize prop Enkapsulation sablonu verir
        // prop kullaninca field otomatikmen olusur ayrica olusutmamiza gerek yoktur
        public int MyProperty { get; set; }




        // propfull + rab + tab   : Bize Full Enkabsulation sablonu verir
        // FullProporty kullanimi icin field olusturmaliyiz once.Sablonda bir field ornegide vermekte
        // Fieldler genellikle kucuk harfle ilk harfi olusturulur.Kapsullemede Buyuk harfle baslangici kullanilir
        // Field ile Property ayni veri tipine sahip olmak zorunda.Int se Int her ikiside
        private int myVar;

        public int MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }


        //  Bunlarin degerlerine ulasmak icin once bunlari kapsayan Clasimizdan nesne olusturulmali ve referans atanmali.Daha sonra referans ile veri okuma ve ya veri atama islemleri yapa biliriz.

        MyClass x = new MyClass();

        x.MyVar = 1234;   // MyVar kapsul ismimizi kullanarak fieldimize veri gonderdik

        Console.Writlane(x.MyVar);  // x referansimiz ve MyVar kapsul ismimizi kullanarak myVar Fieldimizin verisini yazdirdik

        //Tabiki eger kapsulleme yapiyorsak get ve set metotlarimiz icerisinde veri okuma ve yazma islemlerinde istedigimiz mudaheleleri etmemiz gerek.



    }
}
   