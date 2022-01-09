using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result,IDataResult <T>
    {
        // T tipinde data dön,
        // mesaj ve işlem sonucunu dön
        //base'e ise işlem sonucunu ve mesajı ilet.
        public DataResult(T data,bool success,string message) : base(success,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
       public T Data { get; }

    }
}
