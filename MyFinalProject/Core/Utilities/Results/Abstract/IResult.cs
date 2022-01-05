using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    //Bu  interface bana islem yaptıktan sonra islem basarili mi basarisiz mi onu gosterecek
   public interface IResult
    {
        bool Success { get; }  //Islem basarili mi basarisiz mi? Basarili = true basarisiz = false
        string Message { get; } //Kullaniciya bilgi vermek icin de mesaj goster.
    }
}
