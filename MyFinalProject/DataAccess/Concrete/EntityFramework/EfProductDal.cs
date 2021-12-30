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
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //Bu operasyonu yazdığımızda çöp toplayıcısına kullanılmayan referansı veriyoruz.
            //Burada daha performanslı bir sistem geliştirmiş oluyoruz.
            //IDisposable pattern implementation of c# (Araştırma konusu)
            using (NorthwindContext context = new NorthwindContext())
            {
                //Bu kod ile Veri kaynağından gönderilen producta bir nesneyi eşleştir... Eşleşme olmayacağından dirket eklenecektir. Bu bir Add metodudur.
                var addedEntity = context.Entry(entity);//Referansı yakaladık
                addedEntity.State = EntityState.Added;//Yakaladığın referans eklenecek nesnedir.
                context.SaveChanges();//İşlemi gerçekleştir.
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //Ternary Operator
                //Filtre eğer boş ise verilen filtreyi listele.
                return filter == null
                    ? context.Set<Product>().ToList()
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
