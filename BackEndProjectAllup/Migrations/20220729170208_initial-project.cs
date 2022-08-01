using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEndProjectAllup.Migrations
{
    public partial class initialproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<int>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Save = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    ImgUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsFeatured = table.Column<bool>(nullable: false),
                    IsBestseller = table.Column<bool>(nullable: false),
                    IsNewArrival = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    InStock = table.Column<bool>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    DiscountPrice = table.Column<double>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    DeletedAt = table.Column<DateTime>(nullable: true),
                    UptadetAt = table.Column<DateTime>(nullable: true),
                    BrandId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    OrderStatus = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsMain = table.Column<bool>(nullable: false),
                    IsSecond = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagProduct",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    TagId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TagProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagProduct_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<double>(nullable: false),
                    Count = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Banners",
                columns: new[] { "Id", "ImgUrl" },
                values: new object[,]
                {
                    { 1, "banner-1.png" },
                    { 2, "banner-2.png" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "ImageUrl", "IsDeleted", "Name", "ParentId", "UptadetAt" },
                values: new object[,]
                {
                    { 1, null, null, "category-1.jpg", false, "Laptop", null, null },
                    { 14, null, null, "category-2.jpg", false, "Bottoms", null, null },
                    { 13, null, null, "category-1.jpg", false, "Tops & Sets", null, null },
                    { 12, null, null, "category-12.jpg", false, "Video Games", null, null },
                    { 10, null, null, "category-10.jpg", false, "Accessories", null, null },
                    { 9, null, null, "category-9.jpg", false, "Camera", null, null },
                    { 11, null, null, "category-11.jpg", false, " Games & Consoles ", null, null },
                    { 7, null, null, "category-7.jpg", false, "Audio & Video", null, null },
                    { 6, null, null, "category-6.jpg", false, "Tops & Sets", null, null },
                    { 5, null, null, "category-5.jpg", false, "Bottoms", null, null },
                    { 4, null, null, "category-4.jpg", false, "Game Consoles", null, null },
                    { 3, null, null, "category-3.jpg", false, "Smartphone", null, null },
                    { 2, null, null, "category-2.jpg", false, "Computer", null, null },
                    { 8, null, null, "category-8.jpg", false, "Accessories", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreatedAt", "DeletedAt", "DiscountPrice", "InStock", "IsBestseller", "IsDeleted", "IsFeatured", "IsNewArrival", "Name", "Price", "UptadetAt" },
                values: new object[,]
                {
                    { 9, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1877), null, 0.0, false, false, false, true, false, "Trans-Weight Hooded Wind and Water Resistant Shell", 11.9, null },
                    { 12, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1936), null, 26.100000000000001, false, false, false, true, false, "New Balance Arishi Sport v1Couture Juicy eu", 29.0, null },
                    { 11, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1920), null, 0.0, false, false, false, true, false, "New Balance Fresh Foam LAZR v1 Sport eu accumsan...", 18.899999999999999, null },
                    { 10, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1879), null, 0.0, false, false, false, true, false, "New Balance Fresh Foam Kaymin eu accumsan massa...", 11.9, null },
                    { 8, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1876), null, 0.0, false, true, false, false, false, "Juicy Couture Juicy Quilted Terry Track Jacket eu...", 35.899999999999999, null },
                    { 1, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 579, DateTimeKind.Local).AddTicks(5208), null, 0.0, false, false, false, false, true, "Cale 6 eu accumsan massa facilisis Madden by Steve", 11.9, null },
                    { 6, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1874), null, 0.0, false, true, false, false, false, "Cale 6 eu accumsan massa facilisis Madden by Steve", 29.899999999999999, null },
                    { 5, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1872), null, 0.0, false, true, false, false, false, "Juicy Couture Solid Sleeve Puffer Jacket eu accumsan..", 18.899999999999999, null },
                    { 4, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1871), null, 0.0, false, false, false, false, true, "Water and Wind Resistant Insulated Jacket eu massa", 11.9, null },
                    { 3, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1869), null, 0.0, false, false, false, false, true, "Madden by Steve Madden Cale 6 eu accumsan massa...", 11.9, null },
                    { 2, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1846), null, 21.899999999999999, false, false, false, false, true, "Originals Kaval Wind breaker Winter Jacket eu...", 23.899999999999999, null },
                    { 7, null, null, new DateTime(2022, 7, 29, 21, 2, 8, 580, DateTimeKind.Local).AddTicks(1875), null, 0.0, false, true, false, false, false, "Winter Jacket eu accumsan massa facili originals Kaval Wind breaker", 23.899999999999999, null }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Desc", "ImgUrl", "Name", "Save" },
                values: new object[,]
                {
                    { 1, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "slider-1.jpg", "<span>4K2020 Virtual Reality</span>Fulldive VR.", "120" },
                    { 2, "Explore and immerse in exciting 360 content with Fulldive’s all-in-one virtual reality platform", "slider-2.jpg", "<span>4K HDR Smart TV 43 </span>Sony Bravia.", "120" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageUrl", "IsMain", "IsSecond", "ProductId" },
                values: new object[,]
                {
                    { 1, "product-1.jpg", true, false, 1 },
                    { 17, "product-14.jpg", true, false, 11 },
                    { 16, "product-13.jpg", true, false, 10 },
                    { 15, "product-6.jpg", false, true, 9 },
                    { 14, "product-16.jpg", true, false, 9 },
                    { 13, "product-12.jpg", true, false, 8 },
                    { 12, "product-11.jpg", false, true, 7 },
                    { 11, "product-10.jpg", true, false, 7 },
                    { 18, "product-15.jpg", false, true, 11 },
                    { 10, "product-9.jpg", false, true, 6 },
                    { 8, "product-8.jpg", true, false, 5 },
                    { 7, "product-7.jpg", false, true, 4 },
                    { 6, "product-6.jpg", true, false, 4 },
                    { 5, "product-5.jpg", true, false, 3 },
                    { 4, "product-4.jpg", false, true, 2 },
                    { 3, "product-3.jpg", true, false, 2 },
                    { 2, "product-2.jpg", false, true, 1 },
                    { 9, "product-3.jpg", true, false, 6 },
                    { 19, "product-9.jpg", true, false, 12 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_UserId1",
                table: "BasketItems",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentId",
                table: "Categories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TagProduct_ProductId",
                table: "TagProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_TagProduct_TagId",
                table: "TagProduct",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "TagProduct");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
