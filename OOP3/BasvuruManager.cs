using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class BasvuruManager
    {
        //method Injection

        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerService)//bu başvuruyu hangi krediye görey apmamız gerektiğini söyleyen parametreyi alıyoruz
        {


            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();   ///Bu şekilde yaparsak tüm başvuruları konut kredisine bağımlı hale getirmiş oluruz.

            //
            creditManager.Hesapla();//kredi bağımsız bir başvuru değerlendirme durumuna getirdik.        

            foreach (var logger in loggerService)
            {
                logger.Log();
            }
                   
        }

        public void KrediOnBİlgilendirmesiYap(List<ICreditManager>krediler)  //bir liste oluşturduk listenin türü ıcreditmanager oldu
        {
            foreach (var kredi in krediler)//listenin tüm elemanlarında geziyoruz
            {
                kredi.Hesapla();
            }
            //lsitedeki her bir kredinin hesabı yapılır. main metodunda hangi kredi seçildiyse onu hesaplar
        }
    }
}
