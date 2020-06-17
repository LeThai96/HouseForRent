using HouseForRent.Data.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DomainCore.Repository
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

        public void Delete(List<T> entities)
        {
            try
            {
                foreach(var entity in entities)
                {
                    if (entity != null)
                    {
                        collection.Remove(entity);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public T FindOne(Expression<Func<T, bool>> match)
        {
            return collection.FirstOrDefault(match);
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
                foreach (var entity in entities)
                {
                    if (entity != null)
                    {
                        collection.Add(entity);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(List<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
