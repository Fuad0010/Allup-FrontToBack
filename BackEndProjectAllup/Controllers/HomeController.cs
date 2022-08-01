using BackEndProjectAllup.DAL;
using BackEndProjectAllup.Models;
using BackEndProjectAllup.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            homeVM.Banners = _context.Banners.ToList();
            homeVM.Categories = _context.Categories.ToList();
            homeVM.NewArrivals = _context.Products.Include(p => p.ProductImages).Where(p=>p.IsNewArrival).ToList();

            homeVM.Bestseller = _context.Products.Where(p => p.IsBestseller).ToList();

            homeVM.Featured = _context.Products.Where(p => p.IsFeatured).ToList();

            homeVM.ProductImages = _context.ProductImages.ToList();

            return View(homeVM);
        }
    }
}