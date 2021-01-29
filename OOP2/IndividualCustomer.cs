using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // ':Customer' olayına Miras (İnheritance) denir.
    class IndividualCustomer: Customer // Individual Customer - Gerçek Müşteri // IndividualCustomer bir Customer'dır. Yani customer'in içerisinde olan tüm özellikler IndividualCustomer'da da vardır. // Musteri burada ebeveyndir.
    {
        //*** Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, O değeri kullanmak zorunda değilsen, o nesneye ait değilmiş gibi duruyorsa orada soyutlama hatası vardır. ***
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
