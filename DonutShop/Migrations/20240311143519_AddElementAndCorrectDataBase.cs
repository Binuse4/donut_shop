using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DonutShop.Migrations
{
    /// <inheritdoc />
    public partial class AddElementAndCorrectDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Line1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Region = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Decorations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Decorations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FixedQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Address_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    SpecialId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Donuts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donuts_Specials_SpecialId",
                        column: x => x.SpecialId,
                        principalTable: "Specials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonutDecoration",
                columns: table => new
                {
                    DecorationId = table.Column<int>(type: "int", nullable: false),
                    DonutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonutDecoration", x => new { x.DonutId, x.DecorationId });
                    table.ForeignKey(
                        name: "FK_DonutDecoration_Decorations_DecorationId",
                        column: x => x.DecorationId,
                        principalTable: "Decorations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonutDecoration_Donuts_DonutId",
                        column: x => x.DonutId,
                        principalTable: "Donuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Decorations",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Oreo", 1.99m },
                    { 2, "Milk chocolate Sauce", 1.99m },
                    { 3, "Dark chocolate Sauce", 1.99m },
                    { 4, "Cookie", 1.99m },
                    { 5, "Kit Kat", 1.99m },
                    { 6, "Kinder Bueno", 1.99m },
                    { 7, "Kinder Country", 1.99m },
                    { 8, "M&M's", 1.99m },
                    { 9, "Speculoos", 1.99m },
                    { 10, "Nutella", 1.99m },
                    { 11, "White chocolate Sauce", 1.99m },
                    { 12, "Milka", 1.99m }
                });

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "Id", "BasePrice", "Description", "FixedQuantity", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 11.99m, "Speculoos cream topping, Speculoos Flakes , Speculoos", null, "img/donuts/speculos.png", "Speculoos" },
                    { 2, 9.99m, "Vanilla Napage, Vanilla Oreo bits , Oreo", null, "img/donuts/oreo.png", "Oreo" },
                    { 3, 10.50m, "Milk chocolate topping, Crushed M&M's, Chocolate peanut M&M's", null, "img/donuts/mms.png", "M&M's" },
                    { 4, 12.75m, "Nutella topping, Nutella cookie", null, "img/donuts/nutella.png", "Nutella" },
                    { 5, 11.00m, "White chocolate topping, Caramel rice souffle, Kinder Country", null, "img/donuts/kinder_country.png", "Kinder Country" },
                    { 6, 11.50m, "Bueno cream topping, Chocolate coulis, Kinder Bueno", null, "img/donuts/bueno.png", "Kinder Bueno" },
                    { 7, 9.99m, "Milk chocolate topping, Crushed Kit Kat, Kit Kat ", null, "img/donuts/kitkat.png", "Kit Kat" },
                    { 8, 9.99m, "Traditional Donut , Powdered sugar ", null, "img/donuts/nature.png", "Natural" },
                    { 9, 9.99m, "Traditional Donut , Caramelized sugar ", null, "img/donuts/sugarGlazed.png", "Glazed" },
                    { 10, 11.00m, "Chocolate topping, cookie", null, "img/donuts/chocolat.png", "Chocolat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DonutDecoration_DecorationId",
                table: "DonutDecoration",
                column: "DecorationId");

            migrationBuilder.CreateIndex(
                name: "IX_Donuts_OrderId",
                table: "Donuts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Donuts_SpecialId",
                table: "Donuts",
                column: "SpecialId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAddressId",
                table: "Orders",
                column: "DeliveryAddressId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonutDecoration");

            migrationBuilder.DropTable(
                name: "Decorations");

            migrationBuilder.DropTable(
                name: "Donuts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Specials");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
