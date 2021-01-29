using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class İhtiyacCreditManager : ICreditManager // Eğer bir sınıf, bir interface'yi kullanıyorsa(bu şekilde-->İhtiyacCreditManager:CreditManager) o sınıf, o interface'nin içerisindeki metodları kullanmak zorundadır.
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            // throw new NotImplementedException();

            /*...*/

            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı");
        }
    }
}
