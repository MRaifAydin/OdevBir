using Microsoft.AspNetCore.Mvc;
using OdevBir.Business.Abstract;
using OdevBir.Dto.Shippers;

namespace OdevBir.MVC.Controllers
{
    public class ShipperController : Controller
    {
        private readonly IShipperService _shipperService;

        public ShipperController(IShipperService shipperService)
        {
            _shipperService = shipperService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ShipperDto dto)
        {
            _shipperService.InsertOne(dto);

            return View("Add", dto);
        }
    }
}
