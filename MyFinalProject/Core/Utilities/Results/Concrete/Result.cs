using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult

             
    {     //this=bu class icinde geçerli olan...               //Burada yaptığım hareket ile iki parametreli constructor çalışır.
        public Result(bool success, string message) : this (success) //<Hem message hem de success çalışır.
        {
            //Constructor oluşturup ProductManager'daki Add metodunda return olarak bool ve string değerlerimi döndürdüm. 
            Message = message;
        }
        public Result(bool success)     //< Burda message göndermek istemeyen sadece  true veya false döndürmek isteyen kullanıcı bunu kullanabilir.
        {
            //Kullanıcı isterse sadece bool da döndürebilir. Mesajı yazmasına gerek yok.
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }  //Sadece get yazıyoruz çünkü kodların herkes tarafından değiştirilmesini engelliyoruz.
    }
}
