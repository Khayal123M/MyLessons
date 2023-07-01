using Android.Media;
using GoogleGson.Annotations;
using Java.Lang.Reflect;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Constructor
    {

        // --------------------- CONSTRUCTOR NEDIR --------------------------//

        /* Classlarimizin 3 ozel memberi vardir : 1) Constructor(kurucu) 2) Static Cobstructor 3 ) Distructor(Imha edici)
         * 
         *  Kisa yol :   ctor + tab + tab
         * 
         * Constructor - Bir fonksiondur : Diger Ozel memberlerde fonksionlardir.
         * 
         *  Bir nesne Olustururken new MyClass() seklinde olusturuyoruz.Iste buradaki () parantezi bir Constructordur:
         *  
         *  Yapici-Insa edici metot anlamina gelmektedir
         *  
         *  Nesne ilk ayaga kaldirilirken ilk konfequrasyonlari yaptigimiz metottur
         *  
         *  NEsne uretilirken belirli konfuqirasyonlar olsun istiyorsan bunun icin extra bir metot olusturmak yerine Constructorda yapa bilirsin
         *  
         *  Nesne uretilirken ilk tetiklenen fonksiondur.
         *  
         *  Nesne olusturulurken Constructer tetiklenmek zorundadir
         *  
         *  Constructor ile NEsne olusturulurken ilk degerleri ataya bilme sansina sahipsin ve ya baska ilk operasyonlarda saglaya bilirsin.
         *  
         *  Constructor new ile nesne olusturulduktan hafizada nesneye yer ayrildiktan sonra tetiklenir.Yani tetiklenirken nesne artik mevcuttur.
         *  
         *  Constructor ozel bir sinif elemani oldugu icin metot imzalarindan bir nebze farklidir.
         *  
         *  1)Metot adi sinif adiyla ayni olmalidir.(Ozel sinif elemanlari disinda hicbir memberin adi sinifiyla ayni olamaz)
         *  
         *  2)GEri donus degeri olmaz/belirtilemez.Void bile olamaz
         *  
         *  3)Erisim belirleyicisi public olmalidir(private olani ayrica incelenicektir)
         * 
         * Constructor (Yapıcı) C# programlama dilinde, bir sınıf nesnesi oluşturulduğunda çağrılan bir özel yöntemdir. Constructor, sınıfın özelliklerini ve diğer değişkenlerini başlatmak için kullanılır. Constructor, bir sınıfın örneğini oluşturduğunuzda, o nesnenin tüm özelliklerinin doğru bir şekilde başlatıldığından emin olmak için kullanışlıdır.
 
           C# programlama dilinde bir sınıfın yapıcı metodları aşağıdaki şekilde tanımlanır:   Ornek:*/

        public class MyClass
        {
            // parametresiz constructor
            public MyClass()
            {
                // Yapıcı metodu
            }

            // parametreli constructor
            public MyClass(int param1, string param2)
            {
                // Yapıcı metodu
            }
        }
        /*
         * Yukarıdaki örnekte, MyClass adlı bir sınıf tanımlanmıştır ve iki tane Constructor (Yapıcı Metod) bulunmaktadır. İlki parametresiz, ikincisi ise iki parametre almaktadır. Constructorlar, MyClass sınıfının özelliklerini başlatmak için kullanılabilir. Yapıcılar, nesne örneği oluşturulurken otomatik olarak çağrılır ve sınıfın özellikleri, Constructorlar tarafından sağlanan değerlere göre başlatılır.
         * 
         * Ornek : Asagida Bir class icerisinde Constructor olusturduk.Daha sonra 5 kere new ile nesne olusturduk bu classdan.HEr seferinde Constructor calisacagi icin 5 kere yazdirma islemi gerceklesecektir
         */

        //2)

        static void Main(string[] args)
        {
            new MyClass();
            new MyClass();
            new MyClass();
            new MyClass();
            new MyClass();

        }





        //1)

        class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("Bir adet MyClass nesnesi olusturduk");
            }
        }



        //Nesne olusturulurke () koyarak Constoktoru tetiklemesek hatayi aliriz.

        // C# 9.0 ile gelen MyClass m = new(); yaziminda bile () mutlaka olmalidir

        // Her Clasin icerisinde sen koymasan dahi Default bir Constructor vardir.

        //Default Ctor yerine kendi Ctorunu yazarsan onu ezmis oluyorsun



        //----------------  PARAMETRELI CONSTRUCTOR -------------

        // Eger bir ctor yazdiginizda Clasin icerisine parametre verdiyseniz ,nesne olustururken ayni tipte parametre vermezseniz hata alirsiniz  Ornek:

        //2)

        static void Main(string[] args)
        {
            new MyClass(5);
        }






        //1)
        class MyClass
        {
            public MyClass(int a)
            {
                Console.WriteLine("Bir adet " + a);
            }
        }

        // Constructor disinda diger ozel sinif elemanlari parametre alamaz

        // Constructorlar Overload ola bilen fonksionlardir.Overload Nedir?
        /*
         * C# Overload, aynı isme sahip farklı imzalara sahip birden fazla metot veya işlev tanımlamak anlamına gelir. Bu, farklı parametre türleri veya sayıları kullanarak aynı adı taşıyan birden fazla metot tanımlamak için kullanılır.

           Örneğin, aşağıdaki iki metot aynı ismi taşır, ancak farklı parametre imzalarına sahiptir:
         * 
         */

        void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

        void SayHello(string firstName, string lastName)
        {
            Console.WriteLine("Hello, " + firstName + " " + lastName);
        }

        //Bu, kullanıcının ihtiyaçlarına göre farklı şekillerde davranabilen çoklu metotlar oluşturmanıza olanak tanır. Overload kullanarak, aynı işlevi tekrar tekrar yazmanız gerekmez, ancak aynı işlev adı altında farklı işlevsellik sağlayabilirsiniz.


        // Constuctorda Overloading

        //Constructor Overloading, farklı parametrelerle birden fazla yapıcı metot tanımlama işlemidir. Bu, aynı sınıf içinde birden fazla yapıcı metot tanımlamak ve her biri farklı parametreleri kabul etmek için kullanılabilir.

        //Örnek olarak, aşağıdaki kod parçası, bir Person sınıfı oluşturur ve bu sınıfta iki yapıcı metot(constructor) tanımlar:


        public class Person
        {
            public string Name;
            public int Age;

            public Person(string name)
            {
                Name = name;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        /* Bu örnekte, Person sınıfı iki adet yapıcı metoda sahiptir.İlk yapıcı metot, yalnızca name parametresini kabul eder ve Age özelliğini atamaz.İkinci yapıcı metot, hem name hem de age parametrelerini kabul eder ve bu parametreleri kullanarak Name ve Age özelliklerini atar.

          Bu yapı, Person nesnelerini oluşturmak için esnek bir yol sağlar. Örneğin, yalnızca adı bilinen bir kişi için bir Person nesnesi oluşturmak istediğinizde, ilk yapıcı metodu kullanabilirsiniz. Ancak hem adı hem de yaşını bilen bir kişi için bir Person nesnesi oluşturmak istediğinizde, ikinci yapıcı metodu kullanabilirsiniz.

          Constructor Overloading, bir sınıfın esnekliğini artırır ve nesnelerin oluşturulması için daha fazla seçenek sunar.*/

        new Person(); // olarak Overloadli clasimin nesnesini olusturdugumda bana her 2 secenegide sunacak.HAngisine gondermek istersin? string olanami yoksa string ve int olanami?


        //---- Constructorun erisim belirleyicisini Private yaparsak nolur? ---

        //Nesne uretiminde hata alicaz cunki ctor tetiklenemiyor.

        //Singleten design pattern kullaniminda nesne olusumunu engellemek gerektigi zaman ctor private yapilir.Nesne olusumunu disardan engelleyip icerden nesne uretimiini yapiyoruz.  Ornek:

        class MyClass
        {
            private MyClass()
            {

            }

            void x
            {
                new MyClass(); // Ctorumuza bu fonksion uzerinden erise biliyoruz ama disardan erisemiyoruz.
        }


        // ----------- This Keywordu ile Constructorlar arasi gecis ----------


        // This Keywordu nasilki bir sinifin o anki nesnesini temsil ediyor ayni zamanda Overload edilmis Ctorlar arasinda gecis yapa bilme ozelliginede sahip.

        // 1 Classda Overload yaparak 1 den fazla Ctor olusturduysak bunlardan istedigimizin yanina gelerek : this() yazarak Nesne olusturulurken secdigimiz Ctordan sonra :this() yazdigimiz ctorunda calistirilmasini saglaya biliriz : Ornek



        // Aşağıdaki örnekte, Person sınıfında this anahtar kelimesi kullanarak iki farklı yapıcı metot arasında geçiş yapılır:


        public class Person
        {
            public string Name;
            public int Age;

            public Person(string name) : this(name, 0)// this fieldlere yada proplara erisemez sadece ctor parametrelerine erise bilir.
            {
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        //Bu kodda, ilk yapıcı metot yalnızca ad parametresini kabul eder ve bu parametreyi this anahtar kelimesini kullanarak ikinci yapıcı metoda ileterek çağırır. İkinci yapıcı metot hem ad hem de yaş parametrelerini kabul eder ve bu parametreleri kullanarak Name ve Age özelliklerini atar.

        //Bu yapı, Person nesnelerinin oluşturulması için daha fazla esneklik sağlar.Adı bilinen bir kişi için bir Person nesnesi oluşturmak istediğinizde, ilk yapıcı metodu kullanabilirsiniz ve yaş özelliği varsayılan olarak sıfır atanır.Ancak adı ve yaşını bilen bir kişi için bir Person nesnesi oluşturmak istediğinizde, ikinci yapıcı metodu kullanabilirsiniz.


        //this anahtar kelimesi, farklı yapıcı metotlar arasında parametrelerin ve işlemlerin paylaşılmasını sağlar ve kodun tekrarlanmasını önler.
    }


    //------------------ REcordlarda Constructor Kullanimi --------------------

    //Recordlar Aslinda bir Class olduklari icin Claslardaki butun Constrator ozellikleri Recordlar icinde gecerlidir.This ve Overload dahil.




    record MyRecord()
    {
        public MyRecord()
        {

        }
    }
    
}
