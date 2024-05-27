using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class edit_position_fields_flatline : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommuneName",
                schema: "qlhsc07",
                table: "flatline");

            migrationBuilder.DropColumn(
                name: "DistrictName",
                schema: "qlhsc07",
                table: "flatline");

            migrationBuilder.DropColumn(
                name: "ProvinceName",
                schema: "qlhsc07",
                table: "flatline");

            migrationBuilder.AddColumn<string>(
                name: "Positions",
                schema: "qlhsc07",
                table: "flatline",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Positions",
                schema: "qlhsc07",
                table: "flatline");

            migrationBuilder.AddColumn<string>(
                name: "CommuneName",
                schema: "qlhsc07",
                table: "flatline",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DistrictName",
                schema: "qlhsc07",
                table: "flatline",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceName",
                schema: "qlhsc07",
                table: "flatline",
                type: "text",
                nullable: true);
        }
    }
}
