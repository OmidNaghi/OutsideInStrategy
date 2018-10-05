using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace WPF_SecurityUI.DataProvider
{
    public interface IDataProvider<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> ReadAll();
        IEnumerable<TEntity> ReadAll(int Id);
        IEnumerable<TEntity> ReadAll(Expression<Func<TEntity, bool>> predicate);

        bool Create(TEntity entity);
        bool Delete(TEntity entity);
        bool Update(TEntity entity);
    }
}
