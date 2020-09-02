using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Uplift.DataAccess.Data.Repository.IRepositoty
{
    // reposistory interface only contains definitions for others repositories implement

    // using generic type T so that all different classes can implement

    // generic type T is set as class because will be implemented by classes

    public interface IRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);
    }
}
