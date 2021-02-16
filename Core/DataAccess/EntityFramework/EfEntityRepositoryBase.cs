﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>: IEntityRepository<TEntity>
            where TEntity : class, IEntity, new()
            where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            // using bittiğinde bellekten atma performans için iyi bir sey
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); // referansı yakala
                addedEntity.State = EntityState.Added;  // Eklenecek nesne 
                context.SaveChanges();                 // İşlemleri yapar
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); // referansı yakala
                deletedEntity.State = EntityState.Deleted;  // silinecek nesne 
                context.SaveChanges();                 // İşlemleri yapar
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter) //Tek data getirecek.
        {
            using (TContext context = new TContext())
            {
                // Bu kod arkaplanda select * from Tablo yu çalıştırır.
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // Bu kod arkaplanda select * from Tablo yu çalıştırır.
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var UpdateEntity = context.Entry(entity); // referansı yakala
                UpdateEntity.State = EntityState.Modified;  // güncellenecek nesne 
                context.SaveChanges();                 // İşlemleri yapar
            }
        }
    }
}
