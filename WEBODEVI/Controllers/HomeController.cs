using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Diagnostics;
using WEBODEVI.Data;
using WEBODEVI.Models;

namespace WEBODEVI.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Cars> cars2 = _context.Cars.ToList();
            return View(cars2);
        }
       
        public IActionResult About()
        {
            return View();
        }
        
        public IActionResult Pricing()
        {
            List<Cars> cars1 = _context.Cars.ToList();
            return View(cars1);
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult Car()
        {
            List<Cars> cars = _context.Cars.ToList();
            return View(cars);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}