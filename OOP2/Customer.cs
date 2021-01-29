using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Customer //Base class - Temel Sınıf
    {
        //*** Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, O değeri kullanmak zorunda değilsen, o nesneye ait değilmiş gibi duruyorsa orada soyutlama hatası vardır. ***
        public int Id { get; set; }
        public string CustomerNumber { get; set; } // müşteri no

    }
}
