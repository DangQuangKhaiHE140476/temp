using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class add_module : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_pc07_local_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ranks_rank_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_regency_regency_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "regency_id",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "RegencyId");

            migrationBuilder.RenameColumn(
                name: "rank_id",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "RankId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_regency_id",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_RegencyId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_rank_id",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_RankId");

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    TotalMoney = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    ProvinceIds = table.Column<int[]>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsConfirm = table.Column<bool>(nullable: false),
                    ClientType = table.Column<int[]>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    PromotionConditions = table.Column<int>(nullable: false),
                    Promotion = table.Column<int>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Info = table.Column<string>(nullable: true),
                    IsShow = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ClientNotes",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    ClientId = table.Column<long>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientNotes", x => x.id);
                    table.ForeignKey(
                        name: "FK_ClientNotes_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClientNotes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DepositHistorys",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    ClientId = table.Column<long>(nullable: false),
                    DepositAmount = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepositHistorys", x => x.id);
                    table.ForeignKey(
                        name: "FK_DepositHistorys_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepositHistorys_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Month = table.Column<long>(nullable: false),
                    DiscountType = table.Column<int>(nullable: false),
                    Discount = table.Column<double>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    PlanId = table.Column<long>(nullable: false),
                    ClientId = table.Column<long>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_Orders_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
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
                value: "8046dae4-6fa3-4d87-846b-cb2fc4f88603");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "02dc30e8-24ca-4833-a5df-430acca42320");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9200), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9203), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9206), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9214), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9218), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9224), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9225) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9228), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9231), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9234), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9237), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9238) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9240), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9241) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9243), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9246), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9248), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9253), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9257) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9259), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9261), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9264), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9266) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9267), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9270), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9273), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9276), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9279), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9282), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9285), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9288), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9296), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9300), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9303), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9306), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9309), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9312), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9394), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9397), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9404) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9405), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9406) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9408), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9409) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9411), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9412) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9414), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9417), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9419), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9420) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9422), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9423) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9425), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9426) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9428) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9430), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9431) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9433), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9434) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9436), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9438), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9441), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9442) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9444), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9447), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9449), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9450) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9452), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9455), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9458), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9462) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9463), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9466), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9467) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9471), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9473), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9474) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9476), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9477) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9479), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9481), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9484), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9485) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9487), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9490), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9491) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9492), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9493) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9495), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9498), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9499) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9501), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9501) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9503), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9506), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9509), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9511), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9514), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9552), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9553) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9555), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9556) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9558), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9559) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9561), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9562) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9603), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9606), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9607) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9609), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9612), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9613) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9614), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9617), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9622), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9625), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9628), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9629) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9631), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9633), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9634) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9636), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9637) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9639), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9639) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9641), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9642) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9644), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9645) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9647), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9648) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9650), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9652), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9653) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9656), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9656) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9658), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9659) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9661), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9662) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9664), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9665) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9666), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9667) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9669), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9672), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9673) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9675), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9677), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9678) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9680), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9683), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9685), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9688), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9693), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9697), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9700), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9702), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9703) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9705), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9708), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9709) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9711), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9712) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9714), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9715) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9716), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9717) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9719), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9765), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9767) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9769), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9769) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9771), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9772) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9775) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9777), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9779), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9782), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9784) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9788), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9789) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9791), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9792) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9794), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9797), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9798) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9800), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9803), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9804) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9806), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9809), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9812), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9815), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9816) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9817), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9818) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9820), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9821) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9823), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9824) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9825), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9829), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9831), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9834), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9835) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9837), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9838) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9839), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9842), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9843) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9845), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9847), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9850), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9851) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9853), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9853) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9855), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9858), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9861), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9862) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9863), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9867), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9870), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9871) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9872), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9875), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9876) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9878), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9879) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9880), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9918), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9919) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9921), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9924), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9925) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9927), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9928) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9931) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9933), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9934) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9936), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9937) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9939), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9941), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9943) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9944), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9945) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9947), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9948) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9950), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9951) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9953), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9954) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9956), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9959), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9962), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9963) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9965), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9968), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9969) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9971), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9972) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9974), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9975) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9979), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9982), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9983) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9985), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9988), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9989) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9991), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9992) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9995), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9996) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9998), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(2), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(3) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(5), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(6) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(9), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(12), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(15), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(17), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(20), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(23), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(24) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(26), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(29), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(32), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(33) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(35), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(38), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(41), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(42) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(46), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(49), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(52), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(53) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(55), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(58), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(61), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(67), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(107), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(108) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(110), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(113), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(114) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(116), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(117) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(118), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(121), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(124), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(125) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(127), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(128) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(130), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(131) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(133), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(134) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(136), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(137) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(139), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(142), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(148), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(151), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(154), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(155) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(157), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(160), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(163), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(165), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(168), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(171), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(174), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(177), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(183), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(186), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(189), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(194), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(197), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(200), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(203), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(243), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(246), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(249), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(252), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(255), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(256) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(258), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(259) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(261), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(264), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(270), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(273), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(278), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(281), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(284), new DateTime(2024, 5, 20, 0, 1, 3, 79, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(1057), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(8768) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 5, 20, 0, 1, 3, 78, DateTimeKind.Local).AddTicks(9182) });

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_ClientId",
                table: "ClientNotes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ClientNotes_UserId",
                table: "ClientNotes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserId",
                table: "Clients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositHistorys_ClientId",
                table: "DepositHistorys",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_DepositHistorys_UserId",
                table: "DepositHistorys",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PlanId",
                table: "Orders",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ranks_RankId",
                schema: "authentication",
                table: "AspNetUsers",
                column: "RankId",
                principalSchema: "qlhsc07",
                principalTable: "ranks",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_regency_RegencyId",
                schema: "authentication",
                table: "AspNetUsers",
                column: "RegencyId",
                principalSchema: "qlhsc07",
                principalTable: "regency",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ranks_RankId",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_regency_RegencyId",
                schema: "authentication",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ClientNotes");

            migrationBuilder.DropTable(
                name: "DepositHistorys");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.RenameColumn(
                name: "RegencyId",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "regency_id");

            migrationBuilder.RenameColumn(
                name: "RankId",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "rank_id");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_RegencyId",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_regency_id");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_RankId",
                schema: "authentication",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_rank_id");

            migrationBuilder.AddColumn<long>(
                name: "pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_pc07_local_pc07_local_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id",
                principalSchema: "qlhsc07",
                principalTable: "pc07_local",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ranks_rank_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "rank_id",
                principalSchema: "qlhsc07",
                principalTable: "ranks",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_regency_regency_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "regency_id",
                principalSchema: "qlhsc07",
                principalTable: "regency",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
