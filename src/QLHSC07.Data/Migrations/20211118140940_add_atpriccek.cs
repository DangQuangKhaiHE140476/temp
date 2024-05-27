using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class add_atpriccek : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_pc07_local_pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "file_attach_ids",
                schema: "qlhsc07",
                table: "message");

            migrationBuilder.DropColumn(
                name: "pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "date_predict_check",
                schema: "qlhsc07",
                table: "records",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "message_has_file",
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
                    attachment_id = table.Column<long>(nullable: false),
                    message_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message_has_file", x => x.id);
                    table.ForeignKey(
                        name: "FK_message_has_file_document_upload_attachment_id",
                        column: x => x.attachment_id,
                        principalSchema: "cms",
                        principalTable: "document_upload",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_message_has_file_message_message_id",
                        column: x => x.message_id,
                        principalSchema: "qlhsc07",
                        principalTable: "message",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_AspNetUsers_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id");

            migrationBuilder.CreateIndex(
                name: "IX_message_has_file_attachment_id",
                schema: "qlhsc07",
                table: "message_has_file",
                column: "attachment_id");

            migrationBuilder.CreateIndex(
                name: "IX_message_has_file_message_id",
                schema: "qlhsc07",
                table: "message_has_file",
                column: "message_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_pc07_local_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id",
                principalSchema: "qlhsc07",
                principalTable: "pc07_local",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_pc07_local_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "message_has_file",
                schema: "qlhsc07");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "date_predict_check",
                schema: "qlhsc07",
                table: "records");

            migrationBuilder.AddColumn<ICollection<long>>(
                name: "file_attach_ids",
                schema: "qlhsc07",
                table: "message",
                type: "jsonb",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers",
                type: "bigint",
                nullable: true);

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
                name: "IX_AspNetUsers_pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_pc07_local_pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id1",
                principalSchema: "qlhsc07",
                principalTable: "pc07_local",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
