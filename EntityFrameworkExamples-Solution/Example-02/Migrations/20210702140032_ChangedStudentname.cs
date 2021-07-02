using Microsoft.EntityFrameworkCore.Migrations;

namespace Example_02.Migrations
{
    public partial class ChangedStudentname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "students",
                newName: "fullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "students",
                newName: "name");
        }
    }
}
