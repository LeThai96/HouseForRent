using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HouseForRent.DomainCore.Repository
{
    public interface IBaseRepository<T>
    {
        void Insert(T entity);

        void InsertRange(List<T> entities);

        void Update(T entity);

        void UpdateRange(List<T> entities);

        void Delete(T entity);

        void DeleteRange(List<T> entities);

        Task<T> FindOne(Expression<Func<T, bool>> match);

        Task<T> FindByPK(dynamic key);

        Task<List<T>> FindByCondition(Expression<Func<T, bool>> match);

        Task<List<T>> FindAll();

        IQueryable<T> GetAll();
    }
}
