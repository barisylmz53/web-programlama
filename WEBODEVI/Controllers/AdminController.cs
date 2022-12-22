using Microsoft.AspNetCore.Mvc;

namespace WEBODEVI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
