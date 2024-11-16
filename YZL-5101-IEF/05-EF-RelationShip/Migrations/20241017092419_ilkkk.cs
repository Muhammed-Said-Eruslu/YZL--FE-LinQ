using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _05_EF_RelationShip.Migrations
{
    /// <inheritdoc />
    public partial class ilkkk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catogeries_CatogeryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CatogeryId",
                table: "Products",
                newName: "CatogeryRefId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatogeryId",
                table: "Products",
                newName: "IX_Products_CatogeryRefId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "ProductDetails",
                newName: "ProductRefId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductRefId",
                table: "ProductDetails",
                column: "ProductRefId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catogeries_CatogeryRefId",
                table: "Products",
                column: "CatogeryRefId",
                principalTable: "Catogeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_Products_ProductRefId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Catogeries_CatogeryRefId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "CatogeryRefId",
                table: "Products",
                newName: "CatogeryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CatogeryRefId",
                table: "Products",
                newName: "IX_Products_CatogeryId");

            migrationBuilder.RenameColumn(
                name: "ProductRefId",
                table: "ProductDetails",
                newName: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_Products_ProductId",
                table: "ProductDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Catogeries_CatogeryId",
                table: "Products",
                column: "CatogeryId",
                principalTable: "Catogeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
