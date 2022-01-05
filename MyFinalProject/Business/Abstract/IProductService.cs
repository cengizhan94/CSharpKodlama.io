using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
   public interface IProductService
    {
        //Filtrelemelerim


        //IDataResult olan metodlar hata mesajı vs,  verebilmek için kullanılan operasyon.
        IDataResult<List<Product>> GetAll();
        //kategori id'sine göre getir.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        //Fiyatı min x ve max y aralıkları arasında olan ürünler getir.
        IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        
    }
}
