using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskForLightpoint.Migrations
{
    public partial class additionalrowinserted2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("6ad2c4e5-be99-410e-97ad-8df454251db4"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("7d0423f9-3d0e-4d83-9d4f-2ff485391081"));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("07ce772c-0e21-4ec4-b24a-d642a826e6d2"), "Test 1.1", "Test 1.0" },
                    { new Guid("69bc623b-1fa5-47ca-a160-4170fc3a935a"), "Test 2.1", "Test 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[,]
                {
                    { new Guid("4a03bd72-47b9-4996-822e-3fbea418c4a5"), "Test 1.1", "Test 1.0", "Test1.2" },
                    { new Guid("2b546b53-bb16-4279-9892-5ecdd7075597"), "Test 2.1", "Test 2.0", "Test2.2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("07ce772c-0e21-4ec4-b24a-d642a826e6d2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("69bc623b-1fa5-47ca-a160-4170fc3a935a"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("2b546b53-bb16-4279-9892-5ecdd7075597"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "Id",
                keyValue: new Guid("4a03bd72-47b9-4996-822e-3fbea418c4a5"));

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[] { new Guid("6ad2c4e5-be99-410e-97ad-8df454251db4"), "Test 1.1", "Test 1.0", "Test1.2" });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "Id", "Adress", "Name", "OpeningHours" },
                values: new object[] { new Guid("7d0423f9-3d0e-4d83-9d4f-2ff485391081"), "Test 2.1", "Test 2.0", "Test2.2" });
        }
    }
}
