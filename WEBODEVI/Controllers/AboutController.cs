using Microsoft.AspNetCore.Mvc;
using WEBODEVI.Models;

namespace WEBODEVI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
