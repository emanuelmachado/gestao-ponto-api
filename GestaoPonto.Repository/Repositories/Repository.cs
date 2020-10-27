using GestaoPonto.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace GestaoPonto.Repository.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected GestaoPontoContext Db;

        protected DbSet<TEntity> DbSet;

        public Repository()
        {
            Db = new GestaoPontoContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Add(TEntity obj)
        {
            var objAdd = DbSet.Add(obj);

            Db.SaveChanges();

            return objAdd.Entity;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> GetAll(int take, int skip)
        {
            return DbSet.Take(take).Skip(skip).ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
            SaveChanges();
        }

        public virtual TEntity Update(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();

            return obj;
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
        
    }
}
