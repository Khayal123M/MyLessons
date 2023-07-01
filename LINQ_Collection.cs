using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class LINQ_Collection
    {
        // 1) from - Bir veri kaynağından veri seçmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    where num > 3
                    select num;


        // 2) where - Belirli bir koşula uyan verileri seçmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    where num > 3
                    select num;

        // 3) select - Veri kaynağından belirli bir alanı veya dönüştürülmüş bir değeri seçmek için 

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    select num * 2;

        // 4) orderby - Verileri belirli bir sıraya göre sıralamak için kullanılır.

        var numbers = new int[] { 5, 2, 1, 4, 3 };
        var query = from num in numbers
                    orderby num ascending
                    select num;

        // 5) group - Verileri belirli bir ölçüte göre gruplamak için kullanılır.

        var students = new List<Student>
        {
         new Student { Name = "John", Age = 20 },
         new Student { Name = "Jane", Age = 18 },
         new Student { Name = "Bob", Age = 20 },
         new Student { Name = "Alice", Age = 18 }
        };
        var query = from student in students
                    group student by student.Age;

        // 6) join - İki farklı veri kaynağını belirli bir koşula göre birleştirmek için kullanılır.

        var customers = new List<Customer>
        {
         new Customer { Id = 1, Name = "John" },
         new Customer { Id = 2, Name = "Jane" },
         new Customer { Id = 3, Name = "Bob" }
        };
        var orders = new List<Order>
        {
         new Order { Id = 1, CustomerId = 1, Product = "Phone" },
         new Order { Id = 2, CustomerId = 2, Product = "Laptop" },
         new Order { Id = 3, CustomerId = 1, Product = "Tablet" }
        };
        var query = from customer in customers
                    join order in orders on customer.Id equals order.CustomerId
                    select new { customer.Name, order.Product };

        // 7) let - Geçici değişkenler tanımlamak için kullanılır ve bu değişkenler sorgunun geri kalanında kullanılabilir.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    let squared = num * num
                    select squared;

        // 8) take - Belirli bir sayıda öğe almak için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = numbers.Take(3);

        // 9) skip - Belirli bir sayıda öğeyi atlamak için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = numbers.Skip(2);

        // 10 distinct - Tekrarlanan öğeleri kaldırmak için kullanılır.

        var numbers = new int[] { 1, 2, 2, 3, 3, 4, 5 };
        var query = numbers.Distinct();

        // 11) aggregate - Bir koleksiyonun öğelerini birleştirmek veya bir hesaplama yapmak için 

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var sum = numbers.Aggregate((x, y) => x + y);

        // 12) Any - Belirli bir koşulu sağlayan herhangi bir öğe olup olmadığını kontrol etmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var hasEvenNumber = numbers.Any(x => x % 2 == 0);


        // 13) All - Belirli bir koşulu tüm öğeler için kontrol etmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var allPositive = numbers.All(x => x > 0);

        // 14) Count - Öğelerin sayısını almak için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var count = numbers.Count();

        //15) First - İlk öğeyi seçmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var firstNumber = numbers.First();

        //16) SingleOrDefault - Yalnızca belirli bir koşulu sağlayan tek bir öğeyi seçmek için kullanılır. Eğer öğe bulunamazsa veya birden fazla öğe bulunursa hata fırlatır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var singleNumber = numbers.SingleOrDefault(x => x == 3);

        // 17) Max - En büyük değeri seçmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var maxNumber = numbers.Max();

        // 18) Min - En küçük değeri seçmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var minNumber = numbers.Min();

        // 19) Sum - Bir sayısal özellik değerlerinin toplamını almak için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var sum = numbers.Sum();

        // 20) Average - Bir sayısal özellik değerlerinin ortalamasını almak için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var average = numbers.Average();

        // 21) Contains - Bir öğenin bir koleksiyonda bulunup bulunmadığını kontrol etmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var containsThree = numbers.Contains(3);

        // 22) Reverse - Bir koleksiyonun öğelerini tersine çevirmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var reversedNumbers = numbers.Reverse();


        // 23) ToArray - Bir LINQ sorgusunun sonuçlarını bir diziye dönüştürmek için kullanılır.

        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    where num > 2
                    select num;
        var resultArray = query.ToArray();


        // 24) ToList - Bir LINQ sorgusunun sonuçlarını bir liste koleksiyonuna dönüştürmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    where num > 2
                    select num;
        var resultList = query.ToList();


        // 25) ToDictionary - Bir LINQ sorgusunun sonuçlarını bir sözlük veri yapısına dönüştürmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var query = from num in numbers
                    where num > 2
                    select new { Key = num, Value = num * num };
        var resultDictionary = query.ToDictionary(item => item.Key, item => item.Value);


        // 26) OfType - Belirli bir tipe uyan öğeleri seçmek için kullanılır.

        var mixedList = new ArrayList();
        mixedList.Add(1);
        mixedList.Add("hello");
        mixedList.Add(2);
        var numbers = mixedList.OfType<int>();

        // 27)Join - İki koleksiyonu belirli bir koşula göre birleştirmek için kullanılır.

        var customers = new List<Customer>();
        var orders = new List<Order>();
        var query = from customer in customers
                    join order in orders on customer.Id equals order.CustomerId
                    select new { CustomerName = customer.Name, OrderProduct = order.Product };


        // 28) GroupJoin - İki koleksiyonu birleştirir ve gruplar oluşturur.

        var customers = new List<Customer>();
        var orders = new List<Order>();
        var query = from customer in customers
                    join order in orders on customer.Id equals order.CustomerId into orderGroup
                    select new { CustomerName = customer.Name, Orders = orderGroup };

        // 29) DefaultIfEmpty - Bir koleksiyonun boş olması durumunda varsayılan bir değer döndürmek için kullanılır.

        var numbers = new int[] { };
        var defaultNumbers = numbers.DefaultIfEmpty(0);

        // 30) Concat - İki koleksiyonu birleştirir ve yeni bir koleksiyon oluşturur.

        var numbers1 = new int[] { 1, 2, 3 };
        var numbers2 = new int[] { 4, 5, 6 };
        var combinedNumbers = numbers1.Concat(numbers2);


        // 31) DistinctBy - Belirli bir özelliğe göre öğeleri benzersiz olarak seçmek için kullanılır.

        var customers = new List<Customer>();
        var distinctCustomers = customers.DistinctBy(c => c.Id);

        // 32) Union - İki koleksiyonu birleştirir ve benzersiz öğeler içeren yeni bir koleksiyon oluşturur.

        var numbers1 = new int[] { 1, 2, 3 };
        var numbers2 = new int[] { 3, 4, 5 };
        var uniqueNumbers = numbers1.Union(numbers2);


        // 33) Intersect - İki koleksiyonun kesişimini alır ve ortak öğeler içeren yeni bir koleksiyon olusturur

        var numbers1 = new int[] { 1, 2, 3 };
        var numbers2 = new int[] { 3, 4, 5 };
        var commonNumbers = numbers1.Intersect(numbers2);


        // 34) Except - İlk koleksiyonda bulunan, ikinci koleksiyonda bulunmayan öğeleri seçer ve yeni bir koleksiyon oluşturur.

        var numbers1 = new int[] { 1, 2, 3, 4, 5 };
        var numbers2 = new int[] { 3, 4 };
        var uniqueNumbers = numbers1.Except(numbers2);


        // 35) Zip - İki koleksiyonu birleştirir ve eşleştirilmiş öğelerden oluşan yeni bir koleksiyon oluşturur.

        var numbers1 = new int[] { 1, 2, 3 };
        var numbers2 = new int[] { 4, 5, 6 };
        var zippedNumbers = numbers1.Zip(numbers2, (n1, n2) => n1 + n2);


        // 36) ToLookup - Bir LINQ sorgusunun sonuçlarını anahtar-değer çiftlerini içeren bir "Lookup" veri yapısına dönüştürmek için kullanılır.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var lookup = numbers.ToLookup(x => x % 2 == 0);


        // 37) TakeWhile - Belirli bir koşulu sağlayan öğeleri seçmek için kullanılır, ta ki koşul sağlanmadığı bir öğeyle karşılaşılıncaya kadar.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var result = numbers.TakeWhile(x => x < 4);


        // 38) SkipWhile - Belirli bir koşulu sağlamayan öğeleri atlamak için kullanılır, ta ki koşulu sağlayan bir öğeyle karşılaşılıncaya kadar.

        var numbers = new int[] { 1, 2, 3, 4, 5 };
        var result = numbers.SkipWhile(x => x < 4);


        // 39) SequenceEqual - İki koleksiyonun aynı öğelere ve sıraya sahip olup olmadığını kontrol etmek için kullanılır.

        var numbers1 = new int[] { 1, 2, 3 };
        var numbers2 = new int[] { 1, 2, 3 };
        var areEqual = numbers1.SequenceEqual(numbers2);


        // 40) OrderByDescending - Öğeleri belirli bir özelliğe göre tersten sıralamak için kullanılır.

        var numbers = new int[] { 5, 3, 1, 4, 2 };
        var sortedNumbers = numbers.OrderByDescending(x => x);


        // 41) ThenBy - Önceki sıralama kriterine göre sıralanmış öğeleri ikinci bir sıralama kriterine göre sıralamak için kullanılır.

        var customers = new List<Customer>();
        var sortedCustomers = customers.OrderBy(c => c.LastName).ThenBy(c => c.FirstName);





















    }
}
