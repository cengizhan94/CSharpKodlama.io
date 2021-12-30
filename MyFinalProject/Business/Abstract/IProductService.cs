using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IProductService
    {
        //Filtrelemelerim
        //Hepsini getir.
        List<Product> GetAll();
        //kategori id'sine göre getir.
        List<Product> GetAllByCategoryId(int id);
        //Fiyatı min x ve max y aralıkları arasında olan ürünler getir.
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
