﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    //Burada kurallarımızı yazıyoruz. TEntity ve TContext için geçerli olan kurallarım:
   public class EfEntityRepositoryBase <TEntity,TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
       where TContext : DbContext , new()
    {
        public void Add(TEntity entity)
        {
            //Bu operasyonu yazdığımızda çöp toplayıcısını beklemeden işi biten operasyonu atıyoruz.
            //Burada daha performanslı bir sistem geliştirmiş oluyoruz.
            //IDisposable pattern implementation of c# (Araştırma konusu)
            using (TContext context = new TContext())
            {
                //Bu kod ile Veri kaynağından gönderilen producta bir nesneyi eşleştir... Eşleşme olmayacağından dirket eklenecektir. Bu bir Add metodudur.
                var addedEntity = context.Entry(entity);//Referansı yakaladık
                addedEntity.State = EntityState.Added;//Yakaladığın referans eklenecek nesnedir.
                context.SaveChanges();//İşlemi gerçekleştir.
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                //Ternary Operator
                //Filtre eğer boş ise verilen filtreyi listele.
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
