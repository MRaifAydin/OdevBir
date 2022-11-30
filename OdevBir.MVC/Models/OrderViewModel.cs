using OdevBir.Dto.Customers;
using OdevBir.Dto.Employees;

namespace OdevBir.MVC.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }

        public CustomerDto? Customer { get; set; }

        public EmployeeDto? Employee { get; set; }

        public DateTime? OrderDate { get; set; }

        public decimal OrderSum { get; set; }
    }
}
