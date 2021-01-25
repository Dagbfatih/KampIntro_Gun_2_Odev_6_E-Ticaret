
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakir Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("");
            }

            Console.WriteLine("------------Metotlar------------");
            // hızlı Console.WriteLine() yazmak için: 'cw' yazıp tab - tab yapın
            // instance -  örnek (sepetManager)
            // Encapsulation (Kapsülleme) - Yani Ekle2()'ye 3 parametre göndermektense ürün class'ını gönderiyoruz. Bu da ileride işimizi kolaylaştırıyor
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            //    sepetManager.Ekle(urunler[0]); 
            //    sepetManager.Ekle(urunler[1]);

            sepetManager.Ekle2("Armut", "yeşil Armut", 12, 8);
            sepetManager.Ekle2("Elma", "yeşil Elma", 15, 3);
            sepetManager.Ekle2("Karpuz", "Diyarbakir karpuzu", 20, 5);
        }
    }
}
