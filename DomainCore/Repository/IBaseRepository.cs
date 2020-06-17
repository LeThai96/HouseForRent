using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.Repository
{
    public interface IBaseRepository<T>
    {
        void Insert(T entity);

        void InsertRange(List<T> entities);

        void Update(T entity);

        void UpdateRange(List<T> entities);

        void Delete(T entity);

        void Delete(List<T> entities);

        T FindOne(Expression<Func<T, bool>> match);

        IQueryable<T> GetAll();
    }
}
