﻿using System;
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
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult <List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        
    }
}
