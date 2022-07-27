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

    }
}
