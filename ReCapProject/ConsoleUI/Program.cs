using System;
using Business.Concrete;
using DataAccess.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager manager = new CarManager(new InMemoryDal());

            foreach (var car in manager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
