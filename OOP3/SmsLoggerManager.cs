using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // ****** Sisteme veri eklendiğinde kodda değişiklik yapılmaz ******
    class SmsLoggerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms loglandı");
        }
    }
}
