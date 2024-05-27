using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class delete_communeid_project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_commune_commune_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.DropIndex(
                name: "IX_project_commune_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.DropColumn(
                name: "commune_id",
                schema: "qlhsc07",
                table: "project");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "commune_id",
                schema: "qlhsc07",
                table: "project",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_project_commune_id",
                schema: "qlhsc07",
                table: "project",
                column: "commune_id");

            migrationBuilder.AddForeignKey(
                name: "FK_project_commune_commune_id",
                schema: "qlhsc07",
                table: "project",
                column: "commune_id",
                principalSchema: "cms",
                principalTable: "commune",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
