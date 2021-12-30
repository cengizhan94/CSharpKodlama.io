using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>//Buraya IEntity gibi newlenemeyen bir nesne yazılmaması için kurallar yazılmıştır. Yalnızca projedeki nesneler buraya yazılabilir.
    {

    }
}
