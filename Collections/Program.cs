using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Engin", "Murat", "Kerem", "Fatih" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //// burada diziye 5. eleemanı eklemek istersem hata verir. Örn: names[4] = "Halil"; dersem hata verir çünkü arrayler sınırları içerisinde çalışabilirler.
            //// Ancak diziye yeni bir adres atayabilirim.
            //names = new string[5]; // Yeni referans adresi oluşturuldu
            //names[4] = "Halil";

            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]); // bakın işe yaradı ancak bu sefer diğer veriler silindi 
            ////Bunun nedeni ise yeni bir adres atadığımız için diğer verilerin olduğu adresi tutan bir değişken kalmadı
            //// Yani kısacası biz dizileri genişletemiyoruz. Genişletsek bile değerleri kaybediyoruz

            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");
            isimler2.Add("Fatih");
            isimler2.Add("Murat");
            isimler2.Add("Kerem");
            /* ... */
            // Yada
            List<string> isimler3 = new List<string> { "Engin", "Murat", "Halil", "Fatih"};

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine();

            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            Console.WriteLine(isimler3[3]);
            isimler3.Add("Bulent");
            Console.WriteLine(isimler3[4]);
            Console.WriteLine(isimler3[0]);

        }
    }
}
