using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;  //Proje referansı olarak Core'u seçtim. Namespace'i düzelttim. 

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
       
    }
}
