using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbForWorkPc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(2057), "Toys, Electronics & Health" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(2073), "Grocery & Industrial" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(2083), "Kids & Outdoors" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDated",
                value: new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDated",
                value: new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDated",
                value: new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDated",
                value: new DateTime(2024, 2, 2, 12, 32, 34, 562, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 563, DateTimeKind.Local).AddTicks(5619), "Öyle açılmadan.", "Gülüyorum." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 563, DateTimeKind.Local).AddTicks(5714), "Kalemi consequuntur.", "Vitae." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 563, DateTimeKind.Local).AddTicks(5735), "Odit masaya.", "Non." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 565, DateTimeKind.Local).AddTicks(3088), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5.846572336787940m, 480.46m, "Sleek Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 2, 2, 12, 32, 34, 565, DateTimeKind.Local).AddTicks(3190), 3.675819077242830m, 309.23m, "Rustic Rubber Salad" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(1799), "Games" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(1862), "Automotive & Kids" });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Name" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(1869), "Movies" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDated",
                value: new DateTime(2024, 1, 29, 23, 4, 43, 344, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 346, DateTimeKind.Local).AddTicks(4344), "Duyulmamış sinema.", "Uzattı." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 346, DateTimeKind.Local).AddTicks(4507), "Quia lakin.", "Düşünüyor." });

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDated", "Description", "Title" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 346, DateTimeKind.Local).AddTicks(4528), "Sinema uzattı.", "Consequatur." });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDated", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 348, DateTimeKind.Local).AddTicks(6197), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8.714875744273670m, 640.12m, "Ergonomic Fresh Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDated", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 4, 43, 348, DateTimeKind.Local).AddTicks(6333), 7.13884552443680m, 844.38m, "Rustic Fresh Soap" });
        }
    }
}
