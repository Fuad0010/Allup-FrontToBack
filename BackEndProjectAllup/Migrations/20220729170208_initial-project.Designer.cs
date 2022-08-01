﻿// <auto-generated />
using System;
using BackEndProjectAllup.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BackEndProjectAllup.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220729170208_initial-project")]
    partial class initialproject
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AllupProject.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId1");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("AllupProject.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("AllupProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "category-1.jpg",
                            IsDeleted = false,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "category-2.jpg",
                            IsDeleted = false,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "category-3.jpg",
                            IsDeleted = false,
                            Name = "Smartphone"
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "category-4.jpg",
                            IsDeleted = false,
                            Name = "Game Consoles"
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "category-5.jpg",
                            IsDeleted = false,
                            Name = "Bottoms"
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "category-6.jpg",
                            IsDeleted = false,
                            Name = "Tops & Sets"
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "category-7.jpg",
                            IsDeleted = false,
                            Name = "Audio & Video"
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "category-8.jpg",
                            IsDeleted = false,
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "category-9.jpg",
                            IsDeleted = false,
                            Name = "Camera"
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "category-10.jpg",
                            IsDeleted = false,
                            Name = "Accessories"
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "category-11.jpg",
                            IsDeleted = false,
                            Name = " Games & Consoles "
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "category-12.jpg",
                            IsDeleted = false,
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "category-1.jpg",
                            IsDeleted = false,
                            Name = "Tops & Sets"
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "category-2.jpg",
                            IsDeleted = false,
                            Name = "Bottoms"
                        });
                });

            modelBuilder.Entity("AllupProject.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("AllupProject.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("AllupProject.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("DiscountPrice")
                        .HasColumnType("float");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsBestseller")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNewArrival")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UptadetAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 579, DateTimeKind.Local).AddTicks(5208),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = true,
                            Name = "Cale 6 eu accumsan massa facilisis Madden by Steve",
                            Price = 11.9
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1846),
                            DiscountPrice = 21.899999999999999,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = true,
                            Name = "Originals Kaval Wind breaker Winter Jacket eu...",
                            Price = 23.899999999999999
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1869),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = true,
                            Name = "Madden by Steve Madden Cale 6 eu accumsan massa...",
                            Price = 11.9
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1871),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = true,
                            Name = "Water and Wind Resistant Insulated Jacket eu massa",
                            Price = 11.9
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1872),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Name = "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..",
                            Price = 18.899999999999999
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1874),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Name = "Cale 6 eu accumsan massa facilisis Madden by Steve",
                            Price = 29.899999999999999
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1875),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Name = "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker",
                            Price = 23.899999999999999
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1876),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = true,
                            IsDeleted = false,
                            IsFeatured = false,
                            IsNewArrival = false,
                            Name = "Juicy Couture Juicy Quilted Terry Track Jacket eu...",
                            Price = 35.899999999999999
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1877),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNewArrival = false,
                            Name = "Trans-Weight Hooded Wind and Water Resistant Shell",
                            Price = 11.9
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1879),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNewArrival = false,
                            Name = "New Balance Fresh Foam Kaymin eu accumsan massa...",
                            Price = 11.9
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1920),
                            DiscountPrice = 0.0,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNewArrival = false,
                            Name = "New Balance Fresh Foam LAZR v1 Sport eu accumsan...",
                            Price = 18.899999999999999
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1936),
                            DiscountPrice = 26.100000000000001,
                            InStock = false,
                            IsBestseller = false,
                            IsDeleted = false,
                            IsFeatured = true,
                            IsNewArrival = false,
                            Name = "New Balance Arishi Sport v1Couture Juicy eu",
                            Price = 29.0
                        });
                });

            modelBuilder.Entity("AllupProject.Models.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSecond")
                        .HasColumnType("bit");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageUrl = "product-1.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            ImageUrl = "product-2.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            ImageUrl = "product-3.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            ImageUrl = "product-4.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            ImageUrl = "product-5.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            ImageUrl = "product-6.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 7,
                            ImageUrl = "product-7.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 4
                        },
                        new
                        {
                            Id = 8,
                            ImageUrl = "product-8.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 9,
                            ImageUrl = "product-3.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 10,
                            ImageUrl = "product-9.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 6
                        },
                        new
                        {
                            Id = 11,
                            ImageUrl = "product-10.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 12,
                            ImageUrl = "product-11.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 7
                        },
                        new
                        {
                            Id = 13,
                            ImageUrl = "product-12.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 14,
                            ImageUrl = "product-16.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 9
                        },
                        new
                        {
                            Id = 15,
                            ImageUrl = "product-6.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 9
                        },
                        new
                        {
                            Id = 16,
                            ImageUrl = "product-13.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 10
                        },
                        new
                        {
                            Id = 17,
                            ImageUrl = "product-14.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 11
                        },
                        new
                        {
                            Id = 18,
                            ImageUrl = "product-15.jpg",
                            IsMain = false,
                            IsSecond = true,
                            ProductId = 11
                        },
                        new
                        {
                            Id = 19,
                            ImageUrl = "product-9.jpg",
                            IsMain = true,
                            IsSecond = false,
                            ProductId = 12
                        });
                });

            modelBuilder.Entity("AllupProject.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("AllupProject.Models.TagProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("TagProduct");
                });

            modelBuilder.Entity("AllupProject.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BackEndProjectAllup.Models.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImgUrl = "banner-1.png"
                        },
                        new
                        {
                            Id = 2,
                            ImgUrl = "banner-2.png"
                        });
                });

            modelBuilder.Entity("BackEndProjectAllup.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Save")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sliders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                            ImgUrl = "slider-1.jpg",
                            Name = "<span>4K2020 Virtual Reality</span>Fulldive VR.",
                            Save = "120"
                        },
                        new
                        {
                            Id = 2,
                            Desc = "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform",
                            ImgUrl = "slider-2.jpg",
                            Name = "<span>4K HDR Smart TV 43 </span>Sony Bravia.",
                            Save = "120"
                        });
                });

            modelBuilder.Entity("AllupProject.Models.BasketItem", b =>
                {
                    b.HasOne("AllupProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllupProject.Models.User", "User")
                        .WithMany("BasketItems")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("AllupProject.Models.Category", b =>
                {
                    b.HasOne("AllupProject.Models.Category", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("AllupProject.Models.Order", b =>
                {
                    b.HasOne("AllupProject.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("AllupProject.Models.OrderItem", b =>
                {
                    b.HasOne("AllupProject.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllupProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllupProject.Models.Product", b =>
                {
                    b.HasOne("AllupProject.Models.Brand", null)
                        .WithMany("Products")
                        .HasForeignKey("BrandId");

                    b.HasOne("AllupProject.Models.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("AllupProject.Models.ProductImage", b =>
                {
                    b.HasOne("AllupProject.Models.Product", "product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AllupProject.Models.TagProduct", b =>
                {
                    b.HasOne("AllupProject.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllupProject.Models.Tag", "Tag")
                        .WithMany("TagProducts")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}