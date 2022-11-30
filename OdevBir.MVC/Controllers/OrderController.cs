using Microsoft.AspNetCore.Mvc;
using OdevBir.Business.Abstract;
using OdevBir.Dto.OrderDetails;
using OdevBir.MVC.Models;

namespace OdevBir.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;
        private readonly IOrderDetailService _orderDetailService;

        public OrderController(IOrderService orderService, ICustomerService customerService, IEmployeeService employeeService, IOrderDetailService orderDetailService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _employeeService = employeeService;
            _orderDetailService = orderDetailService;
        }

        public IActionResult Index()
        {
            var data = _orderService.GetAll();

            List<OrderViewModel> list = new List<OrderViewModel>();

            foreach (var item in data)
            {
                list.Add(new OrderViewModel
                {
                    Id = item.Id,
                    Customer = _customerService.GetById(item.CustomerId),
                    Employee = _employeeService.GetById(item.EmployeeId),
                    OrderDate = item.OrderDate,

                    OrderSum = Sum(_orderDetailService.GetById(item.Id).ToList())
                });
            }

            decimal Sum(List<OrderDetailDto> list)
            {
                decimal totalSum = 0;
                list.ForEach(x => totalSum += x.UnitPrice - (decimal)((float)x.UnitPrice * x.Discount));
                return totalSum;
            }

            return View(list);
        }


    }
}
