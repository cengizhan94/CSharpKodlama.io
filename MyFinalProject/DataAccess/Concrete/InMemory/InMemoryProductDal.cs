using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle,Sql Server, Postgres, MongoDb vs... Gelen bilgileri Database'den geliyormuş gibi simüle ediyoruz...
            _products = new List<Product> {
               new Product{ProductId = 1, CategoryId = 1, ProductName = "Laptop",UnitsInStock=15,UnitPrice=1500},  
               new Product{ProductId = 2, CategoryId = 1, ProductName = "Telefon",UnitsInStock=20,UnitPrice=2500},
               new Product{ProductId = 3, CategoryId = 2, ProductName = "Kamera",UnitsInStock=30,UnitPrice=3500},
               new Product{ProductId = 4, CategoryId = 2, ProductName = "Tablet",UnitsInStock=40,UnitPrice=4500},
               new Product{ProductId = 5, CategoryId = 2, ProductName = "Klavye",UnitsInStock=50,UnitPrice=500}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Languege Integrated Querry
            // Lampda ifadesi (=>)
            Product productToDelete  = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);   //Her p için p'nin product Id'si gönderilen product Id'ye eşit mi?
           

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
          return   _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Gönderilen ürün id'sine sahip olan Listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
