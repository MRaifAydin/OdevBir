using AutoMapper;
using OdevBir.Core.Models;
using OdevBir.Dto.OrderDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion.MapperProfiles
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<OrderDetail, OrderDetailDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.OrderId))
                .ForMember(x => x.Product, opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
