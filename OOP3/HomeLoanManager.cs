using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingLoanCreditManager : ICreditManager
    {
        //İnterface'ten gelen Operasyon.
        public void Hesapla()
        {
            Console.WriteLine("Konut Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
