using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {


            //1-Burada newlediğim manager sınıfı ise tüm kredileri kontrol edebilecek, ekrana yazdırabilecek, kullanabilecek bir sınıf.
            //2-Buraya tek bir krediyi newlemek yerine tüüm kredileri kontrol edebilecek bir sınıf newliyorum.

            ApplicationManager applicationManager = new ApplicationManager();
            //7-Alttaki kısımda istediğim kredi türünü ve istediğim loglama türünü seçip çalıştırabilirim.
            //8-Yeni bir kredi türü çıktığında veya yeni bir loglama  türü çıktığında bana hiç zorluk çıkarmayacaktır.
            //applicationManager.Application(new VehicleLoanCreditManager(),new FileLoggerService());
            //****************************************************************************************
            //Alt kısımda ise birden fazla loglama yapabilmek için ILogger interface'imi Application sınıfımda implemente ederken List içine aldım.
            //List içine alınan interafce'im şimdi burada da List içinde süslü parantezlerle loglama işlemlerini içeriyor.
            applicationManager.Application(new VehicleLoanCreditManager(), new List<ILogger> { new FileLoggerService(), new DatabaseLoggerService() });


            //3-interface'ler newlenemezler. Bu yüzden Application'un istediği parametre aslında kredi türleri.
            //4-Tek tek diğer kredi türlerinin newlemek yerine tek bir interface'i List sınıfına ekleyerek tüm kredi türlerime ulaşabilirim.
            //5-Birden fazla kredi türünü ekrana yazdırmak, kullanmak için ise List sınfını kullanabiliriz.
            //6-List sınıfnın içine interface'imi veriyorum ki interface diğer kredi türelrinin referans numarasını tutabiliyor.


            List<ICreditManager> credits = new List<ICreditManager>() { new ConsumerCreditManager(), new VehicleLoanCreditManager(), new HousingLoanCreditManager() };
            //applicationManager.CreditPreInformation(credits);

            
            
        }
    }
}
