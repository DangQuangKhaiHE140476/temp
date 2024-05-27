using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class unsignlocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "unsign_name",
            //    schema: "qlhsc07",
            //    table: "pc07_local",
            //    maxLength: 50,
            //    nullable: true);

            //migrationBuilder.UpdateData(
            //    schema: "authentication",
            //    table: "AspNetRoles",
            //    keyColumn: "Id",
            //    keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
            //    column: "ConcurrencyStamp",
            //    value: "e1629b59-4099-43e5-b885-e1d4b4bdeaae");

            //migrationBuilder.UpdateData(
            //    schema: "authentication",
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
            //    column: "ConcurrencyStamp",
            //    value: "b5baf8ec-15ed-42e6-a5fa-4fc57ebd090f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "unsign_name",
                schema: "qlhsc07",
                table: "pc07_local");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "be47957e-4b4c-4339-84c4-5ed3caa435df");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "a5e5aa6e-f067-4762-8f73-d50fc842511b");
        }
    }
}
