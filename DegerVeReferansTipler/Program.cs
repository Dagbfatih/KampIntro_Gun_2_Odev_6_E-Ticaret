using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0] ?? 999 
            // Garbage Collector - Çöp Toplayıcı : bellekteki kullanılmayan alanları siler
            // stach - heap --> stack: değer | heap: referans |

    //        DEĞER VE REFERANS TİPLER
    //            ------------

    //bellekte 2 bölüm vardır. Stack ve Heap.C# dilinde bir program üzerinden anlatalım:

    //        // İLK BÖLÜM
    //        int sayi1 = 10;
    //        int sayi2 = 30;
    //        sayi1 = sayi2;
    //        sayi2 = 65;
    //        // sayi1 ?? 30

    //        //İKİNCİ BÖLÜM
    //        int[] sayilar1 = new int[] { 10, 20, 30 };
    //        int[] sayilar2 = new int[] { 100, 200, 300 };
    //        sayilar1 = sayilar2;
    //        sayilar2[0] = 999;
    //        // sayilar1[0] ?? 999 

    //        Öncelikle ilk bölümü inceleyelim:
	   //     STACK           HEAP
    //      sayi1 = 10        ////
    //      sayi2 = 30        ////
    //      sayi1 = sayi2     ////
    //sayi1'in değeri eşittir
    // sayı2'nin değerine. 	

    //    Yani Stack kısmında değerler üzerinden işlem yapılıyor
    //Şimdi ikinci bölümü inceleyelim:

    //int[] sayilar1; program bu kısmı görünce STACK'ta yer eyırıyor ve sayilar1'i oraya atıyor.
    //int[] sayilar1 = new ... Ancak program 'new' ifadesini gördüğü an bu değişkeni
    //bir bellek tutucu(pointer) yapar değerleri koymak için HEAP'ta alan ayırır. Daha sonra 
    //sayilar1 ifadesinede değerlerin tutulduğu bellek adreslerini atar.
    // sayilar1[0]'a ilk değerinkini sayilar1[1]'e ikinci değerinkini... Yani program şu şekilde çalışır:
    //            STACK HEAP
    //   101 / sayilar1             101 /[10, 20, 30] // 101, 102 gibi ifadeler adresi temsil eder. ( Temsili Olarak )
    //   102 / sayilar2             102 /[100, 200, 300]
    //   sayilar1 = sayilar2
    //   102 / sayilar1
    //   102 / sayilar2


    //    Artık programda sayilar1'in değerleri 102 adresindeki değerler oldu. Artık 101 adresindeki 
    //değerleri tutan bir değişken olmadığı için .NET'in Garbage Collector'ü yani Çöp Toplayıcısı gelir ve
    //bu adrsi siler(temizler, toplar).

    //    Değer ve referans tipler işte bu şekilde çalışır. Ve şunları da ekleyelim;
    // değer tipleri ile çalışan veri tipleri ve referans tipleri şunlardır:
    //-Değer Tipler: Tüm sayısal veri tipleri(int, float, decimal, double, bool... )
    //-Referans Tipler: Array(s), Class(s), İnterface(s). (int, string... fark etmez. )


        }
    }
}
