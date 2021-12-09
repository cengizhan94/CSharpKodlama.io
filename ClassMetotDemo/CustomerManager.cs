using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : " + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi : " + customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi : " + customer.FirstName);
        }
    }
}
