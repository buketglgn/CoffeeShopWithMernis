using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAcces
{
   public interface IRepositoryBaseDal<T>
    {
        void Add(T entity);
        void Delete(Expression<Func<T,bool>> filter);
        void Update(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter=null);
        T Get(Expression<Func<T,bool>> filter);

    }
}
