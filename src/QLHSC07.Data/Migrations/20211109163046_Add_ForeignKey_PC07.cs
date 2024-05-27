using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class Add_ForeignKey_PC07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_pc07_local_commune_id",
                schema: "qlhsc07",
                table: "pc07_local",
                column: "commune_id");

            migrationBuilder.CreateIndex(
                name: "IX_pc07_local_province_id",
                schema: "qlhsc07",
                table: "pc07_local",
                column: "province_id");

            migrationBuilder.AddForeignKey(
                name: "FK_pc07_local_commune_commune_id",
                schema: "qlhsc07",
                table: "pc07_local",
                column: "commune_id",
                principalSchema: "cms",
                principalTable: "commune",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pc07_local_province_province_id",
                schema: "qlhsc07",
                table: "pc07_local",
                column: "province_id",
                principalSchema: "cms",
                principalTable: "province",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pc07_local_commune_commune_id",
                schema: "qlhsc07",
                table: "pc07_local");

            migrationBuilder.DropForeignKey(
                name: "FK_pc07_local_province_province_id",
                schema: "qlhsc07",
                table: "pc07_local");

            migrationBuilder.DropIndex(
                name: "IX_pc07_local_commune_id",
                schema: "qlhsc07",
                table: "pc07_local");

            migrationBuilder.DropIndex(
                name: "IX_pc07_local_province_id",
                schema: "qlhsc07",
                table: "pc07_local");

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
        }
    }
}
