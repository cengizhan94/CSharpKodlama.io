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
        IRentalsDal _rentalsDal;

        public RentalManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals rental)
        {
            if (rental.ReturnDate.Date != null)
            {
                _rentalsDal.Add(rental);
                return new SuccessDataResult<Rentals>(Messages.AvailableMessage);
            }
            else
            {
                return new ErrorDataResult<Rentals>(Messages.NotAvailableMessage);
            }
        }

        public IResult Delete(Rentals rental)
        {
            _rentalsDal.Delete(rental);
            return new Result(true,Messages.DeletedMessage);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(),Messages.SuccessMessage);
        }
        public IDataResult<Rentals> GetById(int rentalId)
        {
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(p => p.ID == rentalId), Messages.SuccessMessage);
        }

        public IResult Update(Rentals rental)
        {
            _rentalsDal.Update(rental);
            return new Result(true,Messages.UpdatedMessage);
        }
    }
}
