using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // ****** Sisteme veri eklendiğinde kodda değişiklik yapılmaz ******
    // Interface'ler genllikle operasyonel metodlarla kullanılır ve bir Referans tutucudur.
    // Interface'ler, o interface'i implemente eden class'ın referans no'sunu(adresini) tutabilir
    // *** Interface'leri birbirinin alternatifleri olan ama kod içeriği farklı olan durumlar için kullanırız ***
    interface ICreditManager // Interface'leri 'I' harfi ile başlatıyoruz ki interface olduğu belli olsun // İnterface'ler kuralları içerir. Onu implemente eden class'lar o kuralları kendine göre doldurur. İmpelement işlemine 'implementation' denir
    {
        // bu metodları bu interface'yi kullanan tüm method'lar kullanmak zorundadır
        // bu metodların sadece imzası yazılır çünkü içerisini bu interface'yi kullanan class'lar dolduracak
        void Calculate(); // İmzanın (void calculate()) aynı olduğu ama içerisinin farklı olduğu durumlarda class'ı interface olarak oluştururuz
        void BirSeyYap();
    }
}
