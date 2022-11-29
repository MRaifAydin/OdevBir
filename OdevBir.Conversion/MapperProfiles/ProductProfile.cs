using AutoMapper;
using OdevBir.Core.Models;
using OdevBir.Dto.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion.MapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.ProductId))
                .ForMember(x => x.Name, opt => opt.MapFrom(y => y.ProductName))
                .ReverseMap();
        }
    }
}
