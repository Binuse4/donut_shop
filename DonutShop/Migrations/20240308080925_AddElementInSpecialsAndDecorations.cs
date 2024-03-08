using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DonutShop.Migrations
{
    /// <inheritdoc />
    public partial class AddElementInSpecialsAndDecorations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonutDecoration_Decorations_DecorationId",
                table: "DonutDecoration");

            migrationBuilder.DropForeignKey(
                name: "FK_DonutDecoration_Donuts_DonutId",
                table: "DonutDecoration");

            migrationBuilder.DropForeignKey(
                name: "FK_Donuts_Orders_OrderId",
                table: "Donuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Donuts_Specials_SpecialId",
                table: "Donuts");

            migrationBuilder.DropIndex(
                name: "IX_Donuts_OrderId",
                table: "Donuts");

            migrationBuilder.DropIndex(
                name: "IX_Donuts_SpecialId",
                table: "Donuts");

            migrationBuilder.DropIndex(
                name: "IX_DonutDecoration_DecorationId",
                table: "DonutDecoration");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Specials",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "DeliveryAddressId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrderId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Donuts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId1",
                table: "Donuts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SpecialId1",
                table: "Donuts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DecorationId1",
                table: "DonutDecoration",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DonutId1",
                table: "DonutDecoration",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Decorations",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Decorations",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2fb56f52-d68c-4205-935b-b0c0fbfd3608"), "Oreo", 1.99m },
                    { new Guid("67fffa43-5707-4731-82b0-5da038317510"), "Milka", 1.99m },
                    { new Guid("8007c9e3-0f4a-4998-bb05-a77c7e05ef14"), "Milk chocolate Sauce", 1.99m },
                    { new Guid("8f5d524a-5b11-4f52-a1ab-9d426dd7d988"), "Nutella", 1.99m },
                    { new Guid("953acd5b-a516-47da-9054-b1b30c6b6716"), "Dark chocolate Sauce", 1.99m },
                    { new Guid("a1e03fa1-0ad8-4639-8d04-593de8e30f00"), "Speculoos", 1.99m },
                    { new Guid("a6507d7a-7983-4791-b8ce-da7a4dca7e0a"), "Kit Kat", 1.99m },
                    { new Guid("c888bb18-13e7-4b97-8536-760c1a3851a5"), "M&M's", 1.99m },
                    { new Guid("dfe11920-410a-4597-be5c-a75f1c0de696"), "White chocolate Sauce", 1.99m },
                    { new Guid("e670bbf0-0d8e-4a7d-b37f-14b2fccd9ab9"), "Kinder Country", 1.99m },
                    { new Guid("f11ec3e8-6b95-4cec-9434-0b265be8113f"), "Kinder Bueno", 1.99m },
                    { new Guid("f369abc4-ee2a-418b-8d6e-015f7d32d875"), "Cookie", 1.99m }
                });

            migrationBuilder.InsertData(
                table: "Specials",
                columns: new[] { "Id", "BasePrice", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { new Guid("0e9b19bd-9c0a-4002-b02b-16c1eb1ad37d"), 9.99m, "Milk chocolate topping, Crushed Kit Kat, Kit Kat ", "img/donuts/", "Kit Kat" },
                    { new Guid("12dfbb90-cf1c-4d2a-922c-7350ffca0e6f"), 11.99m, "Speculoos cream topping, Speculoos Flakes , Speculoos", "img/donuts/", "Speculoos" },
                    { new Guid("2b1717c1-a66b-44d3-a15f-0399e09e9baa"), 11.00m, "White chocolate topping, Caramel rice souffle, Kinder Country", "img/donuts/", "Country" },
                    { new Guid("4562c792-4402-4fe8-bcdb-d91dff493efe"), 9.99m, "Traditional Donut , Powdered sugar ", "img/donuts/", "Natural" },
                    { new Guid("4b25ff4a-7a9b-46a3-8c73-79dd7ad2a028"), 12.75m, "Nutella topping, Nutella cookie", "img/donuts/", "Nutella" },
                    { new Guid("63e4f9ad-451e-4b9c-b52f-8a294e83e5d5"), 9.99m, "Traditional Donut , Caramelized sugar ", "img/donuts/", "Glazed" },
                    { new Guid("9dbd2105-57f1-4e47-be43-14f069ec4185"), 11.50m, "Bueno cream topping, Chocolate coulis, Kinder Bueno", "img/donuts/", "Kinder Bueno" },
                    { new Guid("a20dc365-2946-49c8-8434-76b9fad33a0f"), 9.99m, "Vanilla Napage, Vanilla Oreo bits , Oreo", "img/donuts/", "Oreo" },
                    { new Guid("a6e14ea4-f057-4919-be7e-0090d4a7f26f"), 11.00m, "Chocolate topping, cookie", "img/donuts/", "Chocolat" },
                    { new Guid("b9a22a3b-6c9b-45c2-a778-5fadf7821cf4"), 10.50m, "Milk chocolate topping, Crushed M&M's, Chocolate peanut M&M's", "img/donuts", "M&M's" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Donuts_OrderId1",
                table: "Donuts",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_Donuts_SpecialId1",
                table: "Donuts",
                column: "SpecialId1");

            migrationBuilder.CreateIndex(
                name: "IX_DonutDecoration_DecorationId1",
                table: "DonutDecoration",
                column: "DecorationId1");

            migrationBuilder.CreateIndex(
                name: "IX_DonutDecoration_DonutId1",
                table: "DonutDecoration",
                column: "DonutId1");

            migrationBuilder.AddForeignKey(
                name: "FK_DonutDecoration_Decorations_DecorationId1",
                table: "DonutDecoration",
                column: "DecorationId1",
                principalTable: "Decorations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonutDecoration_Donuts_DonutId1",
                table: "DonutDecoration",
                column: "DonutId1",
                principalTable: "Donuts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Donuts_Orders_OrderId1",
                table: "Donuts",
                column: "OrderId1",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Donuts_Specials_SpecialId1",
                table: "Donuts",
                column: "SpecialId1",
                principalTable: "Specials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DonutDecoration_Decorations_DecorationId1",
                table: "DonutDecoration");

            migrationBuilder.DropForeignKey(
                name: "FK_DonutDecoration_Donuts_DonutId1",
                table: "DonutDecoration");

            migrationBuilder.DropForeignKey(
                name: "FK_Donuts_Orders_OrderId1",
                table: "Donuts");

            migrationBuilder.DropForeignKey(
                name: "FK_Donuts_Specials_SpecialId1",
                table: "Donuts");

            migrationBuilder.DropIndex(
                name: "IX_Donuts_OrderId1",
                table: "Donuts");

            migrationBuilder.DropIndex(
                name: "IX_Donuts_SpecialId1",
                table: "Donuts");

            migrationBuilder.DropIndex(
                name: "IX_DonutDecoration_DecorationId1",
                table: "DonutDecoration");

            migrationBuilder.DropIndex(
                name: "IX_DonutDecoration_DonutId1",
                table: "DonutDecoration");

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("2fb56f52-d68c-4205-935b-b0c0fbfd3608"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("67fffa43-5707-4731-82b0-5da038317510"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("8007c9e3-0f4a-4998-bb05-a77c7e05ef14"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("8f5d524a-5b11-4f52-a1ab-9d426dd7d988"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("953acd5b-a516-47da-9054-b1b30c6b6716"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("a1e03fa1-0ad8-4639-8d04-593de8e30f00"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("a6507d7a-7983-4791-b8ce-da7a4dca7e0a"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("c888bb18-13e7-4b97-8536-760c1a3851a5"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("dfe11920-410a-4597-be5c-a75f1c0de696"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("e670bbf0-0d8e-4a7d-b37f-14b2fccd9ab9"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("f11ec3e8-6b95-4cec-9434-0b265be8113f"));

            migrationBuilder.DeleteData(
                table: "Decorations",
                keyColumn: "Id",
                keyValue: new Guid("f369abc4-ee2a-418b-8d6e-015f7d32d875"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("0e9b19bd-9c0a-4002-b02b-16c1eb1ad37d"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("12dfbb90-cf1c-4d2a-922c-7350ffca0e6f"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("2b1717c1-a66b-44d3-a15f-0399e09e9baa"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("4562c792-4402-4fe8-bcdb-d91dff493efe"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("4b25ff4a-7a9b-46a3-8c73-79dd7ad2a028"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("63e4f9ad-451e-4b9c-b52f-8a294e83e5d5"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("9dbd2105-57f1-4e47-be43-14f069ec4185"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("a20dc365-2946-49c8-8434-76b9fad33a0f"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("a6e14ea4-f057-4919-be7e-0090d4a7f26f"));

            migrationBuilder.DeleteData(
                table: "Specials",
                keyColumn: "Id",
                keyValue: new Guid("b9a22a3b-6c9b-45c2-a778-5fadf7821cf4"));

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "Donuts");

            migrationBuilder.DropColumn(
                name: "SpecialId1",
                table: "Donuts");

            migrationBuilder.DropColumn(
                name: "DecorationId1",
                table: "DonutDecoration");

            migrationBuilder.DropColumn(
                name: "DonutId1",
                table: "DonutDecoration");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Specials",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "DeliveryAddressId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Donuts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Decorations",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Donuts_OrderId",
                table: "Donuts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Donuts_SpecialId",
                table: "Donuts",
                column: "SpecialId");

            migrationBuilder.CreateIndex(
                name: "IX_DonutDecoration_DecorationId",
                table: "DonutDecoration",
                column: "DecorationId");

            migrationBuilder.AddForeignKey(
                name: "FK_DonutDecoration_Decorations_DecorationId",
                table: "DonutDecoration",
                column: "DecorationId",
                principalTable: "Decorations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DonutDecoration_Donuts_DonutId",
                table: "DonutDecoration",
                column: "DonutId",
                principalTable: "Donuts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donuts_Orders_OrderId",
                table: "Donuts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Donuts_Specials_SpecialId",
                table: "Donuts",
                column: "SpecialId",
                principalTable: "Specials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
