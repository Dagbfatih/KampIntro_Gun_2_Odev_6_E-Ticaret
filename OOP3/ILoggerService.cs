using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // ****** Sisteme veri eklendiğinde kodda değişiklik yapılmaz ******
    //loglama: bir sistemdeki kim, ne zaman, hangi operasyonu çağırdı? bilgilerini almak.Yani bir sistemde
    //olan hareketleri döktüğünüz bir dökümdür.
    interface ILoggerService // bundan sonra interfacelerde Service yazacağız: ILoggerManager değil de I LoggerService ||Ancak Manager de diyebiliriz bir sıkıntı olmaz.
    {
        void Log();
    }
}
