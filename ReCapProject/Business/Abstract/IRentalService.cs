using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetById(int rentalId);
        IResult Add(Rentals rental);
        IResult Delete(Rentals rental);
        IResult Update(Rentals rental);


    }
}
