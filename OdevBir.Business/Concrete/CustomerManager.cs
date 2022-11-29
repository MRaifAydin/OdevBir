using AutoMapper;
using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
using OdevBir.Dto.Customers;
using OdevBir.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerManager(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public CustomerDto GetById(string id)
        {
            var entity = _customerRepository.Get(x => x.CustomerId == id.ToString()).FirstOrDefault();
            return _mapper.Map<Customer, CustomerDto>(entity);
        }
    }
}
