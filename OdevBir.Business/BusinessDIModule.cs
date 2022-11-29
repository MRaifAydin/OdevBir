using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdevBir.Business.Abstract;
using OdevBir.Business.Concrete;
using OdevBir.Conversion;
using OdevBir.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business
{
    public static class BusinessDIModule
    {
        public static void Inject(IServiceCollection services, IConfiguration configuration)
        {
            RepositoryDIModule.Inject(services, configuration);
            ConversionDIModule.Inject(services, configuration);


            services.AddTransient<ICustomerService, CustomerManager>();
            services.AddTransient<IEmployeeService, EmployeeManager>();
            services.AddTransient<IOrderDetailService, OrderDetailManager>();
            services.AddTransient<IOrderService, OrderManager>();
            services.AddTransient<IProductService, ProductManager>();
            services.AddTransient<IShipperService, ShipperManager>();
        }
    }
}
