using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerManager manager = new CustomerManager();
            ProductManager manager1 = new ProductManager();
            manager1.Add();
            manager.Add();


            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Cengiz Han";
            customer1.LastName = "Uyar";
            customer1.City = "Tokat";

            Customer customer2 = new Customer
            {
                Id = 2,
                FirstName = "Zeynep",
                LastName = "Uyar",
                City = "Tokat"
            };

            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
            
        }
    }

    class Customer
    {
        //Encapsulation
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }

}
