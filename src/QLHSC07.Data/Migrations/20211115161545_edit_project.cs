using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class edit_project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_records_project_project_id1",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropForeignKey(
                name: "FK_records_records_type_records_types_id1",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropIndex(
                name: "IX_records_project_id1",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropIndex(
                name: "IX_records_records_types_id1",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropColumn(
                name: "project_id1",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropColumn(
                name: "records_types_id1",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                schema: "qlhsc07",
                table: "records_type_file_type",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                schema: "qlhsc07",
                table: "records_type_file_type",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "id",
                schema: "qlhsc07",
                table: "records_type_file_type",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                schema: "qlhsc07",
                table: "records_type_file_type",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "qlhsc07",
                table: "records_type_file_type",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modified_date",
                schema: "qlhsc07",
                table: "records_type_file_type",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "created_by",
                schema: "qlhsc07",
                table: "records_file",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "created_date",
                schema: "qlhsc07",
                table: "records_file",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "is_delete",
                schema: "qlhsc07",
                table: "records_file",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "modified_by",
                schema: "qlhsc07",
                table: "records_file",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "modified_date",
                schema: "qlhsc07",
                table: "records_file",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "document_ans_type_id",
                schema: "qlhsc07",
                table: "records",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "document_ans_type",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_ans_type", x => x.id);
                });

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "d74938d2-6e85-4200-85c1-76760a45590c");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "c10fd5c0-e5c1-4c6e-a7e6-80d92ba68572");

            migrationBuilder.CreateIndex(
                name: "IX_records_document_ans_type_id",
                schema: "qlhsc07",
                table: "records",
                column: "document_ans_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_project_id",
                schema: "qlhsc07",
                table: "records",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_records_types_id",
                schema: "qlhsc07",
                table: "records",
                column: "records_types_id");

            migrationBuilder.AddForeignKey(
                name: "FK_records_document_ans_type_document_ans_type_id",
                schema: "qlhsc07",
                table: "records",
                column: "document_ans_type_id",
                principalSchema: "qlhsc07",
                principalTable: "document_ans_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_records_project_project_id",
                schema: "qlhsc07",
                table: "records",
                column: "project_id",
                principalSchema: "qlhsc07",
                principalTable: "project",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_records_records_type_records_types_id",
                schema: "qlhsc07",
                table: "records",
                column: "records_types_id",
                principalSchema: "qlhsc07",
                principalTable: "records_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_records_document_ans_type_document_ans_type_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropForeignKey(
                name: "FK_records_project_project_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropForeignKey(
                name: "FK_records_records_type_records_types_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropTable(
                name: "document_ans_type",
                schema: "qlhsc07");

            migrationBuilder.DropIndex(
                name: "IX_records_document_ans_type_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropIndex(
                name: "IX_records_project_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropIndex(
                name: "IX_records_records_types_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.DropColumn(
                name: "created_by",
                schema: "qlhsc07",
                table: "records_type_file_type");

            migrationBuilder.DropColumn(
                name: "created_date",
                schema: "qlhsc07",
                table: "records_type_file_type");

            migrationBuilder.DropColumn(
                name: "id",
                schema: "qlhsc07",
                table: "records_type_file_type");

            migrationBuilder.DropColumn(
                name: "is_delete",
                schema: "qlhsc07",
                table: "records_type_file_type");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "qlhsc07",
                table: "records_type_file_type");

            migrationBuilder.DropColumn(
                name: "modified_date",
                schema: "qlhsc07",
                table: "records_type_file_type");

            migrationBuilder.DropColumn(
                name: "created_by",
                schema: "qlhsc07",
                table: "records_file");

            migrationBuilder.DropColumn(
                name: "created_date",
                schema: "qlhsc07",
                table: "records_file");

            migrationBuilder.DropColumn(
                name: "is_delete",
                schema: "qlhsc07",
                table: "records_file");

            migrationBuilder.DropColumn(
                name: "modified_by",
                schema: "qlhsc07",
                table: "records_file");

            migrationBuilder.DropColumn(
                name: "modified_date",
                schema: "qlhsc07",
                table: "records_file");

            migrationBuilder.DropColumn(
                name: "document_ans_type_id",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.AddColumn<long>(
                name: "project_id1",
                schema: "qlhsc07",
                table: "records",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "records_types_id1",
                schema: "qlhsc07",
                table: "records",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "f2f71456-4103-4408-9646-a51083973a5b");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "583fbf89-709a-441c-b72f-f6d1ba11dc08");

            migrationBuilder.CreateIndex(
                name: "IX_records_project_id1",
                schema: "qlhsc07",
                table: "records",
                column: "project_id1");

            migrationBuilder.CreateIndex(
                name: "IX_records_records_types_id1",
                schema: "qlhsc07",
                table: "records",
                column: "records_types_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_records_project_project_id1",
                schema: "qlhsc07",
                table: "records",
                column: "project_id1",
                principalSchema: "qlhsc07",
                principalTable: "project",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_records_records_type_records_types_id1",
                schema: "qlhsc07",
                table: "records",
                column: "records_types_id1",
                principalSchema: "qlhsc07",
                principalTable: "records_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
