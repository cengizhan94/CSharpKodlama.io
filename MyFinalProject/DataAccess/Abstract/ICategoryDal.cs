﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    // Category için yapılandırmış oluyoruz.
    public interface ICategoryDal : IEntityRepository<Category>
    {
       
    }
}