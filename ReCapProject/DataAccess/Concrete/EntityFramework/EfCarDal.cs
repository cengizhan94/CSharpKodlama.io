using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (RecapContext context = new RecapContext())
            {
                var addedEntity = context.Entry(entity); //Referansı tut
                addedEntity.State = EntityState.Added; //Eklenecek nesne
                context.SaveChanges();                        //Ekle
            }
        }

        public void Delete(Car entity)
        {
            using (RecapContext context = new RecapContext())
            {
                var deletedEntity = context.Entry(entity); //Referansı Tut
                deletedEntity.State = EntityState.Deleted; //Silinecek Nesne
                context.SaveChanges();                          //Sil
            }
        }
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RecapContext context = new RecapContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RecapContext context = new RecapContext())
            {
                return filter == null 
                    ? context.Set<Car>().ToList() 
                    : context.Set<Car>().Where(filter).ToList();
            }
        }
        public void Update(Car entity)
        {
            using (RecapContext context = new RecapContext())
            {
                var updatedEntity = context.Entry(entity);      //Referansı Tut
                updatedEntity.State = EntityState.Modified;    // Güncellenecek Nesne
                context.SaveChanges();                               //Güncelle
            }
        }
    }
}
