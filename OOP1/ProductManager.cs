using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Manager Sınıfında Product ile ilgili Operasyonlar vardır. Bu operasyonlar CRUD vs.dir. 

        public void Add(Product product)
        {
            
            Console.WriteLine("Ürün eklendi : " + product.ProductName);
        }
        public void Update(Product product)
        {
           
            Console.WriteLine("Ürün Güncellendi : " + product.ProductName);
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Ürün Silindi : " + product.ProductName);
        }

      
    }
}
