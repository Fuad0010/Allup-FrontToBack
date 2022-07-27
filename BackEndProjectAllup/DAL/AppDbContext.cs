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
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, ImageUrl = "category-1.jpg", Name = "Laptop" },
                new Category { Id = 2, ImageUrl = "category-2.jpg", Name = "Computer" },
                new Category { Id = 3, ImageUrl = "category-3.jpg", Name = "Smartphone" },
                new Category { Id = 4, ImageUrl = "category-4.jpg", Name = "Game Consoles" },
                new Category { Id = 5, ImageUrl = "category-5.jpg", Name = "Bottoms" },
                new Category { Id = 6, ImageUrl = "category-6.jpg", Name = "Tops & Sets" },
                new Category { Id = 7, ImageUrl = "category-7.jpg", Name = "Audio & Video" },
                new Category { Id = 8, ImageUrl = "category-8.jpg", Name = "Accessories" },
                new Category { Id = 9, ImageUrl = "category-9.jpg", Name = "Camera" },
                new Category { Id = 10, ImageUrl = "category-10.jpg", Name = "Accessories" },
                new Category { Id = 11, ImageUrl = "category-11.jpg", Name = " Games & Consoles " },
                new Category { Id = 12, ImageUrl = "category-12.jpg", Name = "Video Games" },
                new Category { Id = 13, ImageUrl = "category-1.jpg", Name = "Tops & Sets" },
                new Category { Id = 14, ImageUrl = "category-2.jpg", Name = "Bottoms" }
                );


        }
    }
}
