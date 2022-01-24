using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //interfaceler o interfacei implement eden classın referans numarasını tutabilir

            ICreditManager ihtiyacKrediManager=new IhtiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager =new KonutKrediManager();
            ICreditManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaselogerService = new DataBaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> { smsLoggerService, databaselogerService}); // başvuruyap metoduna ıcredit interfacini göndererek tek bir krediye bağımlı kalmdan var olan bütün sçenekleri hesaplayabilirz.
            //ekranda ihtiyac kredisi hesaplandı yazar


            List<ICreditManager> krediler = new List<ICreditManager>() { esnafKrediManager };

            //ıcredit deki kredi seçenklerini arayüzden hesaplanmasını istesiğimiz krediler olarak düşünürsek, ekranda seçilen kredi çeşitleri lsite elemanı olarak yazılır ve hesaplanır
                                    
           // basvuruManager.KrediOnBİlgilendirmesiYap(krediler);
        }
    }
}
