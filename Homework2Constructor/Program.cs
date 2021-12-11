using System;

namespace Homework2Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Customer customer1 = new Customer { Id = 1,FirstName="Cengiz Han",LastName="Uyar",City="Tokat" };
           
        }
    }

    class Customer
    {
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
            this.City = city;
        }

        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
