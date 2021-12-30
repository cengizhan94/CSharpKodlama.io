﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Colors> GetAll();
        void Add(Colors colors);
        void Delete(Colors color);
        void Update(Colors color);
    }
}
