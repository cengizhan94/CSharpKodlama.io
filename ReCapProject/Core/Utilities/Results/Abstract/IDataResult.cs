using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult 
    {
        //işlem sonucu dışında bir de T türünde bir data döndürülecek.
        //Data ise ürün,araç vs....   T'ye kısıtlama yapmıyoruz. Çünkü istenilen her şey olabilr.
          T Data { get; }
    }
}
