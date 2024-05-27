using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class add_receiveusername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_records_AspNetUsers_receive_user_Id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropIndex(
                name: "IX_records_receive_user_Id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropColumn(
                name: "receive_user_Id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.AddColumn<string>(
                name: "receive_user_name",
                schema: "qlhsc07",
                table: "records",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "79220659-5ac5-4ea2-9fbc-126b67168899");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "991f94ae-66da-42b2-86c8-8cc2ff57bf41");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "receive_user_name",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.AddColumn<string>(
                name: "receive_user_Id",
                schema: "qlhsc07",
                table: "records",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "78606365-ce4a-4bcf-9bf2-47474ce2f173");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "4009dfcf-78d6-4b05-9f32-0619078bbd71");

            migrationBuilder.CreateIndex(
                name: "IX_records_receive_user_Id",
                schema: "qlhsc07",
                table: "records",
                column: "receive_user_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_records_AspNetUsers_receive_user_Id",
                schema: "qlhsc07",
                table: "records",
                column: "receive_user_Id",
                principalSchema: "authentication",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
