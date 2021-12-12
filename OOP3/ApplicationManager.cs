using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {

        //5-Method injection (creditManager, loggerService) 
        //6-Burada kredilerin ve loggerların soyut halleri bulunuyor.
        public void Application(ICreditManager creditManager, List<ILogger> loggerServices)//Birden fazla Log yollamak istiyorsam enjekte ettiğim LoggerService interface'iini burada List içine alıyorum
        {
            creditManager.Hesapla();
            //loggerService.Log();
            //**********************
            //Alt kısımda birden fazla loglama yapabilmemi sağlayan foreach döngüsünü kullanıyorum.
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        //1-Kredi türlerimi listelemek için List sınıfından faydalanıyorum  ve interface'imi veriyorum. 
        //2-Unutma; interface'im diğer kredi türleri sınıflarımın referanslarını tutuyor. Bu sayede diğer kredi türleri sınıflarıma ulaşabiliyorum.
        //3-Bu sayede sürekli new yapıp durmuyorum hem DRY prensibine hem de SOLID prensibine uyuyorum.
        public void CreditPreInformation(List<ICreditManager> credits)
        {
            //4-Listedeki her bir kredinin hesapla operasyonunu yapması için foreach fonksiyonunu kullanıyorum.
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
