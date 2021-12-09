using System;

namespace Methots
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar tekrar kulanılabilirliği sunar
            //DRY Prensibi

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Id = 1;
            product1.Discription = "Amasya Elması";
            product1.UnitPrice = 15;
            product1.StockAmount = 10;

            Product product2 = new Product();
            product2.Name = "Çilek";
            product2.Id = 2;
            product2.Discription = "Antalya Çileği";
            product2.UnitPrice = 20;
            product1.StockAmount = 10;

            Product product3 = new Product();
            product3.Name = "Muz";
            product3.Id = 3;
            product3.Discription = "Afrika Muzu";
            product3.UnitPrice = 30;
            product1.StockAmount = 10;



            Product[] products = new Product[] { product1 , product2 , product3};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name + " : " + product.Id);
            }

            Console.WriteLine("*******Metotlar*******");

            CartManager manager = new CartManager();
            manager.Add(product1);
            manager.Add(product2);

            //manager.Add2("Elma","Tatlı",12,5);
            //manager.Add2("Armut", "Tatlı", 12, 5);
            //manager.Add2("Kelmahmut", "Tatlı", 12, 5);
        }
    }
}
