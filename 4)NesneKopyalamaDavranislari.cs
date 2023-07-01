using GameController;
using Metal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dersler.Dersler
{
    internal class NesneKopyalamaDavranislari
    {

        //  NESNENIN KOPYALANMASI NE DEMEK ?

        /*  1) SHALLOW COPY 
         *  1 den fazla referans ile bir nesne referanslaniyorsa buna ShallowCopy diyoruz.
         *  ShallowCopy zamani bir nesne cogaltilmiyordur.
         *  
         *  Var olan bir nesnenin,degerin,referansinin kopyalanmasidir.
         *  Shallow copy neticesinde eldeki deger cogaltilamaz.
         *  Sadece birden fazla referansla isaretlenmis olur 
         *  
         *  ORNEK   :
         */

        MyClass m1 = new MyClass();
        MyClass m2 = m1;
        MyClass m3 = m2;


        class MyClass
        {
            
        }     


        // Altda bir Class olusturduk ve ustdeki ornekte bu clasimizi m1 referansi ile cagirdik.Daha sonra m2 ile m1 i referansladik.
        //Boylece m1 referansini kullanarak . ile cagira bileceyimiz butun class elemanlarimizi artik m2. ilede cagira bilir durumdayiz.
        //Sonra ayni islemi m3 referansi ile m2 ye yaptik.Yinede m1. ile cagira bileceyimiz butun Class elemanlarimizi m3. ilede cagirabilir duruma geldik

        //ORNEK 2

        MyClass m1 = null;
        MyClass m2 = new MyClass();
        MyClass m3 = m2;
        m1 = m3;

        // Ustdeki ornekde ise once m1 null yaptik.m2 referansina nesne olusturduk.
        // m3 referansimiza m2 yi verdiginde onun butun ozelliklerini alir.
        // m1 referansimiza m3 atadigimizda artik Null degeri yerine m2 referansinin Nesne elemanlarina sahip olur.


       // EGer bir referans bir nesneyi isaretliyorsa baska bir nesneyi isaretlemesi icin emir girildiginde onceki isaretlediyi nesne ile arasindaki referans iliskisi kopacaktir.



        /* 2) DeepCopy  nedir  ?
         * 
         *  Var olan bir nesne DeepCopy ile kopyalaniyorsa egerilgili nesne miktari cogalir.AYni ozelliklere ve degerlere sahip olan bellekte farkli bir nesne daha olusur.
         */

         // Shallow Copy : Referans turlu degiskenlerde default davranistir.Yani Bir nesneye referans atadiginizda sonra bu referansi baska referansa atadiginizda NEsne 2 ci kopyasini olusturmaz sadece referans biri uzerinden digerine balnma olanagi tanir Nesneye baglanmak icin

            MyClass m = new MyClass();
            MyClass m2 = m;

        //Deep Copy : Deger turlu degiskenlerin default davranisidir.YAni bir a degerine 5 atarsak sonra b degerine a ayi atarsak , b degerine 5 in ikinci bir kopyasi arkadan atanir .Ve b nin degerine ne yaparsaniz yapin artik a yi ilgilendirmez ve etki etmez

        int a = 5;
        int b = a;


        // Referans turlu bir degiskene ise bir DeepCopy yaptirmamiz icin ek irade ortaya koymamiz lazim default yontemi olmadigi icin.Bunun icin Clasimizin icinde ozel bir metot olusturmaliyiz.  ORNEK  :

        MyClass m1 = new MyClass();
        MyClass m2 = m1;  //Shallow Copy

        MyClass m3 = m1.Clone(); // Deep Copy



        // 1) Asagida bir Class olusturduk
        // Daha sonra icerisinde MyClass tipinde Clone adinda bir metot olusturduk
        //metotmuzun icerisinde return ile degerimizi dondurduk,(Myclass) ile degeri bu tipde dondurduk,this ile nesnemize isaret verdik ve MemberviceClone() ilede bu nesnemizin copyalamaya acik olduguunu bildirdik. 
        class MyClass
        {
            public MyClass Clone()
            {
                return (MyClass)this.MemberwiseClone();
            }
        }


    }
}
