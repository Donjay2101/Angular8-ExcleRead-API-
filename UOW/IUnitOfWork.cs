using OER2.WebApi.Repositories.Interfaces;

namespace OER2.WebApi.UOW
{
    public interface IUnitOfWork
    {
        ISalesOrderRepository salesOrderRepository { get; }
        void SaveChanges();
        void Dispose();
    }
}
