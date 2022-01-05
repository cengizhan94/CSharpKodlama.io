using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    //Kullanacak programcıya imkanları sunuyoruz:
    public class SuccessDataResult<T> : DataResult<T> 
    {
        //işlem sonucunu default true verdim.
        public SuccessDataResult(T data, string message) : base (data,true,message)
        {

        }
        //mesaj olmadan bir constructor
        public SuccessDataResult(T data): base (data,true)
        {

        }
        //Sadece mesaj döndür
        public SuccessDataResult(string message):base (default,true,message)
        {

        }
        //Bir şey döndürme.
        public SuccessDataResult()  :base(default,true)
        {

        }
    }
}
