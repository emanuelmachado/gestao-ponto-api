using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GestaoPonto.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Add(TEntity obj);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll(int take, int skip);

        TEntity GetById(int id);

        TEntity Update(TEntity obj);

        void Remove(int id);

        int SaveChanges();
    }
}
