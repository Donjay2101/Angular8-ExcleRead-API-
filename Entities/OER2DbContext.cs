using Microsoft.EntityFrameworkCore;
namespace OER2.WebApi.Entities
{
    public class OER2DbContext:DbContext
    {
        public OER2DbContext(DbContextOptions<OER2DbContext> options) : base(options) { }

        public DbSet<SalesOrder> SalesOrders { get; set; }
    }
}
