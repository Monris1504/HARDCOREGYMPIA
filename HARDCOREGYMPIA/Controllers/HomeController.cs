using HARDCOREGYMPIA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HARDCOREGYMPIA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult INICIO()
        {
            return View();
        }

        public IActionResult TIENDA()
        {
            return View();
        }

        public IActionResult CONOCENOS()
        {
            return View();
        }

        public IActionResult SUCURSALES()
        {
            return View();
        }
        public IActionResult Usuario()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
