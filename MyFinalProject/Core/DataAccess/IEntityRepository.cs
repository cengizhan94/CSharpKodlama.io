using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;

namespace Core.DataAccess
{
    //Burada Entity kısmı Customer-Order vs... olabilir Projeye göre.
    //generic contraint
    //Bu IEntityRepository'i  kullanabilmek için Kuralları yazıyoruz:
    //class : Referans tip olabilir.
    //IEntity olabilir veya IEntity  implemente eden bir nesne olabilir.
    //new() newlenebilir olmalıdır.
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        //Kategoriler veya  ürünler için ayrı ayrı operasyonlar  yazmak yerine generic olarak tek bir operasyonla hepsine erişebilmek için expression yazıyoruz.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);//Filter null çünkü filtre vermemek mümkün. Filtre verilmediği zama tüm data isteniyor demektir.
        T Get(Expression<Func<T, bool>> filter);//Bir sistemde bir şeyin detayına inmek için de aynı Expression'u filter zorunlu olarak yazılıyor. Filter zorunlu çünkü filtrelemeden detayları incelemek zor...
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);  
    }
}
