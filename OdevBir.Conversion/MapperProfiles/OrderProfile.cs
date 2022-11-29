using AutoMapper;
using OdevBir.Core.Models;
using OdevBir.Dto.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion.MapperProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.OrderId))
                .ForMember(x => x.Customer, opt => opt.Ignore())
                .ForMember(x => x.Employee, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
