using OER2.WebApi.Entities;
using OER2.WebApi.Repositories.Interfaces;

namespace OER2.WebApi.Repositories
{
    public class SalesOrderRepository : RespositoryBase<SalesOrder>,ISalesOrderRepository
    {
        public SalesOrderRepository(OER2DbContext context) : base(context) { }
    }
}
