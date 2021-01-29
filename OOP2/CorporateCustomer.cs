using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // ':Customer' olayına Miras (İnheritance) denir.
    class CorporateCustomer : Customer // Tüzel Müşteri // Legal Entity // Musteri burada ebeveyndir.
    {
        //*** Eğer ki bir nesnede bir değeri kullanmak zorunda gibi görünmüyorsan, O değeri kullanmak zorunda değilsen, o nesneye ait değilmiş gibi duruyorsa orada soyutlama hatası vardır. ***
        public string CompanyName { get; set; } // şirket ismi
        public string TaxNo { get; set; } // vergi no

    }
}
