using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskForLightpoint.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopsProducts",
                table: "ShopsProducts");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ShopsProducts_Id",
                table: "ShopsProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopsProducts",
                table: "ShopsProducts",
                columns: new[] { "ShopFK", "ProductFK" });

            migrationBuilder.CreateIndex(
                name: "IX_ShopsProducts_ProductFK",
                table: "ShopsProducts",
                column: "ProductFK");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopsProducts_Products_ProductFK",
                table: "ShopsProducts",
                column: "ProductFK",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopsProducts_Shops_ShopFK",
                table: "ShopsProducts",
                column: "ShopFK",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopsProducts_Products_ProductFK",
                table: "ShopsProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopsProducts_Shops_ShopFK",
                table: "ShopsProducts");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ShopsProducts_Id",
                table: "ShopsProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopsProducts",
                table: "ShopsProducts");

            migrationBuilder.DropIndex(
                name: "IX_ShopsProducts_ProductFK",
                table: "ShopsProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopsProducts",
                table: "ShopsProducts",
                column: "Id");
        }
    }
}
