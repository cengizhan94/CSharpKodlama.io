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
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalsDal;

        public RentalManager(IRentalDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate.Date != null)
            {
                _rentalsDal.Add(rental);
                return new SuccessDataResult<Rental>(Messages.AvailableMessage);
            }
            else
            {
                return new ErrorDataResult<Rental>(Messages.NotAvailableMessage);
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalsDal.Delete(rental);
            return new Result(true,Messages.DeletedMessage);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalsDal.GetAll(),Messages.SuccessMessage);
        }
        public IDataResult<Rental> GetById(int rentalId)
        {
            return new SuccessDataResult<Rental>(_rentalsDal.Get(r=> r.RentalId == rentalId), Messages.SuccessMessage);
        }

        public IResult Update(Rental rental)
        {
            _rentalsDal.Update(rental);
            return new Result(true,Messages.UpdatedMessage);
        }
    }
}
