using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fatih Dag
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Fatih";
            customer1.LastName = "Dağ";
            customer1.TcNo = "1234567890";

            // Kodlama.io
            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "56789";

            Customer customer3 = new IndividualCustomer(); // new görüyorsan bilki bu ('new IndividualCustomer()') bellekteki bir referans no'sunu tutar.
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1); // görüldüğü gibi tüm sınıfları parametre olarak gönderebiliyoruz. İşte İnheritance tam olarak bu işe yarar
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

            // customer1.CustomerType = 1; // 1 ise gerçek, 2 ise tüzel müşteridir. | Bu hatalı bir kullanımdır.
            // Gerçek müşteriymiş gibi görünen ama gerçekte tüzel müşteri olan hatalı veri girişlerinden kaynaklanan sorunlar ortaya çıkabilir. O yüzden bu hatalı bir kullanımdır.

            // Gerçek Müşteri - Tüzel Müşteri
            // SOLID
        }
    }
}
