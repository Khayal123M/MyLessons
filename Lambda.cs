using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Lambda
    {

       





    }


    /*
            * C# programlama dilinde "lambda" ifadesi, kısa ve anonim fonksiyonları tanımlamak için kullanılan bir yapıdır. Lambda ifadeleri, C#'da işlevsel programlama tekniklerini uygulamak için kullanılır.

              Lambda ifadeleri, genellikle bir delege türüne atanır ve bu delege türü üzerinden çağrılırlar. Bir lambda ifadesi, parametre listesi, ok işareti (=>) ve bir ifade veya kod bloğu içerebilir.
     // Ornek 1:-------------------------------------------------------------------------------------------------------------------------

            * 
            */

    Func<int, int> square = x => x * x;

    //Bu örnekte, "square" adlı bir delege tanımlanır ve bu delegeye bir lambda ifadesi atanır.Lambda ifadesi, bir tamsayı alır ve onun karesini döndürür.

    // Ornek 2:----------------------------------------------------------------------------------------------------------------------------

    // Örneğin, bir dizi üzerinde filtreleme işlemi yapmak için lambda ifadelerini kullanabiliriz.

    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    var evenNumbers = numbers.Where(x => x % 2 == 0);

        foreach (var number in evenNumbers)
        {
          Console.WriteLine(number);
        }

/*
 * Bu örnekte, numbers adlı bir tamsayı dizisi tanımlanır. Ardından, Where metodu kullanılarak dizi üzerinde bir filtreleme işlemi gerçekleştirilir. Where metodu, verilen bir koşula uyan elemanları içeren bir koleksiyonu döndürür.

  Lambda ifadesi, Where metoduna parametre olarak geçilir ve dizi elemanlarını filtrelemek için kullanılır. Lambda ifadesi olan x => x % 2 == 0, x parametresini alır ve bu parametrenin çift olup olmadığını kontrol eder.

  Sonuç olarak, evenNumbers adlı bir koleksiyon elde edilir, bu koleksiyon sadece çift sayıları içerir. Daha sonra, foreach döngüsü kullanılarak çift sayılar ekrana yazdırılır.

  Bu örnekte lambda ifadesi, dizinin elemanlarını tek tek kontrol eder ve çift olup olmadığını belirler. Daha sonra, Where metodu bu lambda ifadesini kullanarak sadece çift sayıları içeren bir koleksiyon oluşturur.

  Bu şekilde, lambda ifadelerini kullanarak veri koleksiyonlarında filtreleme, sıralama, dönüşüm ve diğer işlemleri daha kısa ve okunabilir bir şekilde gerçekleştirebilirsiniz
 * 
 */

// Ornek 3: -------------------------------------------------------------------------------------------------------------------------

/*Örneğin, bir dizi içindeki stringleri uzunluklarına göre sıralayan bir lambda ifadesi kullanalım:
 * 
 * 
 */

string[] names = { "Alice", "Bob", "Charlie", "Dave", "Eve" };

var sortedNames = names.OrderBy(x => x.Length);

foreach (var name in sortedNames)
{
    Console.WriteLine(name);
}

/*
 * 
 
Bu örnekte, names adlı bir dizi tanımlanır, bu dizi içinde birkaç isim bulunmaktadır. Ardından, OrderBy metodu kullanılarak diziyi uzunluklarına göre sıralar.

Lambda ifadesi olan x => x.Length, OrderBy metodu için bir sıralama kriteri belirler. Bu ifade, x parametresini alır (dizideki her bir ismi temsil eder) ve bu isimlerin uzunluklarını döndürür.

Sonuç olarak, sortedNames adlı bir koleksiyon elde edilir, bu koleksiyon isimleri uzunluklarına göre sıralı olarak içerir. Daha sonra, foreach döngüsü kullanılarak sıralanmış isimler ekrana yazdırılır.

Bu örnekte lambda ifadesi, isimleri uzunluklarına göre sıralamak için kullanılır. OrderBy metodu bu lambda ifadesini kullanarak bir sıralama yapar ve sıralanmış bir koleksiyon elde edilir.

Lambda ifadeleri, veri manipülasyonu, filtreleme, sıralama ve diğer işlemler için kullanıldığı gibi, LINQ sorgularında da sıklıkla kullanılır. LINQ ile birlikte lambda ifadelerini kullanarak, veri üzerinde daha karmaşık sorgular yapabilir ve sonuçları istediğiniz şekilde şekillendirebilirsiniz.
*/


// Ornek 4 : -----------------------------------------------------------------------------------------------------------------------------

//Aşağıdaki örnekte, bir kişi listesi üzerinde çeşitli işlemler gerçekleştiren lambda ifadelerini kullanacağız:

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 25 },
    new Person { Name = "Bob", Age = 30 },
    new Person { Name = "Charlie", Age = 22 },
    new Person { Name = "Dave", Age = 35 },
    new Person { Name = "Eve", Age = 28 }
};

// Yaşı 30'dan büyük olan kişileri seçme
var filteredPeople = people.Where(p => p.Age > 30);

// İsimleri büyük harflere dönüştürme
var upperCaseNames = people.Select(p => p.Name.ToUpper());

// Yaşa göre küçükten büyüğe sıralama
var sortedPeople = people.OrderBy(p => p.Age);

// Sonuçları ekrana yazdırma
foreach (var person in filteredPeople)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

foreach (var name in upperCaseNames)
{
    Console.WriteLine(name);
}

foreach (var person in sortedPeople)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
}

/*
 * Bu örnekte, Person adında bir sınıf tanımlanır ve bu sınıfın Name ve Age adında özellikleri bulunur. people adlı bir kişi listesi oluşturulur ve bu liste içinde bazı kişilerin bilgileri yer alır.

   Daha sonra, lambda ifadeleri kullanılarak çeşitli işlemler gerçekleştirilir:

   Where metodu ile yaşları 30'dan büyük olan kişiler filtrelenir.
   Select metodu ile kişilerin isimleri büyük harflere dönüştürülür.
   OrderBy metodu ile kişiler yaşlarına göre küçükten büyüğe sıralanır.
   Sonuçları ekrana yazdırmak için foreach döngüleri kullanılır.

   Bu örnek, lambda ifadelerinin bir liste üzerinde filtreleme, dönüştürme ve sıralama gibi işlemleri gerçekleştirmek için nasıl kullanılabileceğini göstermektedir. Lambda ifadeleri, LINQ sorgularında kullanılarak veri üzerinde daha karmaşık manipülasyonlar yapmanızı sağlar.
 */










}
