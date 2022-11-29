using OdevBir.Dto.Employees;

namespace OdevBir.Business.Abstract
{
    public interface IEmployeeService
    {
        public EmployeeDto GetById(int id);
    }
}
