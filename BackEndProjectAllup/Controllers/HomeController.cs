using BackEndProjectAllup.DAL;
using BackEndProjectAllup.Models;
using BackEndProjectAllup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BackEndProjectAllup.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.ToList();
            

            return View(homeVM);
        }
    }
}