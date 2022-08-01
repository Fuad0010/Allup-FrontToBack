using AllupProject.Models;
using BackEndProjectAllup.Models;
using System.Collections.Generic;

namespace BackEndProjectAllup.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Banner> Banners { get; set; }
        public List<Category> Categories { get; set; }

        public List<Product> NewArrivals { get; set; }
        public List<Product> Bestseller { get; set; }
        public List<Product> Featured { get; set; }
        public List<ProductImage> ProductImages { get; set; }

        //public List<Product> Computer { get; set; }
        //public List<Product> Smartphone { get; set; }
        //public List<Product> GameConsoles { get; set; }
    }
}
