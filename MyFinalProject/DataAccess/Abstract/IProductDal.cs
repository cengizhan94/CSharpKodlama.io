using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
//Code Refactoring
namespace DataAccess.Abstract
{
    //IEntityRepository'yi Product için yapılandırdık
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();

    }
}
