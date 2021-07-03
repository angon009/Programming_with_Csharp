using Microsoft.EntityFrameworkCore.Migrations;

namespace Example_03.Migrations
{
    public partial class AddBuyerProductRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
