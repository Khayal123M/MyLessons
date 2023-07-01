using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class _96_Sealed_Keywordu
    {



    }

    /*
     * sealed anahtar kelimesi, bir sınıfın( Recordun) veya bir sınıf üyesinin (metot, özellik veya endeksleyici) başka bir yerden türetilmesini veya geçersiz kılınmasını engellemek için C# programlama dilinde kullanılan bir kısıtlama işaretleyicisidir.

      Bir sınıfın sealed olarak işaretlenmesi durumunda, o sınıftan başka bir sınıf türetilemez. Aynı şekilde, bir metot, özellik veya endeksleyici sealed olarak işaretlendiğinde, bu üyeler başka bir sınıf tarafından geçersiz kılınamaz.

      Örneğin, aşağıdaki örnekte, BaseClass adında bir sınıf tanımlanmış ve sealed anahtar kelimesi ile işaretlenmiştir:
     * 
     * 
     * 
     * 
     */

    public sealed class BaseClass
    {
        // Sınıf içeriği
    }

    /*
     * Bu durumda, BaseClass'dan türetilen bir alt sınıf oluşturulamaz.

      Aynı şekilde, sealed anahtar kelimesi, bir metot, özellik veya endeksleyiciyi geçersiz kılmaya karşı da koruma sağlar. Bir üye sealed olarak işaretlendiğinde, başka bir sınıf tarafından geçersiz kılınması engellenir. Örneğin:
     * 
     * 
     */

    public class BaseClass
    {
        public virtual void SomeMethod()
        {
            // Metot içeriği
        }
    }

    public class DerivedClass : BaseClass
    {
        public sealed override void SomeMethod()
        {
            // Metot içeriği
        }
    }

    public class FurtherDerivedClass : DerivedClass
    {
        // Hata! SomeMethod() geçersiz kılınamaz.
    }

    /*
     * Yukarıdaki örnekte, DerivedClass sınıfı sealed anahtar kelimesi ile işaretlenmiş bir SomeMethod metodu içerir. Bu durumda, FurtherDerivedClass adında bir sınıf SomeMethod metodu geçersiz kılamaz çünkü DerivedClass'ın SomeMethod metodu sealed olarak işaretlenmiştir.

       Bu şekilde, sealed anahtar kelimesi, sınıfların veya sınıf üyelerinin türetilme veya geçersiz kılınma durumunu kontrol etmek için kullanılabilir ve bu şekilde daha katı bir kalıtım yapısı sağlanabilir.
     * 
     */



    /*
     * Kalitimsal durumlarda atalardan gelen ve birinci dereceden alt sinif tarafindan override edilmis olan virtual memberlerin hiyerarsideki sonraki siniflar tarafindan override edilmesini ilgili memberi sealed ile isaretliyerek engelliyebiliriz.
     * 
     * Pratikte bu yontem sayesinde ust sinifin davranisini guvenli bir sekilde korumus ve ilgili metodun degistirilemesini onkemis oluyoruz.
     */


    /*    sealde Keywordu Hangi durumlarda Kullanilmalidir?
     *    
     *    1)Siniflarin davranislarini korumak istedigimizde.
     *    Kalitimsal Hiyerarside ust siniflarin ozel metotlari/davranislari varsa ve bunlari alt siniflardan degistirilebilir olmasini istemedigimizde o metodu seaed ile isaretleye biliriz
     *    
     *    2)Performans iyilestirilmesi istedigimizde.
     *    Mikro seviyede yapilan bir optimizasyon neticesinde C# ta bir sinif sealed ile isaretlenmisse seale olmayan bir sinifa gore ufak capta bir performans artisi gostermektedir.Sebebi derleyicinin bu siniifta miras alinmayacagini bilerek daha hizli derleme yapmasidir.
     *    
     *    3)Singelton Design Pattern
     *    Singelton Design Patternde bir sinifin uygulama capinda tekil bir instance sinin olmasini amaclamaktadir.Haliyle ilgili sinif sealed ile isaretlenerek bu siniftan herhangi bir kalitimsal iliskinin yaratilmasini engelleyebilir ve tek instance uretimini dahada garanti hale getirmis oluruz.
     * 
     * 
     */

}
