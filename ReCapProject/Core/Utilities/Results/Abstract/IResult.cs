using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        public bool Success { get; }     //işlem başarılı mı? true or false
        public string Message { get; }  // işlemin durumu için bilgi mesajı ver.
    }
}
