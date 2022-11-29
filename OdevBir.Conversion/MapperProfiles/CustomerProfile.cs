using AutoMapper;
using OdevBir.Core.Models;
using OdevBir.Dto.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion.MapperProfiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.CustomerId))
                .ForMember(x => x.Name, opt => opt.MapFrom(y => y.ContactName))
                .ReverseMap();
        }
    }
}
