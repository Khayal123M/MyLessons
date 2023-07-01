using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Struct_Veri_Tipi
    {




    }





}
/*struct, C# programlama dilinde değer türünde bir veri yapısını temsil eden bir anahtar kelimedir. struct anahtar kelimesi kullanılarak tanımlanan yapılar, değer türü olarak kabul edilir ve stack bellekte depolanır.

struct'lar, basit veri tipleri gibi değerlerin kopyalarını tutarlar ve referans türlerinden (class) farklı olarak heap bellekte yer almazlar. struct'lar genellikle küçük boyutlu ve hafif veri yapıları için kullanılır. Örneğin, koordinatlar, zaman damgaları veya renkler gibi küçük ve bağımsız verileri temsil etmek için kullanılabilir.
 * 
 */

struct Point
{
    public int X;
    public int Y;
}
//Bu örnekte, Point adlı bir struct tanımlanmıştır. Point struct'ı, X ve Y adında iki tamsayı alanına sahiptir. Bu struct kullanılarak bir nokta koordinatını temsil edebilirsiniz.

//struct'lar, değer türleri olduğu için, bir struct değişkeni oluşturulduğunda bellekte bir kopyası oluşturulur. Bu nedenle, bir struct değişkeni üzerinde yapılan değişiklikler, orijinal değişkeni etkilemez. Ayrıca, struct'lar nullable olabilir ve null değerini alabilirler. Bu durumda, struct'ın tüm alanlarına varsayılan değerleri atanır.

// Struct    Class   Farklari :

/*`struct`'lar ve `class`'lar, C# programlama dilinde veri yapısı tanımlamak için kullanılan iki farklı yapıdır. İşte `struct`'ların `class`'lardan farklı olduğu bazı önemli noktalar:

1.Değer türü vs.Referans türü: `struct`'lar değer türleri olarak kabul edilirken, `class`'lar referans türleri olarak kabul edilir. Bir `struct` değişkeni oluşturulduğunda, değeri kopyalanır ve bellekte stack üzerinde saklanırken, bir `class` değişkeni referansı saklar ve bellekte heap üzerinde dinamik olarak oluşturulan bir nesneyi işaret eder.

2. Bellek Yeri: `struct`'lar stack bellekte depolanırken, `class`'lar heap bellekte depolanır. Stack belleği daha hızlı erişilebilir ve veri küçük olduğunda daha verimlidir. Heap belleği ise dinamik boyutlara sahip nesneleri saklamak için kullanılır.

3. Varsayılan Değerler: `struct`'lar varsayılan olarak tüm alanlarına uygun varsayılan değerleri atar. Örneğin, `int` alanı 0 olarak atanır. `class`'lar ise varsayılan olarak `null` değerini alır.

4. Kalıtım: `struct`'lar kalıtım yapamazlar ve sadece `System.ValueType`'dan otomatik olarak türetilirler. `class`'lar ise birden fazla sınıftan kalıtım alabilirler.

5.Nullable: `struct`'lar nullable olabilir ve `null` değerini alabilirler. `class`'lar ise varsayılan olarak nullable'dır (null referansı alabilir).

6. Performans: `struct`'lar genellikle küçük boyutlu ve hafif veri yapıları için tercih edilir. Bellek kullanımı ve performans açısından `class`'lara göre daha verimli olabilirler. Ancak, büyük veri yapıları veya karmaşık ilişkileri temsil etmek için `class`'lar daha uygun olabilir.

7.Struct larin default constroctorlari yoktur.Cunki bunlardan referans yolu ile nesne uretemeyiz.Bu yuzden nesne uretimi sirasinda bir olay gerceklestirmeye ihtiyaclari yoktur.

8.Struct Propertyleri Protected yada Protected Internal olamazlar.Bu erisim belirleyicileri Inharitance sirasinda ulasilmasini istemedigimiz propertylere verdigimiz erisimlerdir.Struct lar Base class olmadiklari icin bunlarda bu belirleyicilerde kullanilamaz ve gereksiz olur.

9.Sturclar Intarface lerden inharitance ala bilirler.Yani bir Interface Structun Base class i ola bilir.

Genel olarak, `struct`'lar değer türleri olarak basit ve hafif veri yapılarını temsil etmek için kullanılırken, `class`'lar daha karmaşık veri yapılarını ve nesneleri temsil etmek için kullanılır. Hangi yapının tercih edileceği, ihtiyaçlara ve veri yapısının doğasına bağlı olarak değişir.

*/