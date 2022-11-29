using AutoMapper;
using OdevBir.Core.Models;
using OdevBir.Dto.Shippers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion.MapperProfiles
{
    public class ShipperProfile : Profile
    {
        public ShipperProfile()
        {
            CreateMap<Shipper, ShipperDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.ShipperId))
                .ReverseMap();
        }
    }
}
