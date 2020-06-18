using HouseForRent.DomainCore.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        IBaseRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangeAsync();
    }
}
