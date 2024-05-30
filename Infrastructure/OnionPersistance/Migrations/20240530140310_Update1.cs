using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionPersistance.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "CatagoryProduct");

            migrationBuilder.CreateTable(
                name: "catagoryProductis",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CatagoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catagoryProductis", x => new { x.ProductId, x.CatagoryId });
                    table.ForeignKey(
                        name: "FK_catagoryProductis_Catagories_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_catagoryProductis_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 984, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 985, DateTimeKind.Local).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 985, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 985, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 987, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 987, DateTimeKind.Local).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 3, 8, 987, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.CreateIndex(
                name: "IX_catagoryProductis_CatagoryId",
                table: "catagoryProductis",
                column: "CatagoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "catagoryProductis");

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

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 501, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 28, 17, 12, 14, 502, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.CreateIndex(
                name: "IX_CatagoryProduct_ProductsId",
                table: "CatagoryProduct",
                column: "ProductsId");
        }
    }
}
