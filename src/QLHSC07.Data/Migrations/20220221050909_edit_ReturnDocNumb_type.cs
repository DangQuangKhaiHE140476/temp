using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class edit_ReturnDocNumb_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "return_doc_numb",
                schema: "qlhsc07",
                table: "records",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReturnDocNumb",
                schema: "qlhsc07",
                table: "flatline",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "9a1c082b-9c7e-43a7-9908-6e3acbc723aa");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "86e7a71a-01c3-489e-afc2-c3769d9f956f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "return_doc_numb",
                schema: "qlhsc07",
                table: "records",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ReturnDocNumb",
                schema: "qlhsc07",
                table: "flatline",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "5e73882f-a3fe-4757-a68e-43bd9971e1bb");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "0e98f426-09ee-4670-abcd-7cf22398d1d9");
        }
    }
}
