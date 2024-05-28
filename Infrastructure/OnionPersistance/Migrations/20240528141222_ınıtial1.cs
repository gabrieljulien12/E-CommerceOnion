using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnionPersistance.Migrations
{
    /// <inheritdoc />
    public partial class ınıtial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tittle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatagoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Catagories_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatagoryProduct",
                columns: table => new
                {
                    CatagoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatagoryProduct", x => new { x.CatagoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CatagoryProduct_Catagories_CatagoriesId",
                        column: x => x.CatagoriesId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatagoryProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2814), false, "Asus" },
                    { 2, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2824), false, "Apple" },
                    { 3, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2832), false, "Acer" }
                });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8634), false, "Elektronik", 0, 1 },
                    { 2, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8642), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8649), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8656), false, "Kazak", 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CatagoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2747), "RTX4090", false, "EkranKartı" },
                    { 2, 3, new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2757), "DDR5", true, "Ram" },
                    { 3, 4, new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2764), "Yün", false, "Hammadde" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Desciription", "Discount", "IsDeleted", "Price", "Tittle" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6955), "blablabla", 15m, false, 15000m, "Asusz9" },
                    { 2, 2, new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6966), "blablabla", 15m, false, 15000m, "macbook" },
                    { 3, 3, new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6975), "blablabla", 15m, false, 15000m, "aspire" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatagoryProduct_ProductsId",
                table: "CatagoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_CatagoryId",
                table: "Details",
                column: "CatagoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatagoryProduct");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
