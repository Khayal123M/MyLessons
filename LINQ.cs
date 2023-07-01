using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Dersler.Dersler
{
    internal class LINQ
    {
        /*   using System.Linq;  -  Linq kullandiginizda otomatikmen bu kutuphane import olmadiysa kendimiz etmeliyiz
         * 
         * C# LINQ (Language Integrated Query), C# programlama dilinde veri sorgulama ve manipülasyonu için kullanılan bir tekniktir. LINQ, veri kaynakları üzerinde sorgular oluşturmayı ve bu sorguları C# programında kullanmayı sağlar.

          LINQ, nesne koleksiyonları, veritabanı tabloları, XML belgeleri, metin dosyaları gibi çeşitli veri kaynakları üzerinde sorgulama yapılmasını sağlar. LINQ sorguları, C# programında doğrudan yerleştirilebilir ve derlenir. Bu sayede veri kaynaklarından veri almak, sorgulamak, filtrelemek, sıralamak, gruplamak gibi işlemler kolaylıkla yapılabilir.

          LINQ, birçok farklı operatör ve ifade kullanarak sorgular oluşturmayı sağlar. LINQ sorguları, LINQ to Objects, LINQ to SQL, LINQ to XML, LINQ to Entities gibi çeşitli LINQ sağlayıcıları aracılığıyla farklı veri kaynakları üzerinde çalışabilir.

         LINQ, kodun okunabilirliğini artırır, sorguların basit ve anlaşılır bir şekilde ifade edilmesini sağlar ve veri işleme operasyonlarının kolaylıkla gerçekleştirilmesini sağlar. LINQ, C# diline entegre edilmiş olduğu için derleyici tarafından doğrudan desteklenir ve hata ayıklama ve hata kontrolü gibi avantajlar sağlar.


        C# için yaygın olarak kullanılan LINQ elemanlarının birçoğu aşağıdaki gibidir:

        Add: Bir koleksiyona yeni bir öğe eklemek için kullanılır.

        AddRange: Bir koleksiyona başka bir koleksiyondan birden çok öğe eklemek için kullanılır.

        Capacity: Bir koleksiyonun içindeki öğelerin saklanabileceği maksimum kapasiteyi temsil eder.

        Clear: Bir koleksiyonun tüm öğelerini temizlemek için kullanılır.

        Contains: Bir koleksiyonun belirli bir öğeyi içerip içermediğini kontrol etmek için kullanılır.

        Count: Bir koleksiyondaki öğe sayısını elde etmek için kullanılır.

        IndexOf: Bir koleksiyon içinde belirli bir öğenin indeksini bulmak için kullanılır.

        Insert: Belirli bir indekse yeni bir öğe eklemek için kullanılır.

        Remove: Bir koleksiyondan belirli bir öğeyi kaldırmak için kullanılır.

        RemoveAt: Belirli bir indeksteki öğeyi kaldırmak için kullanılır.

        RemoveRange: Belirli bir aralıktaki öğeleri bir koleksiyondan kaldırmak için kullanılır.

        Sort: Bir koleksiyonu belirli bir sıralama düzenine göre sıralamak için kullanılır.

        TrimExcess: Bir koleksiyonun içindeki öğelerin sayısına bağlı olarak kapasitesini ayarlamak için kullanılır.





        1) Where: Belirli bir koşulu sağlayan öğeleri filtrelemek için kullanılır.
        2) Select: Öğelerin belirli özelliklerini seçmek veya dönüştürmek için kullanılır.
        3) OrderBy ve OrderByDescending: Öğeleri belirli bir özelliğe göre sıralamak için kullanılır.
        4) GroupBy: Öğeleri belirli bir özelliğe göre gruplamak için kullanılır.
        5) Join: İki koleksiyonu belirli bir koşula göre birleştirmek için kullanılır.
        6) Distinct: Tekrarlanan öğeleri kaldırmak için kullanılır.
        7) Skip ve Take: Belirli bir sayıda öğeyi atlamak veya almak için kullanılır.
        8) Any ve All: Belirli bir koşulu sağlayan herhangi bir öğe var mı veya tüm öğeler bu koşulu sağlıyor mu kontrol etmek için kullanılır.
        9) Count: Öğelerin sayısını hesaplamak için kullanılır.
        10) Sum, Average, Min, Max: Öğelerin toplamını, ortalama değerini, en küçük değerini ve en büyük değerini hesaplamak için kullanılır.
        11) First, FirstOrDefault, Last, LastOrDefault: İlk veya son öğeyi almak veya belirli bir koşulu sağlayan ilk veya son öğeyi almak için kullanılır.
        12) Reverse: Öğelerin sırasını tersine çevirmek için kullanılır.
        13) Concat: İki koleksiyonu birleştirmek için kullanılır.
        14) Union: İki koleksiyonun birleşimini almak için kullanılır.
        15) Intersect: İki koleksiyonun kesişimini almak için kullanılır.
        16) Except: İki koleksiyonun farkını almak için kullanılır.

        Bu LINQ elemanları, veri sorgulama ve manipülasyonu için çeşitli senaryoları desteklemektedir. Her bir elemanın belirli bir işlevi vardır ve LINQ sorgularının esnek ve güçlü olmasını sağlar.




         * 
         * 
         * 
         */



    }

    //  LINQ Kullanmadan Örnek Kod:

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Toplamı hesapla
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("Toplam: " + sum);

            // En büyük sayıyı bul
            int max = int.MinValue;
            foreach (int num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine("En büyük sayı: " + max);

            Console.ReadLine();
        }
    }

    //  LINQ Kullanarak Örnek Kod:



    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Toplamı hesapla
            int sum = numbers.Sum();
            Console.WriteLine("Toplam: " + sum);

            // En büyük sayıyı bul
            int max = numbers.Max();
            Console.WriteLine("En büyük sayı: " + max);

            Console.ReadLine();
        }
    }


    //   ORNEK 2 -------------------------------------------------------------------------------------------------------------


    namespace LinqProject
    {
        class Program
        {

            static void Main(string[] args)
            {
                List<Category> categories = new List<Category>
                {
                    new Category {CategoryId= 1, CategoryName="Bilgisayar"},
                    new Category {CategoryId= 2, CategoryName="Telefon"}
                };


                List<Product> products = new List<Product>
                {
                    new Product{ProductId = 1, CategoryId= 1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=7000, UnitsInStock=5}
                    new Product{ProductId = 2, CategoryId= 1, ProductName="Asus Laptop", QuantityPerUnit="18 GB Ram", UnitPrice=5000, UnitsInStock=3}
                    new Product{ProductId = 3, CategoryId= 1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=4000, UnitsInStock=2}
                    new Product{ProductId = 4, CategoryId= 2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=2500, UnitsInStock=2}
                    new Product{ProductId = 5, CategoryId= 2, ProductName="Apple Telefon", QuantityPerUnit="8 GB Ram", UnitPrice=4000, UnitsInStock=0}

                };

                //Yukarida Kategory ve Product listeleri olusturduk.products listesinden istedigimiz urunleri sartli olarak secip yazdira bilmek icin asagida ayni islemi hem LINQ siz hemde LINQ ile yapdik.



                //  Algoritmik olarak islemin yazilmasi

                foreach (var product in products)
                {
                    if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                    {
                        Console.WriteLine(product.ProductName);
                    }
                }



                // LINQ ile islemin yazilmasi

                var result = products.Where(product => product.UnitPrice > 5000 && p.UnitsInStock > 3);

                foreach (var product in result)
                {
                    Console.WriteLine($"{product.ProductName}");
                }


                // Simdide istedigimiz sartlara gore secilen urunlerin yeni bir listeye atanmasi islemini lem LINQ ile hemde LINQ siz yapalim.



                // LINQ Kullanilmadan yazilan METOT
                static List<Product> GetProducts(List<Product> products)
                {
                    List<Product> filtreProducts = new List<Product>();

                    foreach (var product in products)
                    {
                        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                        {
                            filtreProducts.Add(product);
                        }
                    }

                }

                // LINQ Kullanilarak yazilan METOT

                static List<Product> GetProductsLinq(List<Product> products)
                {
                    return products.Where(product => product.UnitPrice > 5000 && p.UnitsInStock > 3).ToList();
                }


            }
        }

    }



    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }

    //---------------------------------------------------------------------------------------------------------------------------------------------



    // Ornek kod 1


    class LINQWithSimpleTypeArray
    {
        static void Main()
        {
            //Integer array olusturduk
            var values = new[] { 2, 9, 5, 0, 3, 7, 1, , 4, 8, 5 };

            // 1) Arrayin icindeki elemanlari yazdirdik
            Console.Write("Orginal array:");
            foreach (var element in values)
            {
                Console.Write($" {element}");
            }




            // 2) LINQ ile filterede valuesler icinden gelecek ve 4 den buyuk olacak value leri sec dedik.
            //where - kosul kullanmamiz icindir ve istedigimiz kadar kosulu uzata ve karmasiklastira biliriz.

            var filtered = from value in values
                           where value > 4
                           select value;

            //Secilen Valueleri yazdirdik
            Console.Write("\nArray value great than 4:");
            foreach (var element in filtered)
            {
                Console.WriteLine($"{element}")
            }



            // 3) orderby - kullanarak array icerisinden secilen degerlerin kucukden buyuye sirali olarak gelmesini sagliyicaz.

            //Herhangi bir filtre kullanmadigimiz icin butun elemanlar siralanicak

            var sorted = from value in values
                         orderby value
                         select value;

            Console.Write("\nOrginal array, sorted:")
            foreach (var element in sorted)
            {
                Console.Write($" {element}")
            }


            //4) orderby value descending - kullanilarak array icerisinden sececegimiz degerleri buyukden kucuge dogru azalan siralama ile almamizi sagliyacagiz.

            // filtered kullandigimiz icin yukardaki 4 den buyukler filtreside uygulanacak busefer

            var sortFilteredResult = from value in filtered
                                     orderby value descending
                                     select value;

            Console.Write("\nValues greater than 4, desending order (two queries):")

            foreach (var element in sortFilteredResult)
            {
                Console.Write($ "{element}");
            }



            // 5) ehere yapisinida busefer ekleyecegiz ve 4 den buyuk olanlar filtreleme islemini busefer where yerine yetirecek

            var sortAndFilter = from value in filtered
                                where value > 4
                                orderby value descending
                                select value;

            Console.Write("\nValues greater than 4, desending order (one queries):")

            foreach (var element in sortAndFilter)
            {
                Console.Write($ "{element}");
            }




        }
    }


    // Ornek kod 2

    //1) employees  degiskenine atadigimiz bir veri listesi icerisinden maaslari 4000 ve 6000 arasinda olan elemanlari asagidaki gibi ceke biliriz.



    class Salary
    {

        var between4K6K = from e in employees
                          where (e.MonthlySalary >= 4000) && (e.MonthlySalary <= 6000)
                          select e;

        Console.WriteLine("\nEmployees earning in the range" + $"{4000:C }-{6000:C} per month: ");
         foreach(var element in betwen4K6K)
        {
            
            Console.WritLine(element);
            
        }


    // 2) Eger istersek 1 den fazla sartla siralata biliriz verilerimizi.Asagidaki ornekte employees listemizden hem Isme hemde Soyisme gore Alfabetik siralama yapmasini istiyoruz.

    //Asagidaki islemde once Soyisme gore siralayacak ve eger ayni soyisimli kisiler varsa bunlarida kendi icerisinde isme gore siralayacak.

    var nameSorted = from e in employees
                     orderby e.LastName, e.FirstName
                     select e;

    Console.Writeline("\nFirst employee when sorted by name:");


        //Sorgu gonderildigi zaman uygun sonuc olmaya bilir bu sebeple Any kullanarak eger varsa yazdir yoksa not found yazdir diyoruz.Eger varsa ilk elemani bas
        if(nameSorted.Any())
        {
           ConsoleWriteLine(nameSorted.First());
        }

        else
        {
    Console.WriteLine("not found");
        }


// 3) Eger hicbir islem yaptirmadan sadece soyisimleri almak istiyorsak kisaca asagidaki ornekteki gii yaza biliriz.

  //Distinct() - metodu essiz benzersiz demek.Yani soyadi tekrar eden kisiler varsa eger o soyisimler sadece bir kere alinacak.

var lastNames = from e in empoyees
                select e.LastName;

Console.WriteLine("\nUnique employee last names:");
foreach(var element in lastNames.Distinct())
{
    Console.WriteLine(element);
}

//4) Asagidaki ornekte new operatoru ile bir obje olusturarak Isim ve Yoyisim string degerleri atayip daha sonra bunlari cekicez

var names = from e in employees
            select new { e.FirstName, e.LastName };

Console.WriteLine("\nNames only:");
foreach(var element in names)
{
    Console.WriteLine(element);
}


// Generic Collection     LINQ siz  ornekler

//1) Generic yapi icerisine tip fark etmezsizin herturlu datayi koya bilecegimiz yapidir.Kendi tanimladigimiz Class tipleride bunlara dahildir.

using System.Collections.Generik   // Mutlaka eklenmeli
using System.Linq;                 // Mutlaka eklenmeli


class ListCollection
{
    //Main metodumuzu olusturduk
    static void Main()
    {
        //string liste olusturduk
        var items = new List<string>();

        //Liste eleman sayisi ve kapasitesi yazdirildi elemanlar eklenmeden once
        Console.WriteLine("Before adding to items:" + $"Count = {items.Count}; Capacity = {items.Capacity}");


        // Normal add yaparken elemanin sonrasina baska eleman ekliyor.
        // Insert - Kullanarak istedigimiz indexe eklemesi icin kordinat vermis oluyoruz.

        items.Add("red");
        items.Insert(0, "yellow");

        // for dongusuyle liste elemani sayisini yazdirmak indexer [i] kullanarak

        Console.WriteLine("\nDisplay list contents with counter-controlled loop:");
        for (var i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{items[i]}");
        }

        //foreach kullanarak liste elemanini yazdirmak

        Console.WriteLine("\nDisplay list contents with foreach statemer");
        foreach (var item in items)
        {
            Console.Write($"{item}");
        }

        // Remove - ile istedigimiz elemani silmek

        items.Remove("yellow");

        //RemoveAt - ile index vererek liste elemanini silmek

        items.RemoveAt(1);

        // Contains -  ile listede belirledigimiz elemanin olup olmamasini sorgulicaz.Contains bool deger dondurur true or false.Eger red yoksa "not" yazdiricaz.
        //Ciktisi  Kirmizi listemizdedir veya degildir olacak

        Console.WriteLine("\n\"red" is "  +
             $"{(items.Contains("red") ? string.Empty : "not " )} in the list");

        //


    }


    // Generik Yapi   LINQ li ornekler


    //  let  ve ToUpper() -
    //  let - bir sureligine sectigimiz liste elemanini atamamiz icin degisken tanimlamamiza olanak tanir. ToUpper() ile buyuk harfa gecirdigimizde stringlerimize gerekli
    //StartWith(R) - Istediginiz harfla baslayan liste elemanini bulmak icin
    // orderby - sirala: uppercaseStringe gore sirama yapiyor

    var startWithR = from item in ItemSizingStrategy
                     let uppercaseString = item.ToUpper()
                     where uppercaseString.StartsWith("R")
                     orderby uppercaseString
                     select uppercaseString;

    foreach(var item in startWithR)
        {
           Console.Write($"{item}");
        }

    // Veri tabaninda kayitlari giren sahis bazen kucuk bazen buyuk harfle girmis ola bilir bas harfleri.Bunlari cekmek icin 2 yol var. 
    //1 ci yol yukari ornekte yaptigimiz gibi once let ile gecici degisken atayarak  hepsini buyuk harfe gecirmek
    // 2 ci yontemde or yani (||) kullanmak     StartsWith("R" || "r")

}







       
           







    






}
