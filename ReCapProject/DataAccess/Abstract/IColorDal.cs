using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Colors>
    {
        
    }
}
