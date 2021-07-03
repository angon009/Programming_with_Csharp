using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Example_03.Migrations
{
    public partial class ChangeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buyers_products_Productid",
                table: "buyers");

            migrationBuilder.DropIndex(
                name: "IX_buyers_Productid",
                table: "buyers");

            migrationBuilder.DropColumn(
                name: "Productid",
                table: "buyers");

            migrationBuilder.CreateTable(
                name: "BuyerProduct",
                columns: table => new
                {
                    productId = table.Column<int>(type: "int", nullable: false),
                    buyerId = table.Column<int>(type: "int", nullable: false),
                    purchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyerProduct", x => new { x.productId, x.buyerId });
                    table.ForeignKey(
                        name: "FK_BuyerProduct_buyers_buyerId",
                        column: x => x.buyerId,
                        principalTable: "buyers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyerProduct_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rating = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.id);
                    table.ForeignKey(
                        name: "FK_Features_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyerProduct_buyerId",
                table: "BuyerProduct",
                column: "buyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_ProductId",
                table: "Features",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyerProduct");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.AddColumn<int>(
                name: "Productid",
                table: "buyers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_buyers_Productid",
                table: "buyers",
                column: "Productid");

            migrationBuilder.AddForeignKey(
                name: "FK_buyers_products_Productid",
                table: "buyers",
                column: "Productid",
                principalTable: "products",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
