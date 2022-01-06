using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(Car car)
        {
            //Eğer eklenecek aracın ismi 2 karakterse veya 2 karakterden büyükse,
            //Eğer karakterin günlük fiyatı sıfırdan büyükse,
            //Ekleme işlemini gerçekleştir.
            if (car.CarName.Length <= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                
            }
            else if(car.CarName.Length < 2)
            {
                return new ErrorResult(Messages.InvalidMessage);
            }
            return new Result(true, Messages.AddedMessage);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new Result(true, Messages.DeletedMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==11)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            //DataResult bize burada yapılan işleme göre olumlu veya olumsuz mesajın dönmesini,
            //Mesaj ile birlikte data'nın da dönmesini sağlayacak.
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<Car> GetById(int carId)
        {
           return new SuccessDataResult<Car>(_carDal.Get(p=> p.CarId == carId),Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            //Her c için BrandId gönderilen id ile eşitse filtreleme gerçekleştir.
            //Yani marka id'sine göre araçları filtrele.
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id),Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            //Her c için ColorId gönderilen id ile eşitse filtreleme gerçekleştir.
            //Yani Renk id'sine göre araçları filtrele.
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id), Messages.SuccessMessage);

        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new Result(true, Messages.UpdatedMessage);
        }
    }
}
