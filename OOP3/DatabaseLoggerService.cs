using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService // Burada aslında 'sen bir interface alternatifisin' dedik.
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
