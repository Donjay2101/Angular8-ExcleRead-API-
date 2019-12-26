using OER2.WebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OER2.WebApi.Services.Interfaces
{
    public interface ISalesOrderService
    {
        void Insert(SalesOrder order);
        Task InsertMulti(List<SalesOrder> order);

        void update(SalesOrder entity);
        void Delete(SalesOrder entity);

        IEnumerable<SalesOrder> GetAll();

        IEnumerable<SalesOrder> GetById(int id);

        IEnumerable<SalesOrder> GetBy(Func<SalesOrder, bool> where);
    }
}
