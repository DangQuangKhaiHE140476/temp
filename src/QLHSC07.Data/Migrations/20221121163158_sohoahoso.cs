using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class sohoahoso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "so_hoa_thu_tuc_hanh_chinh",
                schema: "qlhsc07",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    records_id = table.Column<long>(nullable: true),
                    document_upload_id = table.Column<long>(nullable: true),
                    ma_giay_to = table.Column<string>(maxLength: 100, nullable: false),
                    ten_giay_to = table.Column<string>(maxLength: 5000, nullable: false),
                    ma_chu_giay_to = table.Column<string>(maxLength: 50, nullable: false),
                    ten_chu_giay_to = table.Column<string>(maxLength: 1000, nullable: false),
                    loai_doi_tuong = table.Column<int>(nullable: false),
                    ngay_so_hoa = table.Column<DateTime>(nullable: false),
                    thoi_han_hieu_luc = table.Column<DateTime>(nullable: false),
                    ma_co_quan = table.Column<string>(maxLength: 50, nullable: true),
                    ten_co_quan = table.Column<string>(maxLength: 5000, nullable: true),
                    thong_tin_khac = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_so_hoa_thu_tuc_hanh_chinh", x => x.id);
                    table.ForeignKey(
                        name: "FK_so_hoa_thu_tuc_hanh_chinh_document_upload_document_upload_id",
                        column: x => x.document_upload_id,
                        principalSchema: "cms",
                        principalTable: "document_upload",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_so_hoa_thu_tuc_hanh_chinh_records_records_id",
                        column: x => x.records_id,
                        principalSchema: "qlhsc07",
                        principalTable: "records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "741afa2c-b241-4055-b6b3-27886ac4304d");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "198c0f04-4961-4fd0-b894-61ebc3bda4d3");

            migrationBuilder.CreateIndex(
                name: "IX_so_hoa_thu_tuc_hanh_chinh_document_upload_id",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                column: "document_upload_id");

            migrationBuilder.CreateIndex(
                name: "IX_so_hoa_thu_tuc_hanh_chinh_records_id",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                column: "records_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "so_hoa_thu_tuc_hanh_chinh",
                schema: "qlhsc07");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "4b63f22e-1a49-4712-a34c-41c27e3e16fd");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "5b99bc6b-48d0-4c84-b48b-223136b68305");
        }
    }
}
