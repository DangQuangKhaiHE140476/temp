using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class Add_UserLoginLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "order",
                schema: "sys",
                table: "screen",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserLoginLog",
                schema: "authentication",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    user_id = table.Column<string>(nullable: true),
                    api_name = table.Column<string>(nullable: true),
                    ip_address = table.Column<string>(nullable: true),
                    full_name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoginLog", x => x.id);
                    table.ForeignKey(
                        name: "FK_UserLoginLog_AspNetUsers_user_id",
                        column: x => x.user_id,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "a7d82497-4682-4e99-8048-3724015d2d56");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "20f25124-fe15-4109-8515-54ac6f02556f");

            migrationBuilder.CreateIndex(
                name: "IX_screen_parent_id",
                schema: "sys",
                table: "screen",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserLoginLog_user_id",
                schema: "authentication",
                table: "UserLoginLog",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_screen_screen_parent_id",
                schema: "sys",
                table: "screen",
                column: "parent_id",
                principalSchema: "sys",
                principalTable: "screen",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screen_screen_parent_id",
                schema: "sys",
                table: "screen");

            migrationBuilder.DropTable(
                name: "UserLoginLog",
                schema: "authentication");

            migrationBuilder.DropIndex(
                name: "IX_screen_parent_id",
                schema: "sys",
                table: "screen");

            migrationBuilder.DropColumn(
                name: "order",
                schema: "sys",
                table: "screen");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "399d0f8a-9cb5-4374-a78a-86a7349970e6");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "96405b20-bbfe-4c3a-a2bc-063564bb087b");
        }
    }
}
