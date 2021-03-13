using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            //interfaceler de o interface ' i implemente eden classın referans numarasını tutabilirler.
            
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileloggerService = new FileLoggerService();


            List<ILoggerService> logs = new List<ILoggerService> { databaseLoggerService, new SmsLoggerService(), fileloggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new OgrenciKrediManager(), new List<ILoggerService> { databaseLoggerService, new FileLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager, konutKrediManager, ihtiyacKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);






        }
    }
}
