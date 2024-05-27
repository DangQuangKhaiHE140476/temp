using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class addPC07Managetoflatlineunisigntopc07local : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "unsign_name",
            //    schema: "qlhsc07",
            //    table: "pc07_local",
            //    maxLength: 50,
            //    nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "PC07ManageId",
                schema: "qlhsc07",
                table: "flatline",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unsign_name",
                schema: "qlhsc07",
                table: "pc07_local");

            migrationBuilder.DropColumn(
                name: "PC07ManageId",
                schema: "qlhsc07",
                table: "flatline");
        }
    }
}
