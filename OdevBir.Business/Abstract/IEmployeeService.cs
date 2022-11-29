using OdevBir.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Business.Abstract
{
    public interface IEmployeeService
    {
        public Employee GetById(int id);
    }
}
