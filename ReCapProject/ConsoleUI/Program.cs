using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager   colorManager = new ColorManager(new EfColorDal());
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in carManager.GetAll().Data)
                {
                     Console.WriteLine(car.CarName + "/" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
