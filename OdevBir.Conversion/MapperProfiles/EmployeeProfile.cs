using AutoMapper;
using OdevBir.Core.Models;
using OdevBir.Dto.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Conversion.MapperProfiles
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForMember(x => x.Id, opt => opt.MapFrom(y => y.EmployeeId))
                .ReverseMap();
        }
    }
}
