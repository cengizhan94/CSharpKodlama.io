using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {      
        public void Add(Colors entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Colors entity)
        {
            throw new NotImplementedException();
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Colors entity)
        {
            throw new NotImplementedException();
        }
    }
}
