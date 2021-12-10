using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.id = 1;
            product.CategoryId = 1; //1 numara bilgisayarlar
            product.ProductName = "Laptop";
            product.UnitPrice = 5000;
            product.UnitsInStock = 100;
            //Üstteki gibi kalabalık kod bloğu ile de alttaki tek satır ile de aynı işlevi gören kodlar yazılabilir. Ancak burada veriler elle girildiği için, e ticaret sitesinin backendini simüle ediyoruz.
            Product product1 = new Product {id= 2,CategoryId =2,ProductName="Tablet",UnitPrice=1300,UnitsInStock=200};
            Product product2 = new Product {id=3,CategoryId=3,ProductName="Telefon",UnitPrice=14000,UnitsInStock=300 };
            
            ProductManager manager = new ProductManager();
            manager.Add(product);
            manager.Delete(product1);
            manager.Update(product2);

        

        }
    }
}
