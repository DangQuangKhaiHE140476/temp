using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class update_table_record_result : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ten_chu_giay_to",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "ma_tthc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ma_ho_so",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<long>(
                name: "parent_id",
                schema: "qlhsc07",
                table: "field",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "349954e1-0289-40a6-9730-7bbc1a086a55");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "c0be219a-c3ca-4def-b659-e594d01dfb5f");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "parent_id",
                schema: "qlhsc07",
                table: "field");

            migrationBuilder.AlterColumn<string>(
                name: "ten_chu_giay_to",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ma_tthc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ma_ho_so",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                type: "character varying(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "49ce2e45-ce93-4e8d-9f38-a8d74fd5dba9");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "b75a5f27-e6f8-400d-bfdd-3f7ac15f04ba");
        }
    }
}
