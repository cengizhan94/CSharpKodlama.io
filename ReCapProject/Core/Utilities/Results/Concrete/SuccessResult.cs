using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        //Success default true olarak veriyoruz.
        public SuccessResult(string message) : base(true,message)    //Kullanıcı isterse başarılı olan işleme mesaj da gönderebilir.
        {
        }
        public SuccessResult() : base(true)     //Kullanıcı isterse başarılı olan işleme mesaj göndermeden de devam edebilir.
        {
        }
    }
}
