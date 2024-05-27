using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class addcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "nam_thanh_lap",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ngay_sinh",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ten_to_chuc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "58a1053f-eff8-4305-a332-818e6d47ef59");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "71369102-ee30-4a4b-9a62-47335b62bbbc");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4428), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4429) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4431), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4431) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4433), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4439), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4442), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4443) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4444), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4447), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4450), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4452), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4455), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4458), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4460), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4461) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4463), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4463) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4465), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4466) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4467), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4471), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4473), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4475), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4478), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4480), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4482), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4483) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4485), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4486) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4487), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4490), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4492), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4493) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4495), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4497), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4498) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4500), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4502), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4503) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4505), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4507), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4510), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4513), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4515), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4517), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4562), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4565), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4567), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4570), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4573), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4575), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4578), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4578) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4580), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4582), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4585), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4587), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4589), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4592), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4594), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4596), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4599), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4601), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4604), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4604) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4606), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4609), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4612), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4614), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4617), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4621), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4624), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4626), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4628), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4632), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4633) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4634), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4637), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4641), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4644), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4649), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4651), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4653), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4655), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4658), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4660), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4663), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4665), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4667), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4710), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4711) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4713), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4714) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4715), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4716) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4718), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4720), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4721) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4722), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4724) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4725), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4726) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4728), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4728) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4730), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4731) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4732), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4733) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4734), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4737), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4739), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4741), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4744), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4746), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4748), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4751), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4753), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4755), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4758), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4760), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4762), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4765), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4767), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4769), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4772), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4774), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4776), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4778), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4781), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4783), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4785), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4788), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4790), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4792), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4795), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4797), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4798) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4800), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4801) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4802), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4805), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4807), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4809), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4812), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4815) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4817), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4819), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4822), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4847), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4849), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4852), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4858), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4861), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4863), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4866), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4868), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4871), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4873), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4875), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4877), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4880), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4885), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4887), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4888) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4890) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4892), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4894), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4896), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4897) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4899), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4901), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4906), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4908), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4911), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4911) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4913), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4915), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4918), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4920), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4922), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4925), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4930), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4932), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4934), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4942), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4949) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4973), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4974) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4975), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4978), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4980), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4982), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4985), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4990), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4992), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4993) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4997), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4999), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5002) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5004), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5006), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5007) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5016), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5018), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5021), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5023), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5025), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5030), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5035), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5039), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5042), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5043) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5044), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5047), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5053), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5054) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5056), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5063), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5066), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5082), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5089), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5111), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5113), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5114) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5120), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5121) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5123), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5125), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5132), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5148) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5150), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5152), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5154), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5157), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5159), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5161), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5164), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5166), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5168), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5171), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5173), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5174) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5175), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5177), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5180), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5182), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5185) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5189), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5192), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5216), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5218), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5220), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5227), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5232), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5234), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5239), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5242), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5244), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5249), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 237, DateTimeKind.Local).AddTicks(6934), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4035) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4398), new DateTime(2023, 5, 31, 16, 51, 16, 238, DateTimeKind.Local).AddTicks(4414) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nam_thanh_lap",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.DropColumn(
                name: "ngay_sinh",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.DropColumn(
                name: "ten_to_chuc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "c3c77f76-0322-4cab-b8d1-8b191a7aa7f0");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "a0e9976e-169a-403a-b92a-81a4dea96d56");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1255), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1258), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1261), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1266), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1269), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1271), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1275), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1276) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1278), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1279) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1281), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1283), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1284) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1286), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1288), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1290), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1293), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1295), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1299), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1300) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1301), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1302) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1304), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1304) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1306), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1308), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1311), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1313), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1315), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1318), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1320), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1321) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1323), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1368), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1369) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1371), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1373), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1376), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1378), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1382), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1384), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1385) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1386), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1389), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1391), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1394), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1396), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1398), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1401), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1403), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1404) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1405), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1408), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1410), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1413), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1415), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1417), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1420), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1422), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1424), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1427), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1429), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1431), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1432) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1434), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1436), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1438), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1441), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1443), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1446), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1446) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1448), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1449) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1450), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1453), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1453) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1455), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1458), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1461), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1463), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1465), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1491), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1494), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1496), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1499), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1501), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1504), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1504) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1506), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1507) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1509), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1510) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1512), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1514), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1517), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1519), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1521), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1524), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1526), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1529), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1531), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1534), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1536), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1538), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1541), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1544), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1546), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1548), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1551), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1553), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1556), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1558), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1561), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1563), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1565), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1568), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1570), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1572), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1575), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1577), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1579), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1582), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1584), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1586), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1589), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1591), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1593), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1596), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1598), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1600), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1602), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1605), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1607), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1610), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1612), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1640), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1643), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1645), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1648), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1652), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1657), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1659), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1663), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1665), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1666) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1668), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1671), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1676), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1678), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1681), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1683), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1686), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1688), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1692), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1694), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1697), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1699), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1701), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1704), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1706), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1708), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1711), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1713), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1715), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1718), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1720), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1722), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1724), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1727), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1729), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1777), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1780), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1782), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1785), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1787), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1789), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1791), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1794), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1796), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1799), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1801), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1803), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1806), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1808), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1810), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1812), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1815), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1815) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1817), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1818) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1819), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1822), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1824), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1826), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1829), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1831), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1833), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1836), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1838), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1840), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1841) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1842), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1845), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1847), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1849), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1851), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1852) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1854) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1857) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1858), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1861), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1863), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1866), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1868), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1870), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1872), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1875), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1877), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1880), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1882), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1884), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1887), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1889), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1891), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1894), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1920), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1922), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1925), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1927), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1928) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1929), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1932), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1934), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1936), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1939), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1941), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1944), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1946), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1948), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1951), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1953), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1957), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1965), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1967), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1969), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1971), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1974), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1976), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1978), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1981), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1985), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1988), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1990), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1992), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1995), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1996) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1997), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1999), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2002), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2004), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2007), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2008) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2009), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2011), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2014), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2016), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2021), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2023), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2025), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2028), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2030), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2061), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2063), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2068), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2070), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2073), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2075), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2077), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2082), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2086), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2089), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2091), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2093), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 298, DateTimeKind.Local).AddTicks(4132), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(852) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1222), new DateTime(2023, 5, 16, 11, 16, 8, 299, DateTimeKind.Local).AddTicks(1240) });
        }
    }
}
