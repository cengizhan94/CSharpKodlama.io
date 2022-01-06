using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Colors>> GetAll();
        IDataResult<Colors> GetById(int ColorId);
        IResult Add(Colors color);
        IResult Delete(Colors color);
        IResult Update(Colors color);
    }
}
