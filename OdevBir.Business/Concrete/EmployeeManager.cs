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
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee GetById(int id)
        {
            return _employeeRepository.Get(x => x.EmployeeId == id).SingleOrDefault();
        }
    }
}
