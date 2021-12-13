using System;

namespace HomeWork1Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterFacesIntro();



        }

        private static void InterFacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Student { Id = 1, StudentId = 1, FirstName = "Cengiz Han", LastName = "Uyar", Department = "Yazılım Mühendisliği" });
            manager.Add(new Customer { Id = 2, CustomerId = 2, FirstName = "Zeynep", LastName = "Uyar", Adress = "Tokat" });
        }
    }
    interface IPerson
    {
        
        int  Id { get; set; }
       string FirstName { get; set; }
       string LastName { get; set; }
    }

    class Customer :IPerson
    {
        public int CustomerId { get; set; }
        public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student :IPerson
    {
        public int StudentId { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        
        public void Add(IPerson person)
        {
            Console.WriteLine("Person Eklendi :" + person.FirstName);
        }
    }
}
