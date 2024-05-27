using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class remove_constructtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_construction_type_construction_type_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.DropForeignKey(
                name: "FK_project_project_status_project_status_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.DropIndex(
                name: "IX_project_construction_type_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.DropColumn(
                name: "construction_type_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.AlterColumn<long>(
                name: "project_status_id",
                schema: "qlhsc07",
                table: "project",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "2e4d9619-b2df-4b9e-9baf-a2b430ae52e7");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "0208fe82-39f1-4ca7-a1dd-cb98912ed652");

            migrationBuilder.AddForeignKey(
                name: "FK_project_project_status_project_status_id",
                schema: "qlhsc07",
                table: "project",
                column: "project_status_id",
                principalSchema: "qlhsc07",
                principalTable: "project_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_project_project_status_project_status_id",
                schema: "qlhsc07",
                table: "project");

            migrationBuilder.AlterColumn<long>(
                name: "project_status_id",
                schema: "qlhsc07",
                table: "project",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "construction_type_id",
                schema: "qlhsc07",
                table: "project",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.CreateIndex(
                name: "IX_project_construction_type_id",
                schema: "qlhsc07",
                table: "project",
                column: "construction_type_id");

            migrationBuilder.AddForeignKey(
                name: "FK_project_construction_type_construction_type_id",
                schema: "qlhsc07",
                table: "project",
                column: "construction_type_id",
                principalSchema: "qlhsc07",
                principalTable: "construction_type",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_project_project_status_project_status_id",
                schema: "qlhsc07",
                table: "project",
                column: "project_status_id",
                principalSchema: "qlhsc07",
                principalTable: "project_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
