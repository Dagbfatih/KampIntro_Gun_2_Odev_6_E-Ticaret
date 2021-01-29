using System;
using System.Collections.Generic;

namespace OOP3
{
    // ****** Sisteme veri eklendiğinde kodda değişiklik yapılmaz ******
    class Program
    {
        static void Main(string[] args)
        {
            //İhtiyacCreditManager ihtiyacCreditManager2 = new İhtiyacCreditManager(); // ihtiyacCreditManager - instance
            //ihtiyacCreditManager2.Calculate();

            //TasitCreditManager tasitCreditManager2 = new TasitCreditManager();
            //tasitCreditManager2.Calculate();

            //KonutCreditManager konutCreditManager2 = new KonutCreditManager();
            //konutCreditManager2.Calculate();

            // Yukarıdaki yorum satırlarında gösterildiği gibi de tanımlanabilir ama biz bu şekilde yapacağız çünkü daha yaygın
            //////////////////////////
            
            ICreditManager ihtiyacCreditManager = new İhtiyacCreditManager(); // Demekki Inteface'lerde classlar gibi o inteface'yi implemente eden class'ın referans numarasını tutabiliyormuş. Yani 
            //ihtiyacCreditManager.Calculate();
            ICreditManager tasitCreditManager = new TasitCreditManager();
            //tasitCreditManager.Calculate();
            ICreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calculate();
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService(); // bu şekilde de olur, aşağıdaki şekilde new'leyerekte olur

            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseloggerService, fileloggerService}; // 1
            List<ILoggerService> loggerServices2 = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerManager() }; // 2

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitCreditManager, new List<ILoggerService>() { new DatabaseLoggerService()}); // yukarıyı bir seçme ekrano gibi düşünün. Bizim seçtiğimiz kredi türü ne ise ona göre hesaplama yapıyor. Örneğin biz burada tasitCrediManager'i seçmişiz
            //basvuruManager.BasvuruYap(tasitCreditManager, fileloggerService);
            basvuruManager.BasvuruYap(new KonutCreditManager(), new List<ILoggerService>() { new SmsLoggerManager(), new FileLoggerService()}); // 3
            basvuruManager.BasvuruYap(new KonutCreditManager(), loggerServices);

            // 1 - 2 - 3 ile gösterilenlerin hepsi benzer işleri yapar. Sadece farklı kodlama teknikleridir.

            List<ICreditManager> credits = new List<ICreditManager>() 
            { ihtiyacCreditManager,
            tasitCreditManager,
            konutCreditManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(credits);
        }
    }
}
