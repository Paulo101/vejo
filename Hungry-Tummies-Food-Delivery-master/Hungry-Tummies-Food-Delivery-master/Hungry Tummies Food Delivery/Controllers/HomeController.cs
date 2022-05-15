using Microsoft.AspNetCore.Mvc;

namespace Hungry_Tummies_Food_Delivery.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Onboard()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [ActionName("successful-login")]
        public IActionResult Success()
        {
            return View();
        }
        [ActionName("register-verify")]
        public IActionResult Verify()
        {
            return View();
        }
        public IActionResult Location()
        {
            return View();
        }
    }
}
