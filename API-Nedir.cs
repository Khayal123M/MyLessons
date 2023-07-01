using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class API_Nedir
    {

        /*
         * API, Application Programming Interface (Uygulama Programlama Arayüzü) kelimelerinin kısaltmasıdır. Bir yazılım uygulamasının, başka bir yazılım uygulamasıyla iletişim kurmasını sağlayan bir ara yüzdür. Bir API, belirli işlevleri gerçekleştirmek için kullanıcıya belirli komutlar ve protokoller sunar.

         API'lar, yazılım bileşenlerinin birbirleriyle etkileşime geçmesine izin verir. Örneğin, bir web sitesi, haritalar, hava durumu bilgileri, ödeme işlemleri veya sosyal medya entegrasyonu gibi hizmetlere erişmek için API'ları kullanabilir. API'lar, geliştiricilerin ve yazılım uygulamalarının farklı hizmetleri ve verileri kullanmasını kolaylaştırır.

        API'lar, belirli bir programlama dili veya platformla sınırlı olmayabilir. Web API'ları, HTTP protokolünü kullanarak web tabanlı hizmetlere erişmek için yaygın olarak kullanılır. API'lar, veri alışverişi yapmak, işlevleri çağırmak, veri göndermek ve almak gibi çeşitli işlemleri gerçekleştirebilir. API'lar, geliştiricilere karmaşık işlevleri basitleştirmek, veri entegrasyonunu sağlamak ve uygulamaların etkileşimli olmasını sağlamak için kullanılır.
         * 
         * 
         * API hizmeti sunan sektörler ve platformlar oldukça çeşitlidir. İşte bazı örnekler:

         Sosyal Medya Platformları: Facebook, Twitter, Instagram gibi sosyal medya platformları, geliştiricilere API'ları aracılığıyla erişim sağlar. Bu API'lar, kullanıcı bilgilerini almak, gönderileri paylaşmak, takipçi sayılarını yönetmek gibi işlevlere erişim sağlar.

         Ödeme Hizmetleri: Ödeme işlemleri sağlayıcıları, e-ticaret platformlarına veya uygulamalara entegrasyon için API'lar sunar. Örneğin, PayPal, Stripe, Square gibi ödeme sağlayıcıları, API'lar aracılığıyla ödeme işlemlerini yönetmek için entegrasyon imkanı sunar.

        Haritalar ve Konum Hizmetleri: Google Maps, Mapbox, OpenStreetMap gibi harita ve konum hizmeti sağlayıcıları, geliştiricilere harita verilerine erişim sağlamak için API'lar sunar. Bu API'lar, konum arama, yol tarifi, yakındaki yerleri bulma gibi işlevleri gerçekleştirmek için kullanılabilir.

        Veri Analitiği ve Yapay Zeka: Veri analitiği ve yapay zeka platformları, geliştiricilere veri analizi, makine öğrenimi ve yapay zeka yeteneklerine erişim sağlayan API'lar sunar. Örneğin, TensorFlow, Microsoft Azure, Amazon AWS gibi platformlar, bu tür API'ları sağlar.

        Bulut Hizmetleri: Bulut bilişim sağlayıcıları, geliştiricilere uygulamalarını barındırmak, depolama sağlamak, veritabanlarına erişim sağlamak ve diğer hizmetleri kullanmak için API'lar sunar. Amazon Web Services (AWS), Microsoft Azure, Google Cloud Platform gibi platformlar, bu tür API'ları sağlayan örneklerdir.

        Finansal Hizmetler: Finansal kurumlar, API'lar aracılığıyla hesap bilgilerini paylaşmak, para transferleri gerçekleştirmek, kredi kartı işlemlerini yönetmek ve diğer finansal hizmetleri sağlamak için entegrasyon imkanı sunar.

        Sağlık Hizmetleri: Sağlık hizmeti sağlayıcıları, geliştiricilere hastane verilerine erişim, sağlık kayıtlarını yönetme, randevu planlaması gibi sağlık hizmetlerine erişim sağlamak için API'lar sunar.

        Bu sadece birkaç örnektir ve API hizmeti sunan sektörler ve platformlar sürekli olarak artmaktadır. API'lar, çeşitli sektörlerde farklı işlevleri yerine getirmek için kullanılır ve uygulama geliştiricilerine hizmet entegrasyonunu ve veri alışverişini kolaylaştırır.
         * 
         * 
         * 
         * 
         * 
         * 
         * 
         * API'lar kullanılarak birçok farklı uygulama türü geliştirilebilir. İşte API'larla geliştirilebilecek bazı uygulama örnekleri:

          Mobil Uygulamalar: API'lar, mobil uygulamaların dış kaynaklardan veri almasını sağlar. Örneğin, sosyal medya entegrasyonu, haritalar, ödeme işlemleri gibi API'larla mobil uygulamalar geliştirilebilir.

          Web Uygulamaları: API'lar, web uygulamalarının farklı hizmetlere ve verilere erişmesini sağlar. Örneğin, sosyal medya paylaşımları, ödeme işlemleri, harita entegrasyonu gibi işlevler API'lar aracılığıyla gerçekleştirilebilir.

          E-ticaret Uygulamaları: API'lar, e-ticaret platformlarına ödeme işlemleri entegrasyonu, envanter yönetimi, nakliye takibi gibi işlevleri eklemeyi mümkün kılar.

          Sosyal Medya Uygulamaları: API'lar, sosyal medya platformlarıyla etkileşimde bulunan uygulamalar geliştirmek için kullanılabilir. Örneğin, paylaşımları yönetmek, kullanıcıları takip etmek, sosyal medya analitiği yapmak gibi işlevler API'lar aracılığıyla gerçekleştirilebilir.

           Veri Analitiği Uygulamaları: API'lar, veri analizi, makine öğrenimi ve yapay zeka uygulamalarında kullanılabilir. API'lar aracılığıyla veri almak, analiz etmek, model eğitmek ve sonuçları elde etmek mümkündür.

          Harita ve Konum Tabanlı Uygulamalar: Harita ve konum hizmeti sağlayıcılarının API'ları, konum arama, yol tarifi, harita gösterimi gibi işlevleri içeren uygulamaların geliştirilmesine olanak tanır.

         Finansal Uygulamalar: Finansal hizmetler API'ları, ödeme işlemleri, banka hesaplarına erişim, kredi kartı işlemleri ve diğer finansal işlemlerin gerçekleştirildiği uygulamalar için kullanılabilir.

         Bu sadece birkaç örnek olup, API'lar kullanılarak geliştirilebilecek uygulama türleri oldukça geniştir. API'lar, farklı hizmetlere erişim sağlamayı, veri alışverişini kolaylaştırmayı ve uygulamaların daha işlevsel olmasını sağlar.
         * 
         * 
         * 
         * -------------------  ONEMLI --------------------------------
         * 
         * Bunlar disinda farkli platformlar icin uygulama gelistrirken API servislerini uygulama gelistirme amaci icinde kullana biliriz.Yani temel kodlarimizi bir yazilim dilinde burada yerlestiririz ve mesela IOS ve Androidde calisacak daha sade bir uygulama gelistiririz her iki uygulamaninda icerisine ayni kodlari yazmak yerine  sadece API ye data gonderecek ve cekecek kodlari yazmamizda yeterli olacaktir.Bu sayede hem indirilen uygulamalarimiz daha hafif ve sade hemde daha  kolay guncellenebilir olmakta.
         * 
         * 
         * https://www.youtube.com/watch?v=9-O7fWP5gPg    // API nedir NEden kullanilir?
         * 
         * 
         * https://www.youtube.com/watch?v=n2qTnQdEScA    // API nasil kullanilir NBA ornek
         * 
         * https://www.youtube.com/watch?v=mGVNPkFX4yw&list=PLI1fWkC-eS5813Ccb4rMF3-TdPEd3NVL      // 7 videoluk seri
         * 
         * 
         * -- API uygulamalar arasi bir iletisim olduug icin UI(User Interface-Kullanici arayuzu yoktur)
         * 
         * -- API ile normal hayatimizda UI ile yaptigimiz islemleri kodlarla yapabiliriz
         * 
         * -- Qarson Ornegi : 
         * 1) Musteri Pizza ister ve garsona soyler(Request to API)
         * 2) Qarson gider siparisi mutfaga soyler(Request to Server)
         * 3) Mutfak siparisi hazirlar ve qarsona verir(Response from Server)
         * 4) Qarson siparisi musteriye verir (Response to client)
         * 
         * -- Alisveris Sitesi Ornegi :
         * 1) Ayse sitede bir kulaklik begenir ve almak icin kart bilgilerini girer.
         * 2)Bu bilgilerin Amazonda bir karsiligi olmadigi icin Amazon girilen bilgilerle Banka API sine sorgu(Reguest) gonderir.
         * 3)Banka API si islemi onaylar ve Amazona bilgi(Respons)Gonderir
         * 4)Amazon Ayseye onay verir
         * 
           * https://collectapi.com/    // API turlerine  ve koleksiyonlarina ulasa bilecegimiz muhtesem bir site.
           * 
           *  -------------- API KULLANIMINDA ONEMLI OLANLAR -----------
           *  
           *  *
           *  
           *  1)  END POINT :
           *  APISINI KULLANACAGIMIZ SITENIN ADRESI DIYE BILIRIZ.Hangi yetki ile neyi nasil ve hangi adresten aldigimizi belitiyoruz End Point ile.
           *  
           *  2) HTTP METODU ve PARAMETRELER :
           *  Bilgiyi herzaman okumak istemeyiz bazen silmek bazen guncellemek isteriz ve bunlara ozel metotlar kullanmamiz gerekir.
           *  
           *  BUNLARIN BIZE SAGLANMIS BIR DOCUMANTASYONDA BELIRTILMIS OLMASI GEREK.
           *  
           *  3) ZORUNLU ALANLAR:
           *  Islem yapilmak istenen datanin kesin yerini belirtmek icin kullanilan alan.
           *  
           *  4) Ornek request ve varsa authorization turu ve apikey
           *  
           *  5)Gonderecegimiz requeste karsilik gelecek Response(cevap)
           *  
           *  
           *  //------------------ HTTP Nedir? -----------------------------
           *  
           *  HTTP (Hypertext Transfer Protocol), Türkçe olarak "Hipermetin Aktarım Protokolü" anlamına gelir. İnternet üzerinde bilgi alışverişi yapmak için kullanılan bir iletişim protokolüdür. HTTP, web tarayıcılarının web sunucularıyla iletişim kurmasını sağlayarak, web sayfalarının ve diğer web kaynaklarının (resimler, videolar, belgeler vb.) aktarılmasını yönetir.

              HTTP'nin temel amacı, bir istemcinin (genellikle bir web tarayıcısı) bir sunucudan (genellikle bir web sunucusu) bilgi talep etmesi ve sunucunun bu talebi yanıtlamasıdır. İstemci, bir URL (Uniform Resource Locator) aracılığıyla sunucudaki bir kaynağa erişmek ister ve bu isteği HTTP protokolü üzerinden gönderir. Sunucu, isteği alır, istenen kaynağı bulur ve HTTP yanıtını istemciye gönderir.

            HTTP'nin yaygın olarak kullanıldığı alanlardan biri World Wide Web (WWW) olup, web tarayıcıları, web sayfalarını görüntülemek ve indirmek için HTTP'yi kullanır.  Ancak, HTTP yalnızca web tarayıcılarla sınırlı değildir. Birçok uygulama ve hizmet, HTTP'yi kullanarak veri alışverişi yapar.

            HTTP, birçok özelliği ve metodu destekler. Örneğin, HTTP GET metodu, sunucudan bir kaynağın alınmasını sağlar. POST metodu, sunucuya veri göndermek için kullanılır. Diğer metotlar arasında PUT, DELETE, HEAD, OPTIONS vb. bulunur. Ayrıca, HTTP, web sayfalarının ve diğer içeriklerin şifrelenmesi ve kimlik doğrulama gibi güvenlik önlemlerini de destekler.

            HTTP'nin amacı, istemci ve sunucu arasında veri alışverişi sağlamak ve web üzerindeki kaynaklara erişimi kolaylaştırmaktır. Bu sayede, kullanıcılar web tarayıcıları aracılığıyla web sayfalarını görüntüleyebilir, dosyaları indirebilir, formları doldurabilir ve çeşitli web hizmetlerinden yararlanabilir.
           *  
           *  
           *  Asagidaki ornek Amazon linki 2 kisma bolunmekte. 1) ? isaretine kadar olan kisim ve ? isaretinden sonraki kisim. 2 ci kisim Id ve baska degerlere yapilmis atamalari gosteren kisimdir ve & ile birbirlerinden ayrilirlar.
           *  
           *  https://www.amazon.com.tr/flintronic-hama%C4%9F%C4%B1-kapasitesi-seyahat-karabina/dp/B089SH1YC9/ref=bs_c_garden_sccl_3/258-3296175-2491824?pd_rd_w=2hnJZ&content-id=amzn1.sym.3fe02061-f78f-41ca-a64a-56528d4308ea&pf_rd_p=3fe02061-f78f-41ca-a64a-56528d4308ea&pf_rd_r=HQ25T91N5BWTKA2TXGJW&pd_rd_wg=GFxVH&pd_rd_r=26f24da4-450d-4302-8617-bc7f30cea322&pd_rd_i=B089SH1YC9&psc=1
         * 
         * 
         * --- END POINT ----- Nedir? (API lerin URL adresi yani linkidir diye biliriz aslinda ve buda (URI) adlanmakta kisaca)
         * 
         * Endpoint, bir bilgisayar ağı üzerindeki iletişim noktasını veya bir web hizmetinin belirli bir işlevselliğini temsil eden bir URL (Uniform Resource Locator) adresidir. Bir endpoint, istemcilerin (genellikle web tarayıcıları veya uygulamalar) bir web hizmetine istek göndererek belirli bir kaynağa erişmelerini veya bir eylem gerçekleştirmelerini sağlar.

         Endpoint, bir web hizmetinin belirli bir işlevini gerçekleştirmek için kullanılan bir HTTP metodu (GET, POST, PUT, DELETE vb.) ve belirli bir URL kombinasyonunu ifade eder. Örneğin, bir e-ticaret uygulamasının "ürünler" kaynaklarına erişmek için "/products" endpointi kullanılabilir. Bu endpointe bir GET isteği gönderildiğinde, sunucu ilgili verileri yanıt olarak döndürür.

        Her web hizmeti, sunduğu işlevselliğe bağlı olarak birden fazla endpointe sahip olabilir. Örneğin, bir sosyal medya platformunda "/users" endpointi kullanıcı profillerini, "/posts" endpointi gönderilen mesajları ve "/notifications" endpointi bildirimleri temsil edebilir.

        Endpointler, RESTful API'lerin temel bileşenlerinden biridir. Bir RESTful API, belirli endpointlere yapılan isteklerle verileri alıp göndererek sunucuyla iletişim kurar. Endpointler, veri kaynaklarını, işlemleri veya hizmetleri tanımlar ve API'nin belirli bir kullanım durumunu temsil eder.

        Genel olarak, bir endpoint, bir web hizmetinin belirli bir işlevini ifade eden URL adresi ve bu işlevi gerçekleştirmek için kullanılan HTTP metoduyla ilişkilendirilen bir noktadır.
         * 
         * ---Authorization && Token -----  (Erisim izni )
         * 
         * Adrese AndPoint ile ulastiktan sonra bilgi alabilmemiz icin yetkili olmamiz yani izin lazim.
         * 
         * Authorization, kullanıcının veya istemcinin bir kaynağa (veri, hizmet veya işlevsellik) erişim yetkisini doğrulamak için kullanılan bir güvenlik mekanizmasıdır. Authorization, bir kimlik doğrulama işleminden sonra gerçekleşir ve kullanıcının belirli bir kaynağa erişme iznini denetler.

          Token ise kimlik doğrulama ve yetkilendirme işlemlerinde kullanılan bir veri parçasıdır. Token, kullanıcının veya istemcinin kimlik doğrulama sonucunda elde ettiği bir belgedir ve bu belge üzerinden yetkilendirme kontrolleri gerçekleştirilir. Token, kullanıcının kimliğini ve erişim izinlerini temsil eder.

          Token tabanlı yetkilendirme (Token-based authorization), genellikle modern web uygulamalarında ve API'lerde kullanılan bir yetkilendirme mekanizmasıdır. Bu mekanizma, kullanıcının kimlik doğrulaması sonrasında bir token almasını ve bu token üzerinden her erişim talebinin doğrulanmasını sağlar.

         Token, genellikle bir JWT (JSON Web Token) veya benzer bir formatta olabilir. JWT, JSON formatında bilgiyi içeren ve dijital olarak imzalanan bir token türüdür. Token içerisinde kullanıcının kimlik bilgileri, erişim izinleri ve diğer gerekli veriler bulunabilir. Sunucu, her gelen isteği bu token üzerinden doğrular ve kullanıcının erişim izinlerini kontrol eder.

         Token tabanlı yetkilendirme, kullanıcının her isteği için tekrar tekrar kimlik doğrulaması yapılmasını engeller ve sunucu üzerindeki yükü azaltır. Ayrıca, tokenler belirli bir süre geçerlilik süresine sahip olabilir ve yeniden kullanılabilir veya yeniden talep edilebilir.

         Tokenler, güvenli bir şekilde depolanmalı ve yetkisiz erişimlere karşı korunmalıdır. HTTPS gibi güvenli iletişim kanalları kullanmak ve tokenleri gizli tutmak önemlidir. Tokenlerin sürekli olarak yenilenmesi ve geçerlilik sürelerinin kontrol edilmesi de güvenlik açısından önemlidir.

         Sonuç olarak, Authorization ve Token, kimlik doğrulama ve yetkilendirme işlemlerinde kullanılan kavramlardır. Kullanıcıların belirli kaynaklara erişim yetkilerini doğrulamak için kimlik doğrulama sonrasında tokenlar kullanılır. Bu tokenlar üzerinden yapılan istekler doğrulanır ve kullanıcının erişim izinleri kontrol edilir.
         * 
         * 
         * ----- HTPPS ----- Nedir (HTPP nin guvenligi artirilmis ozel versionudur)
         * 
         * HTTPS (Hypertext Transfer Protocol Secure), Türkçe olarak "Güvenli Hipermetin Aktarım Protokolü" anlamına gelir. HTTPS, web tarayıcılarıyla web sunucuları arasında güvenli iletişimi sağlamak için kullanılan bir iletişim protokolüdür. HTTP protokolünün güvenli bir sürümüdür.

           HTTPS, standart HTTP protokolünün üzerine bir güvenlik tabakası ekleyerek iletişimin şifrelenmesini ve güvenliğini sağlar. Bu şifreleme, verilerin üçüncü taraflar tarafından okunmasını veya değiştirilmesini engeller, böylece kullanıcıların verilerinin gizliliğini ve bütünlüğünü korur.

          HTTPS'nin çalışma prensibi, SSL (Secure Sockets Layer) veya TLS (Transport Layer Security) adı verilen güvenlik protokollerine dayanır. Bu protokoller, bir dijital sertifika kullanarak sunucunun kimliğini doğrular ve şifreleme için bir anahtar oluşturur. Daha sonra, tarayıcı ve sunucu arasındaki iletişim, bu şifrelenmiş bağlantı üzerinden gerçekleşir.

          HTTPS'nin sağladığı güvenlik avantajları şunlardır:

          Veri Gizliliği: HTTPS, iletilen verileri şifreleyerek üçüncü tarafların verileri okumasını engeller. Bu, kullanıcıların hassas bilgilerini (parola, kredi kartı bilgileri vb.) güvende tutar.

         Veri Bütünlüğü: HTTPS, iletilen verilerin değiştirilmediğini ve bozulmadığını doğrular. Verilerin şifrelenmesi ve şifrenin doğrulanması, verilerin orijinalliğini korur.

         Kimlik Doğrulama: HTTPS, sunucunun kimliğini doğrulamak için dijital sertifikalar kullanır. Bu, kullanıcıların doğru bir sunucuyla iletişim kurduğunu ve bir güvenlik riski olmadığını bilmesini sağlar.

         HTTPS, e-ticaret siteleri, banka ve finans kuruluşları, sosyal medya platformları ve herhangi bir web sitesi için önemlidir. Günümüzde, kullanıcıların güvenli bir şekilde internet üzerinde gezinmelerini sağlamak için HTTPS yaygın olarak kullanılmaktadır.

        Web tarayıcıları, kullanıcıların bir web sitesinin HTTPS protokolünü kullanıp kullanmadığını belirten görsel ipuçları sunar. HTTPS, web adresinin başında "https://" şeklinde görünür ve tarayıcıda bir kilit simgesiyle veya yeşil bir kilit simgesiyle vurgulanabilir.

        Özetlemek gerekirse, HTTPS, güvenli iletişim sağlayan bir protokoldür. Verilerin şifrelenmesi ve sunucunun kimlik doğrulamasıyla kullanıcıların giz
         * 
         * 
         * -----------  HTTP Status (Durum) Kodlari -------
         * 
         * HTTP protokolü, bir istemcinin sunucudan aldığı yanıtın durumunu belirtmek için status kodları kullanır. İşte bazı yaygın HTTP status kodları:

          1xx - Bilgilendirme (Informational)

          100: Devam Et (Continue)
          101: Protokol Değiştiriliyor (Switching Protocols)

          2xx - Başarı (Success)

          200: Başarılı (OK)
          201: Oluşturuldu (Created)
          202: Kabul Edildi (Accepted)
          204: İçerik Yok (No Content)

          3xx - Yönlendirme (Redirection)

          300: Birden Fazla Seçenek (Multiple Choices)
          301: Kalıcı Yönlendirme (Moved Permanently)
          302: Geçici Yönlendirme (Found, Moved Temporarily)
          304: Değişiklik Yok (Not Modified)

          4xx - İstemci Hatası (Client Error)

          400: Geçersiz İstek (Bad Request)
          401: Yetkisiz (Unauthorized)
          403: Yasak- Yetkisiz (Forbidden)
          404: Bulunamadı (Not Found)
          405: İzin Verilmiyor (Method Not Allowed)

          5xx - Sunucu Hatası (Server Error)

         500: Sunucu Hatası (Internal Server Error)
         501: Uygulanmamış (Not Implemented)
         502: Geçici Arıza (Bad Gateway)
         503: Hizmet Kullanılamıyor (Service Unavailable)

         Bu sadece bazı temel HTTP status kodlarıdır ve daha fazla kod bulunmaktadır. Her bir status kodu, bir durumu veya durumu temsil eder ve istemcinin veya sunucunun gerçekleştirilen işlem hakkında bilgi sahibi olmasını sağlar. Status kodları, hata ayıklama, yönlendirme, doğrulama ve diğer iletişim senaryolarında önemli bir rol oynar.
         * 
         * 
         *-------- Sunucu ile iletisim icin Data Formatlari -----------------
         *
         *Sunucularla iletisim icin hangi veri tipleri kullanilir? Avantajlari ve dezavantajlari nelerdir? Encok hangileri tercih edilir?

         Sunucularla iletişim için farklı veri tipleri kullanılabilir. İşte bazı yaygın veri tipleri ve bunların avantajları ve dezavantajları:

        Metin Verileri:

        Avantajlar: Metin verileri (text/plain) kolayca anlaşılabilir ve okunabilir. Genel olarak hafiftir ve geniş bir uyumluluk sağlar.
        Dezavantajlar: Metin verileri, karmaşık yapıları veya zengin medya içeriklerini ifade etmek için sınırlıdır. Görseller, videolar veya yapılandırılmış verileri doğrudan temsil etmek için yetersiz olabilir.

        JSON (JavaScript Object Notation):

       Avantajlar: JSON (application/json), yapılandırılmış verileri taşımak için yaygın olarak kullanılan bir formattır. İnsanların okuması ve yazması kolaydır. Çok dilli desteğe sahiptir ve geniş bir dil ve platform uyumluluğuna sahiptir.
       Dezavantajlar: JSON verileri metin tabanlı olduğu için boyut açısından büyük olabilir. Özellikle büyük veri kümesi taşımak gerektiğinde performansı etkileyebilir.
       
        XML (eXtensible Markup Language):

       Avantajlar: XML (application/xml), verileri hiyerarşik bir yapıda taşımak için kullanılan bir formattır. Esnek ve genel amaçlıdır. Veri dönüşümlerini kolaylaştırır ve geniş bir platform uyumluluğu sağlar.
       Dezavantajlar: XML, metin tabanlı ve etiketlendirilmiş olduğu için boyut açısından büyük olabilir. JSON'a kıyasla daha fazla yazım gerektirir ve insanların okuması ve yazması daha zor olabilir.
       
        Binary Veriler:

       Avantajlar: Binary veriler (application/octet-stream), her türlü dosya veya ikili veriyi taşımak için kullanılabilir. Kesintisiz ve tam doğrulukla veriyi aktarır. Özellikle medya dosyaları gibi büyük veri kümesi taşınması gereken durumlarda etkilidir.
       Dezavantajlar: Binary veriler, metin tabanlı olmadığı için insan tarafından okunması veya düzenlenmesi zordur. Genellikle daha fazla veri boyutu gerektirir ve hata ayıklama veya anlaşılabilirlik açısından zorluklar sunabilir.
       Genel olarak, tercih edilen veri tipi, kullanım senaryosuna, veri yapısına ve performans gereksinimlerine bağlıdır. JSON, yaygın olarak kullanılan ve kolayca anlaşılabilen bir formattır ve çoğu web servisinde tercih edilen bir veri tipidir. Ancak, büyük veri taşıma veya dosya indirme gibi durumlarda binary veriler tercih edilebilir. Metin tabanlı veri tipleri, basit mesajlaşma senaryoları veya hafif veri taşıma gerektiren durumlarda kullanışlıdır.

      Sonuç olarak, kullanılacak veri tipi, verilerin doğası, boyutu, okunabilirlik gereksinimleri ve performans faktörleri gibi çeşitli faktörlere bağlıdır. Her bir veri tipinin avantajları ve dezavantajları bulunur ve kullanım senaryolarına uygun şekilde seçilmelidir.
         * 
         * 
         * --- JSON Data Tipi -------
         * 
         * 3 Temel kismi vardir.   
         * 
         * 1) Suslu Parantez - JSON formatindaki bir datanin nereden baslayip nerede bittigini gosterir.Ihtiyac oldugunda NESTED (ic ice) JSON datalarini olusturabilir
         * 
         * 2)Keys - JSON datalari icinde bulunan variable isimleridir,
         * 
         * 3)Value - Json datalari icinde bulunan variablelere atanan degerlerdir
         * 
         * 
         * Ornek:
         * 
         * {
            "name": "John Doe",
             "age": 30,
            "city": "New York",
         "hobbies": ["reading", "swimming", "traveling"],
       "isStudent": false

        "name": "John Doe": Bu alan, kişinin adını temsil eder. "name" anahtarına karşılık gelen değer "John Doe" metnidir.

        "age": 30: Bu alan, kişinin yaşıdır. "age" anahtarına karşılık gelen değer 30 sayısıdır.

        "city": "New York": Bu alan, kişinin şehir bilgisini temsil eder. "city" anahtarına karşılık gelen değer "New York" metnidir.

        "hobbies": ["reading", "swimming", "traveling"]: Bu alan, kişinin hobilerini temsil eder. "hobbies" anahtarına karşılık gelen değer bir dizi (array) şeklinde verilmiştir. Dizi içindeki elemanlar "reading", "swimming" ve "traveling" metinleridir.

        "isStudent": false: Bu alan, kişinin öğrenci olup olmadığını temsil eder. "isStudent" anahtarına karşılık gelen değer false boolean (mantıksal) değeridir.

       JSON, anahtar-değer çiftlerine dayalı bir veri yapısıdır. Her bir anahtar bir metin (string) olarak tanımlanır ve değerleri farklı tiplerde olabilir: metin (string), sayı (number), boolean (true/false), dizi (array) veya başka bir JSON nesnesi (object).

       JSON, verilerin yapısını kolayca temsil edebilen ve farklı platformlarda kullanılabilen bir formattır. İnsanlar tarafından okunması ve yazılması kolaydır. JSON, web servislerinde ve veri alışverişinde sıklıkla kullanılır. Özellikle modern web uygulamalarında, API'lerde ve mobil uygulamalar arasında veri paylaşımı için yaygın bir standart haline gelmiştir.
}
         * 
         * 
         * 
         *  Her API nin bilgi formati farkli ola bilir.Yani eger Turk Hava Yollarinin API sinden bilgi alacaksak oncelikle hangi veri tipini kullandiklarini bilmemiz lazim.
         *  Bu sebeple API dokumantosyonuna ihtiyacimiz var.
         *  
         * 
         * --------- SWAGGER DOKUMANTASYONU ------ (API leri kullana bilmemiz icin bize sunulan gerekli bilgilerdir)
         * 
         * 
         * Swagger, API'lerin tasarımını, oluşturulmasını, belgelendirilmesini ve test edilmesini kolaylaştırmak için kullanılan bir açık kaynaklı bir yazılım çerçevesidir. Swagger, RESTful API'lerin geliştirilme sürecinde önemli bir rol oynar ve API dokümantasyonunu otomatikleştirmek için kullanılır.

          Swagger, API'leri tanımlamak ve belgelendirmek için YAML (YAML Ain't Markup Language) veya JSON (JavaScript Object Notation) formatında bir dosya kullanır. Bu dosya, API'nin endpoint'lerini, parametrelerini, veri türlerini, işlemlerini ve diğer ilgili bilgileri içerir.

          Swagger dokümantasyonu, aşağıdaki temel öğelerden oluşur:

          API Tanımlama: Swagger, API'nin genel tanımlarını içeren bilgileri sağlar. Bu, API sürümü, başlık, açıklama, ana bilgisayar (host) bilgileri, protokol, lisans vb. gibi bilgileri içerir.

         Endpoint'ler: API'nin farklı işlemlerini temsil eden endpoint'lerin belgelenmesiyle ilgilenir. Her endpoint, HTTP yöntemi (GET, POST, PUT, DELETE vb.), URL yolu (path), parametreler ve veri türleri gibi bilgileri içerir.

         Parametreler: Endpoint'lere geçirilen parametrelerin belgelendirilmesiyle ilgilenir. Swagger, parametre tiplerini, gereklilik durumunu, geçerli değerleri ve açıklamaları içeren bilgileri sağlar.

         Veri Modelleri: API ile ilişkili veri modellerinin belgelenmesiyle ilgilenir. Swagger, giriş ve çıkış veri yapılarını, alanlarını, türlerini ve açıklamalarını tanımlayabilir.

         İstek ve Yanıt Örnekleri: Swagger, API isteklerinin ve yanıtlarının örneklerini sağlayarak, kullanıcılara doğru bir şekilde kullanmaları için rehberlik eder.

        Swagger dokümantasyonu, geliştiricilere API'yi daha iyi anlama, hızlı bir şekilde test etme, belgeleme oluşturma ve müşterilerle etkileşimde bulunma imkanı sağlar. Swagger UI veya Swagger Editor gibi Swagger araçları, bu dokümantasyonu kullanıcı dostu bir şekilde görüntülemek ve API'ye doğrudan erişim sağlamak için kullanılabilir.

         Sonuç olarak, Swagger dokümantasyonu, RESTful API'lerin tasarımını, belgelendirilmesini ve test edilmesini kolaylaştıran bir araçtır ve API geliştirme sürecinde önemli bir rol oynar.


        Swaggerlerde dikkat etmemiz gerekenler.

        1)End pointlerimizin verilmesi gerekiyor  2) Hangi endPoit ile hangi islemi yapa bilecegimiz 3)Bizden istenen sabit bir format olup olmayacagini 4)Ve bize donecek Responsunda formatinin acik bir sekilde verilmis olmasi gerekmejte

        Bunlar bizim uretecegimiz seyler deyil hepsinin sectigimiz platform tarafindan dokumantasyon olarak bize verilmesi gerekiyor.

        Swaggerin artilari : 

        Swaggee platformunu kendi platformuna entegre eden firmalar birkere entegre etdikten sonra degisiklik yapmak zorunda degillerdir.Cunki butun gerekli guncellemeleri algilar.


        https://swagger.io/  

        Get - Bilgiyi cekmek
        Post - Bilgi gondermek
        Put - Bilgi guncellemek
        Delete - Bilgiyi silmek

        Bazi firmalar Put metodunda bilginin tamamini guncellemek ve ya bir kismini guncellemek gibi degisik izinler vermis ola bilirler.Bu sebeple firmanin verdiyi Swagger dokumantasyonunu iyice inceleyin.


        ------ Postman ------    (API manuel test araci )


        https://www.postman.com/

        Postman API, Postman adlı popüler bir API geliştirme ve test aracının kendisini kontrol etmek ve yönetmek için kullanılan bir programlama arayüzüdür. Postman, API'lerin oluşturulması, test edilmesi, belgelendirilmesi ve paylaşılması için kullanılan bir platformdur. Postman API, kullanıcıların Postman'ın sağladığı özellikleri otomatikleştirmelerine ve genişletmelerine olanak tanır.

       Postman API, RESTful API'ler üzerinden çalışır ve JSON formatında veri alışverişi yapar. Bu API aracılığıyla, Postman'da gerçekleştirilen işlemleri programatik olarak gerçekleştirebilir, koleksiyonlar oluşturabilir, istekler gönderebilir, testler yürütebilir, ortamları yönetebilir, belgeler oluşturabilir ve diğer birçok işlemi gerçekleştirebilirsiniz.

       Postman API, otomasyon süreçlerini iyileştirmek, işbirliği yapmak ve CI/CD (Continuous Integration/Continuous Deployment) süreçlerine entegre etmek gibi bir dizi senaryoda kullanılabilir. Örneğin, Postman koleksiyonları ve test senaryolarını paylaşmak, iş birliği yapmak veya otomatik test süreçlerini entegre etmek için Postman API'yi kullanabilirsiniz.

       Postman API, Postman'in sunduğu özellikleri genişletmek ve özelleştirmek için geliştiricilere güçlü bir araç sağlar. API, Postman Collection Runner'ın otomatikleştirilmesini, test senaryolarının programatik olarak yönetilmesini ve diğer Postman işlevlerinin programatik olarak kullanılmasını mümkün kılar. Bu sayede, API testlerini otomatik hale getirebilir, test sonuçlarını entegre geliştirme araçlarına aktarabilir veya özel entegrasyonlar oluşturabilirsiniz.


        https://www.youtube.com/watch?v=paI5DZq79uw&list=PLpiXyP9d3U1q251izX5xLHctZEmb8REr_     // ASP.Net Core 10 derslik seri










         * 
         * 
         */









    }
}
