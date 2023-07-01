using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class _95_Nesneler_arasi_iliski_turleri_Association_Aggregation_Composition_
    {
        /*
         * 

        

       

        Bu üç ilişki türü arasındaki farklar, nesneler arasındaki bağlantının güçlülüğü, bağımsızlık derecesi ve yaşam döngüsü bağımlılıklarında yatmaktadır. Association genellikle zayıf bir ilişkiyi ifade ederken, Aggregation daha güçlü bir ilişkiyi temsil eder ve Composition en sıkı bağlantı
         * 
         *  is - a iliskisi 
         *  has - a iliskisi
         *  can - do iliskisi
         * 
         * 
         * Aşağıda verilen iliski türleri nesneler arasındaki farklı ilişki türlerini açıklar:

       "is-a" İlişkisi (Türüdür): "is-a" ilişkisi, nesneler arasında tür ilişkisini ifade eder. Bu ilişki, kalıtım veya miras (inheritance) ( : )kavramıyla ilişkilidir. Bir nesne, başka bir nesnenin bir alt türü veya özelliğini taşıyorsa, "is-a" ilişkisi vardır. Örneğin, "Köpek" sınıfı, "Hayvan" sınıfının bir alt türüdür. Bu durumda, "Köpek" is-a "Hayvan" ilişkisini ifade eder.

                                            A is  a B    ; A bir B dir yani B den turetilmistir

        class Araba
        {

        }

        class Opel : Araba
        {

        }




       "has-a" İlişkisi (Sahiptir): "has-a" ilişkisi, bir nesnenin başka bir nesneye sahip olduğunu ifade eder. Bu ilişki, bir nesnenin diğer nesneyi içermesini veya bir nesnenin diğer nesneye referans vermesini ifade eder. Örneğin, bir "Araba" nesnesi bir veya daha fazla "Tekerlek" nesnesine sahip olabilir. Bu durumda, "Araba" has-a "Tekerlek" ilişkisini ifade eder.


                                       A has a B     ; A nin B si vardir
        class Opel
        {
            Motor motor;
        }

        class Motor
        {

        }



      "can-do" İlişkisi (Yapabilir): "can-do" ilişkisi, bir nesnenin belirli bir yeteneği veya işlevi yerine getirebileceğini ifade eder. Bu ilişki, bir nesnenin bir işlemi gerçekleştirebilmesini veya belirli bir eylemi yapabilmesini ifade eder. Örneğin, bir "Öğrenci" nesnesi "Ödev Yapabilir" veya "Sınav Çözebilir" gibi eylemleri gerçekleştirebilir. Bu durumda, "Öğrenci" can-do "Ödev Yapma" ilişkisini ifade eder.

        Bu iliski Interface yapilanmasinin getirdigi bir iliski turudur.   Interface nedir?

        Bir "interface" (arayüz), programlama dillerinde, sınıfların uygulamasını beklenen metodları ve özellikleri tanımlayan bir yapıdır. Bir interface, belirli bir işlevselliği tanımlar ve bu işlevselliği uygulamak isteyen sınıflar tarafından gerçekleştirilebilir.

       Interface'ler, bir nesnenin hangi metodları ve özellikleri sunması gerektiğini belirlemek için kullanılır. Interface'ler, sınıf hiyerarşileri arasında ortak bir sözleşme sağlamak ve kodun esnek ve modüler olmasını sağlamak için önemli bir araçtır.

       Bir interface, yalnızca metodların ve özelliklerin imza tanımlarını içerir, yani metodların gerçek uygulamalarını içermez. Bu, bir interface'i, birden fazla sınıfın aynı işlevselliği sağlamasını sağlayan bir sözleşme veya şablon olarak düşünebileceğimiz anlamına gelir.

       Bir sınıf, bir interface'i uyguladığında, interface'de tanımlanan tüm metodları ve özellikleri gerçek uygulamalarıyla birlikte sağlamak zorundadır. Böylece, farklı sınıflar aynı interface'i uygulayarak aynı işlevselliği sağlayabilir ve bu sınıfları interface tipiyle kullanabiliriz. Bu, kodun daha esnek olmasını ve birlikte çalışabilirliği artırmasını sağlar.


        Interface ler iclerindeki memberlerin imzalarini classlara uygulattigindan dolayi o interfaceler ilgili nesnelerin yapabilecekleri kabiliyetleri gostermektedir

        class A                         interface B
        {                             {
        Metot imzasi ve govdesi         Metot imzasi

        Metot imzasi ve govdesi         Metot imzasi

        }                             }

        Bir Interface ye baktigimizda bu interfaceyi uygulayan nesnelerin hangi islemleri yerine yetire bileceyini gore bildigimiz icin bu iliskiye Can - do iliskisi denir
                         A can do B      ; A interface  B nesneye ye yaptira bilir

        Interface IAraba
        {
          void Gazla();
          void Frenle();
        }

        class Opel : IAraba
        {
         public void Gazla()
         {

         }
         
         public void Frenle()
         {

         }
        }

        Yukaridaki ornekte IAraba adinda bir interface olusturduk.I Interface demek.Icinde 2 metodun imzasini yazdik.Opel adinda class olusturduk ve IAraba interface sini Implemente ettik Opel clasina.(Eger : nin sag tarafinda Interface ise  ozaman kalitim degil implemente islemidir). Opel clasimizin icerisinde metot imza ve bodylerini yazdik.



      Bu iliski türleri, nesneler arasındaki farklı ilişki türlerini ve bunların doğasını ifade etmek için kullanılır. İlişkiler, nesnelerin birbirleriyle olan bağlantılarını ve işlevlerini anlamamıza yardımcı olur.
         * 
         * 
         * 
         * 
         * Nesneler arasındaki ilişki türleri, nesnelerin birbirleriyle nasıl ilişkili olduğunu ve bu ilişkilerin doğasını ifade eder. Üç temel ilişki türü aşağıda açıklanmıştır:

          Association (İlişki): İki veya daha fazla nesnenin birbirleriyle ilişkilendirilmesidir. Association, bir nesnenin diğer nesneleri kullanması veya referans vermesi anlamına gelir. İki nesne arasındaki ilişki, bağımsız olarak kalabilir ve bir nesne diğerinden bağımsız olarak var olabilir. İlişkideki nesnelerin ömürleri birbirinden bağımsızdır. Association ilişkisi genellikle "bir ilişkisi" olarak ifade edilir. Örneğin, bir "Okul" nesnesi, bir veya daha fazla "Öğrenci" nesnesiyle ilişkilendirilebilir.
          Mes: Bir otobusde giden yolculardan biri indiginde digerlerine ve otobuse herhangi bir etki etmez yani zayif baglantili iliski turudur.
          Parca butun iliskisi yoktur
          Siniflar kendi arasinda iliskilidir ama birbirlerinden bagimsizdirlar
         * 
         * 
         * 
         * 
         * Aggregation (Birleştirme): Aggregation, "bir parçanın bir bütüne ait olması" anlamına gelir. Bir nesnenin, diğer nesneleri içerebileceği veya onlardan oluşabileceği bir ilişki türüdür. Aggregation ilişkisinde, parça nesnelerin birleşimi olan bütün nesne tarafından kontrol edilen bağımsız nesneler söz konusudur. Parça nesneler, bütün nesne yok olsa bile var olabilirler. Aggregation ilişkisi genellikle "birleşimi" ifade eder. Örneğin, bir "Üniversite" nesnesi içinde birden çok "Fakülte" nesnesi bulunabilir ve fakülteler üniversite olmadan da var olabilir.
         * 
         *  Composition (Bileşim): Composition, "bir parçanın bir bütünün bir parçası olduğu" anlamına gelir. Composition ilişkisinde, parça nesneler bütün nesneye sıkı bir şekilde bağlıdır ve bütün nesne yok olduğunda parçalar da yok olur. Bütün nesnenin yaşam döngüsü, parçalarının yaşam döngüsüyle doğrudan ilişkilidir. Composition ilişkisi genellikle "bileşimi" ifade eder. Örneğin, bir "Araba" nesnesi, bir "Motor" nesnesini içerebilir ve motor olmadan bir araba var olamaz.
         * 
         *  Aggregation - Composition      Ortak Yonleri;
         *  
         *  - Nesneleri birlestirip daha buyuk bir nesne yapmaya verilen isimlerdir
         *  -Yani her ikiside birlestirilmis nesnelerden butunsel nesneler yapma durumlarini ifade eder.
         *  -Her ikisinde de Association da olmayan parca-butun iliskisi soz konusudur.
         *  -Her ikisindede sahiplik (has - a) iliskisi vardir
         * 
         * 
         *  Aggregation - Composition      Farkli Yonleri;
         *  
         * Aggregation - Sahip olunan nesnenin,sahip olan nesneden bagimsiz bir sekilde var olabilmesi durumudur.
         * 
         * Composition - Sahip olunan nesnenin,sahip olan nesneden bagimsiz bir sekilde var olamamasi durumudur.
         * 
         * Misal:
         * 
         * Bir arabayi dusunursek eger,bu arabanin tekeri ile vitesi arasindaki iliski Aggregation yada Composition acisindan degerlendirirsek.
         * 
         * Bu araba teker olmadan olmaz lakin teker araba olmadan da kendi basina ayri olarak var olabileceginden dolayi araba ile teker arasindaki iliski Aggregation dur.
         * 
         * Benzer mantikla bu araba vites olmadan da olmaz lakin vites araba olmadan bir anlam ifade etmeyeceginden dolayi araba ile vites arasindaki iliski Compositiondur.
         * 
         */
    }
}
