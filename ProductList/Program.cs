using System;

namespace ProductList
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product product1 = new Product();
            product1.productId = 1;
            product1.productName = "Laptop";
            product1.productDiscription = "Asus";

            Product product2 = new Product();
            product2.productId = 2;
            product2.productName = "Tablet";
            product2.productDiscription = "Asus";

            Product product3 = new Product();
            product3.productId = 3;
            product3.productName = "Telefon";
            product3.productDiscription = "Asus";

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (var product in products)
            {
                Console.WriteLine(product.productId + " <>" + product.productName);
            }
        }
    }

    class Product
    {
        public string productName { get; set; }
        public string productDiscription { get; set; }
        public int productId { get; set; }
    }
}
