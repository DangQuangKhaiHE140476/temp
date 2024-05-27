using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class edit_records_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "maximum_processing_days",
                schema: "qlhsc07",
                table: "records_type");

            migrationBuilder.AddColumn<int>(
                name: "waiting_time",
                schema: "qlhsc07",
                table: "records_type",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "waiting_type",
                schema: "qlhsc07",
                table: "records_type",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                schema: "qlhsc07",
                table: "msg_receive",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                schema: "qlhsc07",
                table: "msg_receive",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                schema: "qlhsc07",
                table: "msg_receive",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "qlhsc07",
                table: "msg_receive",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modified_date",
                schema: "qlhsc07",
                table: "msg_receive",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "81b8fcab-da38-4450-ad2b-270429d59f7e");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "8a251794-bd26-428c-9dd4-ffdf2ee9e333");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "waiting_time",
                schema: "qlhsc07",
                table: "records_type");

            migrationBuilder.DropColumn(
                name: "waiting_type",
                schema: "qlhsc07",
                table: "records_type");

            migrationBuilder.DropColumn(
                name: "created_by",
                schema: "qlhsc07",
                table: "msg_receive");

            migrationBuilder.DropColumn(
                name: "created_date",
                schema: "qlhsc07",
                table: "msg_receive");

            migrationBuilder.DropColumn(
                name: "is_delete",
                schema: "qlhsc07",
                table: "msg_receive");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "qlhsc07",
                table: "msg_receive");

            migrationBuilder.DropColumn(
                name: "modified_date",
                schema: "qlhsc07",
                table: "msg_receive");

            migrationBuilder.AddColumn<DateTime>(
                name: "maximum_processing_days",
                schema: "qlhsc07",
                table: "records_type",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "0d530c6d-6aad-4661-a4f1-661661acafaa");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "d1a56262-94a5-4f9b-8add-27179911a0a5");
        }
    }
}
