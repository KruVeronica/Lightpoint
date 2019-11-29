using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskForLightpoint.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shops",
                table: "Shops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ShopsProducts",
                newName: "ShopProduct");

            migrationBuilder.RenameTable(
                name: "Shops",
                newName: "Shop");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_ShopsProducts_ProductFK",
                table: "ShopProduct",
                newName: "IX_ShopProduct_ProductFK");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ShopProduct_Id",
                table: "ShopProduct",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopProduct",
                table: "ShopProduct",
                columns: new[] { "ShopFK", "ProductFK" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shop",
                table: "Shop",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProduct_Product_ProductFK",
                table: "ShopProduct",
                column: "ProductFK",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopProduct_Shop_ShopFK",
                table: "ShopProduct",
                column: "ShopFK",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopProduct_Product_ProductFK",
                table: "ShopProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopProduct_Shop_ShopFK",
                table: "ShopProduct");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_ShopProduct_Id",
                table: "ShopProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopProduct",
                table: "ShopProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shop",
                table: "Shop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ShopProduct",
                newName: "ShopsProducts");

            migrationBuilder.RenameTable(
                name: "Shop",
                newName: "Shops");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ShopProduct_ProductFK",
                table: "ShopsProducts",
                newName: "IX_ShopsProducts_ProductFK");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_ShopsProducts_Id",
                table: "ShopsProducts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopsProducts",
                table: "ShopsProducts",
                columns: new[] { "ShopFK", "ProductFK" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shops",
                table: "Shops",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

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
    }
}
