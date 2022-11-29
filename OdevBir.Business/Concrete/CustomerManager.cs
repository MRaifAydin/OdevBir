using OdevBir.Business.Abstract;
using OdevBir.Core.Models;
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

        public CustomerManager(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Customer GetById(int id)
        {
            return _customerRepository.Get(x => x.CustomerId == id.ToString()).FirstOrDefault();
        }
    }
}
