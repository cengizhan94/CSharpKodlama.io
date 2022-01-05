using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //işlem sonucunu default true verdim.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        //mesaj olmadan bir constructor
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        //Sadece mesaj döndür
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //Bir şey döndürme.
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
