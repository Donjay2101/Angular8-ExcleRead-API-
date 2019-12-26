using Microsoft.EntityFrameworkCore;
using OER2.WebApi.Entities;
using OER2.WebApi.Repositories.Interfaces;
using System;
using System.Linq;

namespace OER2.WebApi.Repositories
{
    public class RespositoryBase<T> : IRepositoryBase<T> where T : BaseEntity
    {
        DbSet<T> dbset;
        DbContext _context;
        public RespositoryBase(OER2DbContext context)
        {
            _context = context;
            dbset = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public void Delete(T entity)
        {
            dbset.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return dbset.AsQueryable();
        }

        public IQueryable<T> GetBy(Func<T, bool> where)
        {
            return dbset.Where(where).AsQueryable();
        }

        public T GetById(int id)
        {
            return dbset.FirstOrDefault(x => x.ID ==id);
        }

        public void Update(T entity)
        {
            dbset.Update(entity);
        }
    }
}
