using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class Positional_Record
    {

        //Eger bir Record olusturup ve onun icerisinde Constructor ve Deconstruct tanimlamamiz gerekiyorsa .Mes:

        record MyRecord()
        {
            public MyRecord()
            {

            }

            public void Deconstruct()
            {

            }
        }

        //Bunun yerine Positional_Record kullana bilirsiniz.Bu sayede Ctor ve Deconstruct olusturmaya ek olarak gerek kalmadan () icerisinde gireceginiz data arkada bunlar varmis gibi bu ozel metotlarda harakete gecer

        record MyRecord(string name, string surname)
        {


        }

        //ARkada otomatikmen name ve surname propertysi olusur MyRecordun icerisinde ve bu Propertyler ( Init) Olarak olusur.Yani bunlari degisemeyiz olustuktan sonra.

        //Positional Record tanimlanmissa eger nesne uretiminde tetiklenmesi / kullanilmasi ZORUNLUDUR.

        //This Keywordunu kullanarak kendi olusturdugumuz Ctoru aktiv ede biliriz Record icerisinde

        record MyRecord()
        {
            public MyRecord():this()
            {

            }

            
        }











    }
}
