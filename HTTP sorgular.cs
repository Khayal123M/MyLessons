using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Dersler.Dersler
{
    class HTTP_sorgular
    {
        //async Task C# programlamada asenkron bir metodu tanımlamak için kullanılan bir imzadır. Bu imza, bir metodu asenkron olarak işaretler ve dönüş değeri olarak Task türünü kullanır.
        //async Task imzası, bir metotun asenkron bir işlemi başlattığını ve işlemin sonucunu temsil eden bir Task nesnesini döndüreceğini belirtir. Task nesnesi, işlemin tamamlanma durumunu ve sonucunu izlemek için kullanılabilir.

        static async Task Main(string[] args)
        {
            //bool tipinde isContinue degiskeninin degeri yazdik.do while ile sart kostuk.do icerisinde sartimizi yazicaz ve eger while e gecerse dongu isContinue calissin ve false olsun.Yani do icerisinde yazacagimiz sartlar once calisicak.

            //do icerisinde static bir bilgide dondure biliriz ama bunun yerine bir API dan get metodu ile bilgi cekicez.

            //HttpClient : API ye request gondermek icin en onemli elementdir.Bundan new ile client adinda bir nesne olusturacagiz.

            //using System.Net.Http; : mutlaka ustden using etmemiz lazim bunu

            //const string ApiUrl = : const anahtar kelimesi constant yani sabit anlamina gelir.Sabit olarak bir ApiUrel tanimladik kullanmak icin.

            //resul mizin GetStringAsync() parantezine ApiUrl mizi atadik.GetStringAsync asenkron oldugu icin client in onune await belirtmek zorundayiz.Aksi taktirde resulta atan gec gelirse API den  beklenmeden devam eder program.

            //Kisaca linkdeki sonucu bana ver dedik ve sonra resaul ile yakalayarak yazdirdik.

            const string ApiUrl = "http://catfact.ninja/fact";

            bool isContinue ;

            HttpClient client = new HttpClient();

            do
            {
                var result = await client.GetStringAsync(ApiUrl);

                Console.WriteLine(result);


            }while(isContinue) { }

            //  {"fact":"Cats are now Britain's favourite pet: there are 7.7 million cats as opposed to 6.6 million dogs.","length":96}

            // JSON :
            //Get islemi yaptiktan sonra yukardaki sonucu aldik ve yazdirdik. sonuc JSON formatifir.
            // Her json verisi {} suslu parantez icerisinde olur
            // Key ve Value lerden ibaretdir veri ve bunlari : birbirinden ayirir. "fact" bir key : "..." cift noktadan sonra cift tirnak icindeki value sidir
            // , ile her veri birbirinden ayrilir.
            // []  icerisindek elemanlar ise bir Arrayin yani dizinin icindedirler







        }

    }
}
