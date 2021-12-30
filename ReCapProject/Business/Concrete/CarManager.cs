using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            //Eğer eklenecek aracın ismi 2 karakterse veya büyükse,
            //Eğer karakterin günlük fiyatı sıfırdan büyükse
            //Ekleme işlemini gerçekleştir.
            if (car.Description.Length <= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("The car is added : " + car.Description);
            }
            //Koşullar sağlanmadıysa geçerli ve kurala uygun bilginin girilmesini iste.
            else
            {
                Console.WriteLine("Please enter valid information");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            //Her c için BrandId gönderilen id ile eşitse filtreleme gerçekleştir.
            //Yani marka id'sine göre araçları filtrele.
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            //Her c için ColorId gönderilen id ile eşitse filtreleme gerçekleştir.
            //Yani Renk id'sine göre araçları filtrele.
            return _carDal.GetAll(c => c.ColorId == id);

        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
