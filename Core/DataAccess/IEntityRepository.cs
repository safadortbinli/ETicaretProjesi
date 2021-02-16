using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // generic constraint   T ti sınırlarız her yazdığımız olmasın diye
    // class = referans tiptir 
    // IEntity = IEntity olabilir veya IEntity implemente olan bir şey yazılabilir yaptık.
    // new 'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); // Kategorileri listele -- // expression= filtreleme işlemi yapar.
        T Get(Expression<Func<T, bool>> filter); //Tek bir datayı getirmek için..
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
