using OdevBir.Dto.Customers;
using OdevBir.Dto.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevBir.Dto.Orders
{
    public class OrderDto
    {
        public int Id { get; set; }

        public string? CustomerId { get; set; }

        public int? EmployeeId { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}
