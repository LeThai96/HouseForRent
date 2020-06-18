using HouseForRent.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HouseForRent.DomainCore.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly HouseForRentDbContext _context;
        private DbSet<T> collection;

        public BaseRepository(HouseForRentDbContext context)
        {
            _context = context;
            collection = context.Set<T>();
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity != null)
                {
                    collection.Remove(entity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void DeleteRange(List<T> entities)
        {
            try
            {
                collection.RemoveRange(entities);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public async Task<List<T>> FindAll()
        {
            return await collection.ToListAsync();
        }

        public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> match)
        {
            return await collection.Where(match).ToListAsync();
        }

        public async Task<T> FindByPK(dynamic key)
        {
            return await collection.FindAsync(key);
        }

        public async Task<T> FindOne(Expression<Func<T, bool>> match)
        {
            return await collection.FirstOrDefaultAsync(match);
        }

        public IQueryable<T> GetAll()
        {
            return collection.AsQueryable();
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity != null)
                {
                    collection.Add(entity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void InsertRange(List<T> entities)
        {
            try
            {
                collection.AddRange(entities);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void Update(T entity)
        {
            try
            {
                collection.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void UpdateRange(List<T> entities)
        {
            try
            {
                collection.UpdateRange(entities);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
