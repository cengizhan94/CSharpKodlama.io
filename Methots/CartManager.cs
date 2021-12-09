using System;
using System.Collections.Generic;
using System.Text;

namespace Methots
{
    class CartManager
    {
        //Naming Convention 'A'dd
        public void Add(Product product)
        {
            Console.WriteLine(
                "Added in the Cart : " +    product.Name +
                " id : "                     +    product.Id +
                " discription : "          +    product.Discription +
                " unitprice : "            +    product.UnitPrice + 
                " Stock Amount : "     +    product.StockAmount);
        }

        public void Add2(string productName, string productDiscription, double unitPrice, int id,int StockAmount)
        {
            Console.WriteLine("Added" + productName);
        }

    }
}
