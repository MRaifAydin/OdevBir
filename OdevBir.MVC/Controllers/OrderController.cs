using Microsoft.AspNetCore.Mvc;
using OdevBir.MVC.Models;

namespace OdevBir.MVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
