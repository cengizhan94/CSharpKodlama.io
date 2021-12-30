using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace CosoleIU
{
    //SOLID prensibinin Open Closed Principle
    //Eğer sisteme yeni bir özellik ekleniyorsa mevcut olan hiçbir koda dokunulamaz.
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))//GetAll veya GetByUnitPrice kullanarak bu filtrelemeyi değiştirebilirim.
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
