using Microsoft.AspNetCore.Mvc;

namespace BackEndProjectAllup.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
