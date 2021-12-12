using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanCreditManager : ICreditManager
    {
        //İnterface'ten gelen Operasyon.
        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı");
        }
    }
}
