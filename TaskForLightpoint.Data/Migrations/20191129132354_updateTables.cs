using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskForLightpoint.Migrations
{
    public partial class updateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("24ed4cdd-3d6c-4867-be86-a8bf312a2870"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6982555e-a286-49f7-9e3e-ea0977cbb2f5"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("04adbd48-de02-474a-9101-bef3c98e12ae"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("66795ba0-a2d4-48f6-814c-ff5284e26d56"));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("e01caf44-10dc-4236-8a79-51777d01edac"), "Sleek Spirit II E-210 gas grill", "Gas grill Spirit II E-210" },
                    { new Guid("b1e7f862-a608-4d35-b2bf-eeb1579a29a2"), "KAYPRO shampoo 1000ml", "Hair Shampoo With Macadamia Oil" },
                    { new Guid("8ad30a5a-a0cf-4153-92b6-9c07c18be330"), "Triol toy 31cm", "Toy for dogs with a squeaker (Raccoon)" }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { new Guid("147d3867-7cda-48b4-9140-c1495aa223fb"), "g. Minsk, Igumenskiy trakt, 30", "Gippo", "10-20" },
                    { new Guid("e39be475-c36a-4a13-bda7-afea9e676378"), "g. Minsk, ul. I.Goshkevicha, 3", "Evroopt", "8-22" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("8ad30a5a-a0cf-4153-92b6-9c07c18be330"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b1e7f862-a608-4d35-b2bf-eeb1579a29a2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e01caf44-10dc-4236-8a79-51777d01edac"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("147d3867-7cda-48b4-9140-c1495aa223fb"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("e39be475-c36a-4a13-bda7-afea9e676378"));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("6982555e-a286-49f7-9e3e-ea0977cbb2f5"), "Test 1.1", "Test 1.0" },
                    { new Guid("24ed4cdd-3d6c-4867-be86-a8bf312a2870"), "Test 2.1", "Test 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { new Guid("04adbd48-de02-474a-9101-bef3c98e12ae"), "Test 1.1", "Test 1.0", "Test1.2" },
                    { new Guid("66795ba0-a2d4-48f6-814c-ff5284e26d56"), "Test 2.1", "Test 2.0", "Test2.2" }
                });
        }
    }
}
