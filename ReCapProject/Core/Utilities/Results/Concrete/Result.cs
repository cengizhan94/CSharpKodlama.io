using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {                                                            //Buradaki constructor tek parametreli constructoru da kapsıyor
        public Result(bool success, string message) : this (success) //burada gönderilen this(success) tek parametreli constructor'da çalışsın demek istiyoruz.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; } 
        public string Message { get; } 
    }
}
