using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Cengiz Han";
            customer.LastName = "Uyar";
            customer.CustomerId = 1;
            customer.Gender = true;

            Customer customer1 = new Customer();
            customer1.FirstName = "Zeynep";
            customer1.LastName = "Uyar";
            customer1.CustomerId = 2;
            customer1.Gender = false;

            CustomerManager manager = new CustomerManager();
            manager.Add(customer);
            manager.Delete(customer);
            manager.Update(customer1);

            
        }
        
      

    }
}
