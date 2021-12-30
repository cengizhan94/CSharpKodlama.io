﻿using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // GetAll();
            GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)//Hatanın neden muhtemelen database bağlanamadığı için.
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryid)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryid);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}