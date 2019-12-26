using OER2.WebApi.Entities;
using OER2.WebApi.Repositories;
using OER2.WebApi.Repositories.Interfaces;

namespace OER2.WebApi.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        OER2DbContext _context;
        private ISalesOrderRepository _salesOrderRepository;
        public UnitOfWork(OER2DbContext context)
        {
            _context = context;
        }



        public ISalesOrderRepository salesOrderRepository
        {
            get
            {
                if(_salesOrderRepository == null)
                {
                    _salesOrderRepository = new SalesOrderRepository(_context);
                }
                return _salesOrderRepository;
            }
        }

        public void Dispose()
        {
           // _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
