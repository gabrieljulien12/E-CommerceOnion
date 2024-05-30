using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnionPersistance.Migrations
{
    /// <inheritdoc />
    public partial class update2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catagoryProductis");

            migrationBuilder.CreateTable(
                name: "productCatagories",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CatagoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCatagories", x => new { x.ProductId, x.CatagoryId });
                    table.ForeignKey(
                        name: "FK_productCatagories_Catagories_CatagoryId",
                        column: x => x.CatagoryId,
                        principalTable: "Catagories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productCatagories_Products_ProductId",
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
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 157, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 158, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 158, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Details",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 158, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 160, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 160, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 30, 17, 37, 9, 160, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.CreateIndex(
                name: "IX_productCatagories_CatagoryId",
                table: "productCatagories",
                column: "CatagoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productCatagories");

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
    }
}
