using AutoMapper.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OdevBir.Conversion.MapperProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion
{
    public class ConversionDIModule
    {

        public static void Inject(IServiceCollection services)
        {
            services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<CustomerProfile>();
                cfg.AddProfile<EmployeeProfile>();
                cfg.AddProfile<OrderDetailProfile>();
                cfg.AddProfile<OrderProfile>();
                cfg.AddProfile<ProductProfile>();
                cfg.AddProfile<ShipperProfile>();
            });
        }
    }
}
