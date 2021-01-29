using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService // Burada aslında 'sen bir interface alternatifisin' dedik.
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
