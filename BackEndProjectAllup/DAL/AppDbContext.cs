using AllupProject.Models;
using BackEndProjectAllup.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Cale 6 eu accumsan massa facilisis Madden by Steve", Price = 11.90, IsNewArrival = true, IsBestseller = false, IsFeatured = false, CreatedAt = DateTime.Now},
                new Product { Id = 2, Name = "Originals Kaval Wind breaker Winter Jacket eu...", Price = 23.90, DiscountPrice = 21.90, IsNewArrival = true, IsBestseller = false, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 3, Name = "Madden by Steve Madden Cale 6 eu accumsan massa...", Price = 11.90, IsNewArrival = true, IsBestseller = false, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 4, Name = "Water and Wind Resistant Insulated Jacket eu massa", Price = 11.90, IsNewArrival = true, IsBestseller = false, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 5, Name = "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..", Price = 18.90, IsNewArrival = false, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 6, Name = "Cale 6 eu accumsan massa facilisis Madden by Steve", Price = 29.90, IsNewArrival = false, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 7, Name = "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker", Price = 23.90, IsNewArrival = false, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 8, Name = "Juicy Couture Juicy Quilted Terry Track Jacket eu...", Price = 35.90, IsNewArrival = false, IsBestseller = true, IsFeatured = false, CreatedAt = DateTime.Now },
                new Product { Id = 9, Name = "Trans-Weight Hooded Wind and Water Resistant Shell", Price = 11.90, IsNewArrival = false, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now },
                new Product { Id = 10, Name = "New Balance Fresh Foam Kaymin eu accumsan massa...", Price = 11.90, IsNewArrival = false, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now },
                new Product { Id = 11, Name = "New Balance Fresh Foam LAZR v1 Sport eu accumsan...", Price = 18.90, IsNewArrival = false, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now },
                new Product { Id = 12, Name = "New Balance Arishi Sport v1Couture Juicy eu", Price = 29.00, DiscountPrice = 26.10, IsNewArrival = false, IsBestseller = false, IsFeatured = true, CreatedAt = DateTime.Now }

                );
            modelBuilder.Entity<ProductImage>().HasData(

                new ProductImage { Id = 1, ImageUrl = "product-1.jpg", IsMain = true, ProductId = 1 },
                new ProductImage { Id = 2, ImageUrl = "product-2.jpg", IsMain = false, ProductId = 1, IsSecond = true },
                new ProductImage { Id = 3, ImageUrl = "product-3.jpg", IsMain = true, ProductId = 2 },
                new ProductImage { Id = 4, ImageUrl = "product-4.jpg", IsMain = false, ProductId = 2, IsSecond = true },
                new ProductImage { Id = 5, ImageUrl = "product-5.jpg", IsMain = true, ProductId = 3 },
                new ProductImage { Id = 6, ImageUrl = "product-6.jpg", IsMain = true, ProductId = 4 },
                new ProductImage { Id = 7, ImageUrl = "product-7.jpg", IsMain = false, ProductId = 4, IsSecond = true },
                new ProductImage { Id = 8, ImageUrl = "product-8.jpg", IsMain = true, ProductId = 5 },
                new ProductImage { Id = 9, ImageUrl = "product-3.jpg", IsMain = true, ProductId = 6 },
                new ProductImage { Id = 10, ImageUrl = "product-9.jpg", IsMain = false, ProductId = 6, IsSecond = true },
                new ProductImage { Id = 11, ImageUrl = "product-10.jpg", IsMain = true, ProductId = 7 },
                new ProductImage { Id = 12, ImageUrl = "product-11.jpg", IsMain = false, ProductId = 7, IsSecond = true },
                new ProductImage { Id = 13, ImageUrl = "product-12.jpg", IsMain = true, ProductId = 8 },
                new ProductImage { Id = 14, ImageUrl = "product-16.jpg", IsMain = true, ProductId = 9 },
                new ProductImage { Id = 15, ImageUrl = "product-6.jpg", IsMain = false, ProductId = 9, IsSecond = true },
                new ProductImage { Id = 16, ImageUrl = "product-13.jpg", IsMain = true, ProductId = 10 },
                new ProductImage { Id = 17, ImageUrl = "product-14.jpg", IsMain = true, ProductId = 11 },
                new ProductImage { Id = 18, ImageUrl = "product-15.jpg", IsMain = false, ProductId = 11, IsSecond = true },
                new ProductImage { Id = 19, ImageUrl = "product-9.jpg", IsMain = true, ProductId = 12 }
            );

        }
    }
}
