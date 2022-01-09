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

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length<2 && user.LastName.Length<2)
            {
                return new ErrorResult(Messages.TextInvalidMessage);
            }
            else if (user.Password.Length < 6 && user.Password == null)
            {
                return new ErrorResult(Messages.PasswordInvalidMessage);
            }
            else
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.AddedMessage);
            }
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
