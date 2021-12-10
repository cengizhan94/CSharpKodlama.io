using System;

namespace ReferenceTypesHomework1
{
    class Program
    {
        static void Main(string[] args)
        {

            //numeric types are value type
            int number1 = 10; 
            int number2 = 20;
            number1 = number2;
            number2 = 100;
            //Console.WriteLine(number1);


            //Arrays are Reference Type.
            int[] numbers1 = new int[] { 1, 3, 5, 7 };
            int[] numbers2 = new int[] { 10, 30, 50, 70 };
            numbers1 = numbers2;
            numbers2[0] = 100;
            //Console.WriteLine(numbers1[0]);

            //Classes are Reference Type

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstNane = "Cengiz Han";
            person2 = person1;
            person1.FirstNane = "Zeynep";
            //Console.WriteLine(person2.FirstNane);

            Employee employee = new Employee();
            employee.FirstNane = "Mustafa";
            Customer customer = new Customer();
            customer.FirstNane = "Pervin";
            customer.CreditCartNumber = "1234567890";
            Person person3 = customer;
            Person person4 = employee;
            customer.FirstNane = "Zeynep";
            //Console.WriteLine(((Customer)person3).CreditCartNumber); //<<Boxing yapmak person3 ün önüne parantez içinde Customer


            PersonManager manager = new PersonManager();
            manager.Add(employee);


            
        }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }


    class Customer : Person
    {
        public string CreditCartNumber { get; set; }
    }
    //Base Class is Person
    class Person
    {
        public int id { get; set; }
        public string FirstNane { get; set; }
        public string LastName { get; set; }

    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstNane);
        }
    }

}
