using Microsoft.Extensions.DependencyInjection;
using OER2.WebApi.Repositories;
using OER2.WebApi.Repositories.Interfaces;
using OER2.WebApi.Services;
using OER2.WebApi.Services.Interfaces;
using OER2.WebApi.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OER2.WebApi.Extensions
{
    public static class DIExtension
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<ISalesOrderRepository, SalesOrderRepository>();
            services.AddTransient<ISalesOrderService, SalesOrderService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
