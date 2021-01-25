using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        // naming convention - isimlendirme 
        public void Ekle(Urun urun) // ref, out, params
        {
            Console.WriteLine("Sepete eklendi" + " --> " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi" + " --> " + urunAdi);
        }
    }
}
