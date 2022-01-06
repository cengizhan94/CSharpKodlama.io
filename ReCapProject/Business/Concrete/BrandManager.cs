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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName == null)
            {
                return new ErrorResult(Messages.InvalidMessage);
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.AddedMessage);
            }
        }

        public IResult Delete(Brand brand)
        {
            //Burayı daha da profesyonel hale getirebilirim, araştıracağım.
            if (true)
            {
                _brandDal.Delete(brand);
                return new Result(true, Messages.DeletedMessage);
            }
            else
            {
                return new ErrorResult(Messages.InvalidMessage);
                
            }
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (DateTime.Now.Hour == 11)
            {
                return new ErrorDataResult<List<Brand>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId),Messages.SuccessMessage);
        }

        public IResult Update(Brand brand)
        {
            if (true)
            {
                _brandDal.Update(brand);
                return new Result(true, Messages.UpdatedMessage);
            }
            else
            {
               return new ErrorResult(Messages.InvalidMessage);  
            }
            
        }
    }
}
