using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //1-Banka Kredi Yönetimi
    interface ICreditManager
    {
        //2-İnterfacelerin alttaki gibi bir operasyonu var. Bu interface'i implemente eden tüm diğer sınıfların sahip olması zorunlu olan bir operasyondur.
        void Hesapla();
        
    }
}
