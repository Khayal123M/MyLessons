using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Delegates
    {
    }

    //Delegate ler metot tutuculardir.Metotlarin imzalarini saklaya bilmektedirler.
    //Bir delegate olusturdugumuzda icerisinde saklayacagimiz metodun geriye dondurme degeri ve islem yapilacak degerlerin tipleri mutlaka ayni olmalidirlar.Yani int tipinde 2 deger varsa metotda delegate dede ayni olmak zorunda.
    // delegate cagirilirken verdigimiz isim tipinden referansla bir nesne olusturmamiz gerekiyor new ile ve ctor kisminada metot ismini girmemiz lazim.Eger Topla yazsaydik toplama islemini yapacakti asagidaki ornekte.
    

    //Ornek 1 

    public delegate int Matematiksel(int param1,int param2);

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static int Carp(int a, int b)
    {
        return a * b;
    }


    static void Main(string[] args)
    {
        Matematiksel matematic = new Matematicsel(Carp);
        
        int sonuc = matematic(10, 15);

        Console.WriteLine(sonuc);

    }

    














    /*
     * Delegeler, C# dilinde temsilci olarak adlandırılan bir türdür. Delegeler, diğer metotları referans alarak ve bu metotları başka bir yerde çağırarak işlevlerini yerine getirir. Delegeler, olay tabanlı programlama, geri çağırma fonksiyonları ve asenkron programlama gibi senaryolarda önemli bir rol oynar.

       Delegelerin bazı faydaları şunlardır:

       Metotların Referans Alınması: Delegeler, metotları referans alarak bir metodu başka bir metoda parametre olarak iletebilir veya bir değişkene atayabilirsiniz. Bu, metotları dinamik olarak değiştirebilme ve yönlendirebilme imkanı sağlar.

      Geri Çağırma (Callback) Fonksiyonları: Delegeler, geri çağırma fonksiyonları için kullanılabilir. Bir metot, bir delegenin referansını alarak ve bu delegenin çağrılması yoluyla bir başka metodu geri çağırabilir. Bu, asenkron işlemler, olay tabanlı programlama ve UI olayları gibi senaryolarda kullanışlıdır.

      Esneklik ve Genişletilebilirlik: Delegeler, kodunuzda daha fazla esneklik ve genişletilebilirlik sağlar. Metotları parametre olarak iletebilme ve farklı metotların yerine geçebilmesi sayesinde, bir arayüz gibi davranabilir ve dinamik olarak çalışabilirler.

      C# dilinde bazı ön tanımlı delegeler bulunmaktadır. İşte bazı önemli delegeler ve kullanım örnekleri:




     * 
     */


    //1) Action: Parametre almayan ve geri dönüş değeri olmayan metotları temsil eder.

    Action printHello = () => Console.WriteLine("Hello");
    printHello();  // "Hello" yazdırır

    Action<string> printMessage = (message) => Console.WriteLine(message);
    printMessage("Welcome");  // "Welcome" yazdırır






    //2) Func: Bir veya daha fazla parametre alan ve geri dönüş değeri olan metotları temsil eder.

    Func<int, int, int> addNumbers = (x, y) => x + y;
    int sum = addNumbers(3, 5);  // 8 döndürür

    Func<int, bool> isPositive = (x) => x > 0;
    bool result = isPositive(-2);  // false döndürür






    //3) Predicate: Bir parametre alan ve bir boolean değer döndüren metotları temsil eder. Genellikle koleksiyonların filtrelenmesinde kullanılır.

    List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

    Predicate<int> isEven = (x) => x % 2 == 0;
    List<int> evenNumbers = numbers.FindAll(isEven);  // 2 ve 4'ü içeren bir liste döndürür







    //4) EventHandler: Olayların (event) bildiriminde kullanılan delegedir.

    class Button
    {
        public event EventHandler Click;

        public void OnClick()
        {
            if (Click != null)
                Click(this, EventArgs.Empty);
        }
    }

    Button button = new Button();
    button.Click += (sender, e) => Console.WriteLine("Button clicked!");

button.OnClick();  // "Button clicked!" yazdırır









}
