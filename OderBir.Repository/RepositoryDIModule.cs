using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdevBir.Repository.Abstract;
using OdevBir.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Repository
{
    public static class RepositoryDIModule
    {
        public static void Inject(IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IOrderDetailRepository, OrderDetailRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IShipperRepository, ShipperRepository>();
        }
    }
}
