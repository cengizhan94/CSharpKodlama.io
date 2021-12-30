using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //IEntityRepository'yi Product için yapılandırdık
    public interface IProductDal:IEntityRepository<Product>
    {
        

    }
}
