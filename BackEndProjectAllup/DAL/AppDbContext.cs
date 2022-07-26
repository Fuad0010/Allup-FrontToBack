using AllupProject.Models;
using BackEndProjectAllup.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndProjectAllup.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> Banners { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Slider>().HasData(
                new Slider { Id = 1, ImgUrl = "slider-1.jpg", Save = "120", Name = "<span>4K2020 Virtual Reality</span>Fulldive VR.", Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform" },
                new Slider { Id = 2, ImgUrl = "slider-2.jpg", Save = "120", Name = "<span>4K HDR Smart TV 43 </span>Sony Bravia.", Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform" }
            );

            modelBuilder.Entity<Banner>().HasData(
                new Banner { Id = 1, ImgUrl = "banner-1.png" },
                new Banner { Id = 2, ImgUrl = "banner-2.png" }
            );



        }
    }
}
