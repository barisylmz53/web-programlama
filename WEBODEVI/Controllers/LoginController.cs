using Microsoft.AspNetCore.Mvc;

namespace WEBODEVI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult GirisYap()
        {
            return View();
        }
    }
}
