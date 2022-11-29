using Microsoft.AspNetCore.Mvc;
using OdevBir.Business.Abstract;
using OdevBir.MVC.Models;

namespace OdevBir.MVC.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailService _orderDetailService;
        private readonly IProductService _productService;

        public OrderDetailController(IOrderDetailService orderDetailService, IProductService productService)
        {
            _orderDetailService = orderDetailService;
            _productService = productService;
        }

        public IActionResult Index(int id)
        {
            var data = _orderDetailService.GetById(id);

            List<OrderDetailViewModel> list = new List<OrderDetailViewModel>();

            foreach (var item in data)
            {
                list.Add(new OrderDetailViewModel
                {
                    Id = item.Id,
                    Product = _productService.GetById(item.ProductId),
                    UnitPrice = (item.UnitPrice - (decimal)((float)item.UnitPrice * item.Discount)),
                    Quantity = item.Quantity,
                    Discount = item.Discount
                });
            }


            return View(list);
        }
    }
}
