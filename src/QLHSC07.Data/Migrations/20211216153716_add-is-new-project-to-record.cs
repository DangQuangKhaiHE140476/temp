using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class addisnewprojecttorecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_new_project",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.AddColumn<bool>(
                name: "is_new_project",
                schema: "qlhsc07",
                table: "records",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_new_project",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.AddColumn<bool>(
                name: "is_new_project",
                schema: "qlhsc07",
                table: "project",
                type: "boolean",
                nullable: true);
        }
    }
}
