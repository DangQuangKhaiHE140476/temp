using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class add_field_kyhieugiayto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ky_hieu_giay_to",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pham_vi_hieu_luc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "43555504-a361-4964-bc25-6801e9b3d9c9");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "0dba1546-67a7-4cca-9a2f-114c058a037c");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ky_hieu_giay_to",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.DropColumn(
                name: "pham_vi_hieu_luc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "dd9d9e8c-5879-42b1-b075-94be5b75dc21");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "9fce0b6c-da29-4092-aa74-7b8a29ca74ca");
        }
    }
}
