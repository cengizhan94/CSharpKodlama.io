using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Entities.Concrete;
using DataAccess.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Vlidation;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
                _userDal.Add(user);
                return new SuccessResult(Messages.AddedMessage); 
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.DeletedMessage);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll().ToString()); //<To string?
        }

        public IDataResult<User> GetById(int userId)
        {
          
            return new SuccessDataResult<User>(_userDal.Get(p => p.UserId == userId),Messages.SuccessMessage);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.UpdatedMessage);

        }
    }
}
