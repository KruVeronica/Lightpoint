using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskForLightpoint.Migrations
{
    public partial class additionalrowinserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[] { new Guid("6ad2c4e5-be99-410e-97ad-8df454251db4"), "Test 1.1", "Test 1.0", "Test1.2" });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[] { new Guid("7d0423f9-3d0e-4d83-9d4f-2ff485391081"), "Test 2.1", "Test 2.0", "Test2.2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("6ad2c4e5-be99-410e-97ad-8df454251db4"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("7d0423f9-3d0e-4d83-9d4f-2ff485391081"));
        }
    }
}
