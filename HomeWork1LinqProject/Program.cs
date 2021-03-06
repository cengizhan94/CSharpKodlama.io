using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork1LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId = 1 , CategoryName="Bilgisayar"},
                new Category{CategoryId = 2 , CategoryName="Telefon"}
            };
            List<Product> products = new List<Product>
            {
                new Product {ProductId = 1,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="32GBRam vs.",UnitPrice=4400,UnitsInStock=10},
                new Product {ProductId = 2,CategoryId=1,ProductName="Lenovo Laptop",QuantityPerUnit="120GBRam vs.",UnitPrice=33000,UnitsInStock=10},
                new Product {ProductId = 3,CategoryId=1,ProductName="Casper Laptop",QuantityPerUnit="64GBRam vs.",UnitPrice=2000,UnitsInStock=10},
                new Product {ProductId = 4,CategoryId=2,ProductName="Lenovo Telefon",QuantityPerUnit="12GBRam vs.",UnitPrice=12000,UnitsInStock=10},
                new Product {ProductId = 5,CategoryId=2,ProductName="Samsung Telefon",QuantityPerUnit="64GBRam vs.",UnitPrice=10000,UnitsInStock=10},
            };
            //Test(products);
            //AnyTest(products);
            //FindTest(products);
            //FindAllTest(products);
            //WhereTest(products);
            //ClassicLinqTest(products);
            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         select new ProductDto {ProductId = p.ProductId, CategoryName=c.CategoryName, ProductName=p.ProductName,UnitPrice=p.UnitPrice };

            foreach (var productDto in result)
            {
                Console.WriteLine("{0}---<Kategorisi>---{1}",productDto.ProductName, productDto.CategoryName);
            }
        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void WhereTest(List<Product> products)
        {
            //OrderByDescending ürünün fiyatını en yüksekten en düşüğe sıralayan kod.
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice);
            foreach (var product in result) //Listeyi gezebilmek için foreach döngüsüne alıyoruz.
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
            
        private static void FindTest(List<Product> products)
        {
            //Lambda
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }

        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Asus Laptop");
            Console.WriteLine(result);
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik : -------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }

            }

            Console.WriteLine("Linq : -----------");

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var p in result)
            {
                Console.WriteLine(p.ProductName);
            }
        }

        static List<Product> GetProducts(List<Product> products) 
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock < 3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock < 3).ToList();
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
