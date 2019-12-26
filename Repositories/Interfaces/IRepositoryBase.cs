using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OER2.WebApi.Repositories.Interfaces
{
    public interface IRepositoryBase<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        T GetById(int id);
        IQueryable<T> GetBy(Func<T, bool> where);
    }
}
