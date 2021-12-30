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

            foreach (var car in manager.GetCarsByColorId(1))
            {
                Console.WriteLine(car.ColorId);
            }
        }
    }
}
