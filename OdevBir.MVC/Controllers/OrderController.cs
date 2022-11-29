using Microsoft.AspNetCore.Mvc;
using OdevBir.Business.Abstract;
using OdevBir.MVC.Models;

namespace OdevBir.MVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly ICustomerService _customerService;
        private readonly IEmployeeService _employeeService;

        public OrderController(IOrderService orderService, ICustomerService customerService, IEmployeeService employeeService)
        {
            _orderService = orderService;
            _customerService = customerService;
            _employeeService = employeeService;
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
                });
            }
            return View(list);
        }


    }
}
