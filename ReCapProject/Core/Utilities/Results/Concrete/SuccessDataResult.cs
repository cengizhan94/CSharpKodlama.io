using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class SuccessDataResult<T> :DataResult<T>
    {

        //Burada başarılı olan DataResult'u kullanacak olan kullanıcıya döndürmesi için çeşitli contructorlar sunuyoruz.
        public SuccessDataResult(T data, string message) : base(data,true,message)
        {
             //Hem datayı hem mesajı hem de true yada false olan sonucu döndürür
        }
        public SuccessDataResult(T data , bool success): base(data,true)
        {
            //Hem datayı hem de işlem durumunu döndürür
        }
        public SuccessDataResult(string message) : base(default,true,message)
        {
            //Sadece mesaj döndürür
        }
        public SuccessDataResult():base(default,true)
        {
            //Hiçbir şey döndürmez. default truedur.
        }
    }
}
