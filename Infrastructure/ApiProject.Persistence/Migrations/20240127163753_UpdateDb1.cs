using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => new { x.ProductId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ProductCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(2683), "Beauty" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(2692), "Automotive" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(2750), "Garden & Music" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 27, 19, 37, 53, 260, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 263, DateTimeKind.Local).AddTicks(4168), "Rem çünkü.", "Sıradanlıktan." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 263, DateTimeKind.Local).AddTicks(4360), "Non adanaya.", "Voluptatem." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 263, DateTimeKind.Local).AddTicks(4379), "Mıknatıslı inventore.", "Doğru." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 267, DateTimeKind.Local).AddTicks(4368), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1.221317409002130m, 478.15m, "Practical Granite Mouse" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 27, 19, 37, 53, 267, DateTimeKind.Local).AddTicks(4576), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6.838000042120060m, 793.96m, "Tasty Wooden Car" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_CategoryId",
                table: "ProductCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(4707), "Tools" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(4749), "Shoes & Jewelery" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(4760), "Books & Health" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 21, 19, 50, 23, 371, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 373, DateTimeKind.Local).AddTicks(2620), "Accusantium voluptatem.", "Sıfat." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 373, DateTimeKind.Local).AddTicks(2812), "İure koşuyorlar.", "Nesciunt." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 373, DateTimeKind.Local).AddTicks(2836), "Göze layıkıyla.", "Quasi." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 374, DateTimeKind.Local).AddTicks(7857), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5.302428795720690m, 660.64m, "Unbranded Frozen Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 21, 19, 50, 23, 374, DateTimeKind.Local).AddTicks(7991), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4.202519645203420m, 642.37m, "Unbranded Fresh Hat" });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");
        }
    }
}
