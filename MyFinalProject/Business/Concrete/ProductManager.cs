using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //Metodumu void değil de Result döndürüyor
        public IResult Add(Product product)
        {
            //Business codes (if vs.)
            if (product.ProductName.Length<2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _productDal.Add(product);
                return new SuccessResult(Messages.ProductAdded);
            
            
        }

        public IDataResult<List<Product>> GetAll()
        {
            if (DateTime.Now.Hour==14)
            {
                return new ErrorDataResult<List<Product>>(Messages.ProductAdded);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            //Her p için p'nin kategori id'si gönderilen id'ye eşitse onları filtrele.
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            //Bu kod bize iki fiyat arasında olan ürünleri filtrelemeye yardım ediyor.
           
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            //if (DateTime.Now.Hour == 13)
            //{
            //    return new ErrorDataResult<List<ProductDetailDto>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}
