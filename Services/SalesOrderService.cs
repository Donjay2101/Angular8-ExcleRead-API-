using OER2.WebApi.Entities;
using OER2.WebApi.Services.Interfaces;
using OER2.WebApi.UOW;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OER2.WebApi.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private IUnitOfWork _work;
        public SalesOrderService(IUnitOfWork work)
        {
            _work = work;
        }
        public void Delete(SalesOrder entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesOrder> GetAll()
        {
            return _work.salesOrderRepository.GetAll();
        }

        public IEnumerable<SalesOrder> GetBy(Func<SalesOrder, bool> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesOrder> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SalesOrder order)
        {
            throw new NotImplementedException();
        }

        public async Task InsertMulti(List<SalesOrder> order)
        {
            await Task.Run(() =>
            {
                order.ForEach(o =>
                {
                    _work.salesOrderRepository.Add(o);
                });
                _work.SaveChanges();
            });
        }

        public void update(SalesOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
