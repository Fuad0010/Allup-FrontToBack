using Microsoft.AspNetCore.Mvc;

namespace BackEndProjectAllup.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
