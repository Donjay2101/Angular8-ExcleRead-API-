using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OER2.WebApi.Config;
using OER2.WebApi.Entities;

namespace OER2.WebApi.Extensions
{
    public static class ConfigurationExtension
    {
        public static void AddConfiguration(this IServiceCollection services, IConfiguration Configuration)
        {
            var connectionString = Configuration.GetSection("DatabaseConfig:ConnectionString").Value;
            services.AddDbContext<OER2DbContext>(opt => opt.UseSqlServer(connectionString),ServiceLifetime.Transient);
            services.Configure<AppSettings>(opt => Configuration.GetSection("AppSettings").Bind(opt));
        }
    }
}
