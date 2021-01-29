using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Method injection - Yani bu metoda kullanacağı KrediManager'in ne olacağını, kullanacağı Loglayıcının hangi loglayıcı olacağını enjekte ediyoruz
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            // Başvuran bilgilerini değerlendir

            /*...*/

            creditManager.Calculate(); // Aslında buradaşuna benzer bir kod çalışır: tasitCreditManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var kredi in credits)
            {
                kredi.Calculate();
            }
        }
    }
}
