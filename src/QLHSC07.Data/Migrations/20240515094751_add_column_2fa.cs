using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class add_column_2fa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_use_2fa",
                schema: "authentication",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "secret_key",
                schema: "authentication",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "0bb33f93-78cc-415d-b56d-675203ade68b");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "7cb5fff7-bc27-4802-bc93-d0c89de754af");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(477), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(480), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(481) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(482), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(490), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(493), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(547), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(548) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(550), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(551) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(554), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(557), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(558) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(560), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(561) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(563), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(566), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(574), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(576), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(579), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(583), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(586), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(588), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(592), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(592) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(594), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(597), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(603), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(606), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(607) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(608), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(609) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(611), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(612) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(614), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(615) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(616), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(618) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(619), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(622), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(625), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(626) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(628), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(629) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(632), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(633) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(635), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(636) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(638), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(640), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(644), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(649), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(652), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(655) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(657), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(659), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(662), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(665), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(667), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(670), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(671) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(672), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(673) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(675), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(677), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(679), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(680) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(709), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(712), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(713) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(716), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(718), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(725), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(727), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(735), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(736) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(738), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(739) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(741), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(743), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(744) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(750), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(755) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(757), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(759), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(760) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(762), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(765), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(768), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(771), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(772) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(773), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(776), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(778), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(781), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(784), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(784) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(786), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(788), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(791), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(794), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(794) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(796), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(797) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(798), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(801), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(804), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(807), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(809), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(814), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(817), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(819), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(822), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(823) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(825), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(827), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(828) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(830), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(832), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(864), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(866), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(869), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(872), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(874), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(877), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(880), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(885), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(888) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(893), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(894) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(899), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(901), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(904), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(907), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(909), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(910) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(912), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(915), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(919), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(921), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(926), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(927) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(929), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(932), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(933) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(936), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(942), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(944), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(948), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(951), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(952) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(953), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(956), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(957) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(961), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(966), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(968), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(971), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(972) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(974), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(975) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(977), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(978) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1008), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1014), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1016), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1017) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1019), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1020) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1022), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1026) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1027), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1028) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1030), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1031) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1033), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1034) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1035), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1036) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1038), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1040), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1043), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1043) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1045), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1048), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1049) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1051), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1056), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1058), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1064), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1069) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1071), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1074) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1076), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1080), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1083), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1085), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1086) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1088), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1088) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1090), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1091) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1093), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1093) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1096), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1101), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1105), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1106) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1108), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1113), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1118), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1120), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1122), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1123) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1130), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1131) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1132), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1135), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1137), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1141) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1142), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1174), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1177), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1184), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1189), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1192), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1195), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1198), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1200), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1203), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1206), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1208), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1212), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1213) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1215), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1217), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1219), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1222), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1223) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1225), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1228), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1232), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1235), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1237), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1240), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1240) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1242), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1244), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1248), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1249) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1261), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1263), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1267), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1269), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1271), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1272) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1277), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1279), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1280) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1282), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1283) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1287), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1293), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1294) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1295), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1296) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1298), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1300), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1301) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1302), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1305), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1308), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1310), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1311) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1315), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1316) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1318), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1319) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1350), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1351) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1353), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1355), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1360), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1364), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1365) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1366), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1367) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1369), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1370) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1372), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1374), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1377), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1378) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1382), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1385), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1386) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1388), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1389) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1391), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1392) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1393), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1394) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1396), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1399), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1404), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1410), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1411) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1413), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1414) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1418), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1472), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1479), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1480) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1482), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1484), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1487), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1494), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 644, DateTimeKind.Local).AddTicks(1820), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(447), new DateTime(2024, 5, 15, 16, 47, 50, 645, DateTimeKind.Local).AddTicks(463) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_use_2fa",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "secret_key",
                schema: "authentication",
                table: "AspNetUsers");

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
    }
}
