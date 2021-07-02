using Microsoft.EntityFrameworkCore.Migrations;

namespace Example_01.Migrations
{
    public partial class ChangedTeachername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "teachers",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "students",
                newName: "fullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "teachers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "students",
                newName: "name");
        }
    }
}
