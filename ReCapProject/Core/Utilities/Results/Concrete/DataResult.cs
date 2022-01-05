using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result,IDataResult <T>
    {
        //Result'u implemente ettiği için contructor yazıyoruz.
        //constructor'un içeriği: T tipinde data dön,
        // mesaj ve işlem sonucunu dön
        //base'e ise işlem sonucunu ve mesajı ilet.
        public DataResult(T data,bool success,string message) : base(success,message)
        {
            //Data'yı set ediyoruz.
            Data = data;
        }
        //yalnızca durum bilgisini ve datayı döndüren constructor
        public DataResult(T data,bool success):base(success)
        {
            //Data'yı set ediyoruz.
            Data = data;
        }
       public T Data { get; }

    }
}
