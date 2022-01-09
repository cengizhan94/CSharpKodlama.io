using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public IResult Add(Customer customer)
        {
            if (customer.FirstName.Length<2 && customer.LastName.Length<2)
            {
                return new ErrorResult(Messages.InvalidMessage);
            }
            else if (customer.Password == null && customer.Password.Length<6)
            {
                return new ErrorResult(Messages.InvalidMessage);
            }
            else if (customer.CompanyName == null && customer.CompanyName.Length<2)
            {
                return new ErrorResult(Messages.InvalidMessage);
            }
            else
            { 
                _customerDal.Add(customer);
                return new Result(true,Messages.AddedMessage);
            }
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new Result(true,Messages.DeletedMessage);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(),Messages.SuccessMessage);
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>
                (_customerDal.Get(p=>p.CustomerId == customerId),Messages.SuccessMessage);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new Result(true,Messages.UpdatedMessage);
        }
    }
}
