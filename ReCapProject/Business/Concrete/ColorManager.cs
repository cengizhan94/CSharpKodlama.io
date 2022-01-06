using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Colors color)
        {
                _colorDal.Add(color);
                return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(Colors color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(Messages.DeletedMessage);
        }

        public IDataResult<List<Colors>> GetAll()
        {
            return new DataResult<List<Colors>>(_colorDal.GetAll(),true, Messages.SuccessMessage);
        }

        public IDataResult<Colors> GetById(int colorId)
        {
            return new SuccessDataResult<Colors>(_colorDal.Get(c=> c.ColorId == colorId),Messages.SuccessMessage);
        }

        public IResult Update(Colors color)
        {
            _colorDal.Update(color);
            return new SuccessResult(Messages.UpdatedMessage);
        }
    }
}
