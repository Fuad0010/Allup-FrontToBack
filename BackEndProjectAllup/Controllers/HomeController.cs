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

            HomeVM homeVM = new HomeVM()
            {
                Sliders = _context.Sliders.ToList(),
                Banners = _context.Banners.ToList(),
                Categories = _context.Categories.ToList(),
                Bestseller = _context.Products.Where(p => p.BestSeller).ToList(),
                NewArrivals = _context.Products.Where(p=>p.NewArrival).ToList(),
                Featured = _context.Products.Where(p=>p.IsFeatured).ToList()
                
            };

            return View(homeVM);
        }
    }
}