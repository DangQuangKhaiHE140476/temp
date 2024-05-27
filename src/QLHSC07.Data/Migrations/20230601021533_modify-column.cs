using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class modifycolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngay_sinh",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<int>(
                name: "nam_thanh_lap",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "68491e69-8e48-4b9e-ba99-1ed3ebf1b216");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "0200b45c-b606-4162-9aab-57539cafa762");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7305), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7309), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7311), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7312) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7317), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7320), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7322), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7325), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7328), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7331), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7333), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7335), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7338), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7339) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7340), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7343), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7345), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7348), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7351), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7353), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7356), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7358), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7359) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7361), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7363), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7365), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7366) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7369), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7369) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7371), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7373), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7438), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7441), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7444), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7446), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7450), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7451) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7452), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7453) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7455), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7457), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7458) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7460), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7462), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7464), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7467), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7469), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7472), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7474), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7477), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7480), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7482), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7484), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7487), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7490), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7493), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7495), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7498), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7501), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7505), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7507), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7511), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7512) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7514), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7516), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7519), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7522), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7523) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7525), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7527), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7529), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7532), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7533) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7536), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7539), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7543), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7543) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7545), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7546) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7547), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7570), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7573), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7574) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7575), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7578), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7579) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7580), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7581) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7584), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7586), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7587) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7588), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7591), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7593), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7595), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7598), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7599) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7600), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7602), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7603) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7605), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7607), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7608) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7610), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7612), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7615), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7617), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7620), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7622), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7625), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7626) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7627), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7630), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7632), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7633) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7635), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7638), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7639) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7640), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7641) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7642), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7643) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7645), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7646) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7647), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7649), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7652), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7653) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7654), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7657), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7658) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7659), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7662), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7663) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7664), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7667), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7667) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7669), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7671), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7674), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7675) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7676), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7679), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7679) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7681), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7682) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7683), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7686), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7688), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7691), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7693), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7694) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7715), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7718), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7720), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7723), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7725), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7727), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7730), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7733), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7734) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7737), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7739), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7742), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7745), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7746) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7748), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7751), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7751) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7753), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7756), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7758), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7760), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7761) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7763), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7764) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7765), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7766) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7768), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7769) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7770), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7771) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7772), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7775), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7777), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7780), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7782), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7783) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7784), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7787), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7789), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7792), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7794), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7797), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7799), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7802), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7802) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7804), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7806), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7809), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7831), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7834), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7836), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7839), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7841), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7844), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7846), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7849), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7851), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7854) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7856), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7858), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7861), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7863), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7868), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7871), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7875), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7876) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7878), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7880), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7883), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7888), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7889) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7890), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7893), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7895), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7898), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7900), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7903), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7905), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7906) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7907), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7910), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7912), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7915), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7917), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7920), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7922), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7925), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7927), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7930), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7932), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7935), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7937), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7939), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7942), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7944), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7947), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7949), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7951), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7954), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7956), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7981), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7984), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7986), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7989), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7991), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7993), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7996), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7998), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8001), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8003), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8005), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8008), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8009) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8010), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8013), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8015), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8018), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8020), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8022), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8023) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8025), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8027), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8030), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8032), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8034), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8037), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8039), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8042), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8044), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8047), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8049), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8051), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8054), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8054) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8056), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8059), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8061), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8062) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8063), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8066), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8068), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8071), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8073), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8076), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8078), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8081), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8083), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8085), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8086) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8088), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8090), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8093), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8119), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8121), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8124), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8126), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8129), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8131), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8133), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8136), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8137) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8138), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8141), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8143), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8144) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8145), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8148), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8149) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8150), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8153), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 903, DateTimeKind.Local).AddTicks(9976), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7273), new DateTime(2023, 6, 1, 9, 15, 32, 904, DateTimeKind.Local).AddTicks(7291) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ngay_sinh",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "nam_thanh_lap",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

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
    }
}
