using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QLHSC07.Data.Migrations
{
    public partial class modifyrecordresultprocessing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_so_hoa_thu_tuc_hanh_chinh_field_field_id",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.RenameColumn(
                name: "field_id",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                newName: "FieldId");

            migrationBuilder.RenameIndex(
                name: "IX_so_hoa_thu_tuc_hanh_chinh_field_id",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                newName: "IX_so_hoa_thu_tuc_hanh_chinh_FieldId");

            migrationBuilder.AlterColumn<string>(
                name: "trang_thai_ho_so",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "ma_linh_vuc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "82629699-f0cb-4ca5-9080-44e5af2712f7");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "dc05196a-ed30-4590-a53c-ad10822cde4d");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4803), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4804) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4806), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4808), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4814), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4816), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4818), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4821), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4824), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4827), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4829), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4831), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4834), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4836), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4838), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4841), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4844), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4846), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4848), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4851), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4853), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4855), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4857), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4860), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4863), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4865), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4867), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4870), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4872), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4874), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4876), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4879), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4882), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4884), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4885) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4886), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4887) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4889), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4889) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4891), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4893), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4895), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4898), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4900), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4903), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4904) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4905), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4907), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4935), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4935) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4937), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4939), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4942), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4943) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4944), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4945) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4946), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4949), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4951), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4952) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4953), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4954) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4956), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4956) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4958), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4959) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4961), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4962) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4963), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4965), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4966) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4968), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4968) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4970), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4971) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4972), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4973) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4974), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4975) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4976), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4977) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4979), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4984), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4986), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4988), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4991), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4993), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4995), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4998), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4998) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5000), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5001) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5002), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5003) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5005), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5007), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5009), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5011), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5014), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5016), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5018), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5020), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5023), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5025), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5026) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5027), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5029), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5032), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5033) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5036), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5039), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5071) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5072), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5075), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5079), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5081), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5084), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5086), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5089), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5093), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5096), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5098), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5100), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5102), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5103) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5105), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5106) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5107), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5108) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5109), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5114), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5116), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5119), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5121), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5123), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5128), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5131), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5133), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5135), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5138), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5140), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5142), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5144), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5145) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5147), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5149), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5151), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5153), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5183), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5185), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5187), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5191), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5194), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5196), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5198), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5200), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5203), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5205), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5207), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5209), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5212), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5213) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5214), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5216), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5219), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5221), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5223), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5225), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5228), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5230), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5233), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5235), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5237), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5240), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5242), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5244), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5246), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5249), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5251), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5253), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5255), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5258), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5260), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5261) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5262), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5264), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5267), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5269), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5271), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5272) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5274), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5275) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5276), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5278), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5281), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5283), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5284) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5285), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5288), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5291) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5292), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5295), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5295) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5297), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5322), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5323) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5325), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5327), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5329), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5332), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5333) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5334), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5335) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5336), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5339), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5341), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5343), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5345), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5348), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5351) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5353), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5355), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5357), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5359), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5362), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5364), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5366), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5369), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5369) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5371), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5372) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5373), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5375), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5376) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5378), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5380), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5382), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5385), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5387), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5390), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5392), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5393) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5394), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5395) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5397), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5399), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5401), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5403), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5406), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5408), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5410), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5411) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5413), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5415), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5416) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5417), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5418) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5420), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5421) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5422), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5423) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5425), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5426) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5427), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5428) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5430), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5432), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5433) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5434), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5435) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5436), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5439), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5484), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5485) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5486), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5487) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5488), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5489) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5491), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5492) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5493), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5494) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5496), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5498), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5499) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5500), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5501) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5503), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5503) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5505), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5507), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5508) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5509), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5512), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5512) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5514), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5518), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5519) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5521), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5521) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5523), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5525), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5526) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5527), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5528) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5530), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5532), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5534), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5535) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5537), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5537) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5539), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5541), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5543), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5570), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5571) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5575), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5576) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5579), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5582), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5584), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5585) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5587), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5589), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5591), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5592) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5594), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5594) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5596), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5598), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5600), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5601) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5603), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(5604) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 672, DateTimeKind.Local).AddTicks(7473), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4754), new DateTime(2023, 2, 27, 11, 45, 52, 673, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.AddForeignKey(
                name: "FK_so_hoa_thu_tuc_hanh_chinh_field_FieldId",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                column: "FieldId",
                principalSchema: "qlhsc07",
                principalTable: "field",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_so_hoa_thu_tuc_hanh_chinh_field_FieldId",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.DropColumn(
                name: "ma_linh_vuc",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh");

            migrationBuilder.RenameColumn(
                name: "FieldId",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                newName: "field_id");

            migrationBuilder.RenameIndex(
                name: "IX_so_hoa_thu_tuc_hanh_chinh_FieldId",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                newName: "IX_so_hoa_thu_tuc_hanh_chinh_field_id");

            migrationBuilder.AlterColumn<int>(
                name: "trang_thai_ho_so",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f52440-0318-401f-9ca6-4bc5980e393e",
                column: "ConcurrencyStamp",
                value: "84eb6b0c-4c35-4a5c-ba3d-18b06704bfe0");

            migrationBuilder.UpdateData(
                schema: "authentication",
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a7cd6c60-cea7-4aae-a750-514e1d74d1e8",
                column: "ConcurrencyStamp",
                value: "0ed43dc6-2f81-483f-af36-9a9649007d72");

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 2L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 3L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2182), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 4L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 5L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2229), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 6L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2232), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 7L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 8L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 9L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2242), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 10L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 11L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 12L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2251), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 13L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 14L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2257), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 15L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 16L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 17L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2267), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 18L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 19L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 20L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2276), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 21L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 22L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 23L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 24L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 25L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 26L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2293) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 27L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 28L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 29L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2300), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 30L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2302), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 31L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2305), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 32L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2307), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2308) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 33L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2311), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 34L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 35L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 36L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2318), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 37L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2321), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 38L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 39L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 40L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2328), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2329) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 41L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2331), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 42L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2334), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 43L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 44L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2340), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 45L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 46L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2345), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 47L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2347), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2348) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 48L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2350), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 49L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2352), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 50L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2381), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 51L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2383), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 52L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2386), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 53L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2389), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 54L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2392), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 55L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2394), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 56L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2397), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 57L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2400), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 58L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2403), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 59L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2405), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 60L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2408), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 61L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2410), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 62L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2413), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2414) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 63L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2415), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 64L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2418), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 65L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2421), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 66L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2424), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 67L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2426), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 68L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2429), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 69L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2431), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2432) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 70L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2434), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2435) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 71L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2436), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 72L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2439), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 73L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2441), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 74L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2444), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 75L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2446), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 76L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2449), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 77L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2451), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 78L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2453), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 79L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2456), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 80L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2458), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 81L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2461), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 82L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2463), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 83L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2466), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 84L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2468), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 85L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2471), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 86L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2473), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 87L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2475), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 88L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2478), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 89L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2480), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 90L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2483), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 91L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2485), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 92L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2488), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 93L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2490), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 94L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2516), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 95L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2519), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 96L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2521), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 97L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2524), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 98L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2527), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 99L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2529), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 100L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2531), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 101L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2534), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 102L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2537), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 103L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2539), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 104L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2541), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 105L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2544), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 106L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2546), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 107L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2549), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 108L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2552), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 109L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2554), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 110L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2556), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 111L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2559), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 112L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2561), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 113L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2564), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 114L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2566), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2568) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 115L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2569), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 116L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2572), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 117L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2574), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 118L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2577), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 119L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2579), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 120L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2581), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 121L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2584), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 122L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2586), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 123L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2589), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 124L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2591), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 125L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2594), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 126L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2597), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 127L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2599), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 128L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2602), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 129L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2606), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 130L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2608), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 131L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2611), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 132L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2636), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 133L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2638), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 134L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2641), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 135L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2643), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2644) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 136L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2646), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 137L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2648), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 138L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2651), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 139L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2653), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 140L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2656), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2657) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 141L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2658), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2659) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 142L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2661), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 143L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2663), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 144L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2666), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 145L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2668), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 146L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2671), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2672) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 147L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2673), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2674) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 148L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2676), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2676) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 149L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2678), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 150L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2681), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 151L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2683), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2684) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 152L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2686), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2686) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 153L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2688), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 154L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2690), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2691) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 155L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2693), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 156L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2695), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 157L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2698), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 158L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2700), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2701) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 159L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2702), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 160L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 161L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2708), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2708) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 162L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2710), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2711) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 163L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2713), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2713) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 164L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2715), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 165L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2718) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 166L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2720), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 167L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2723), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2724) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 168L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2725), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2726) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 169L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2728), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2728) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 170L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2730), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2731) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 171L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2733), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2734) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 172L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2735), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2736) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 173L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2738), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 174L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2740), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 175L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2743), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 176L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2745), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 177L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2748), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 178L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2750), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 179L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2752), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 180L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2755), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 181L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2757), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 182L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2760), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2761) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 183L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2788), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 184L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2791), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 185L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2793), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2794) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 186L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2796), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 187L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2798), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2799) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 188L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2801), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2802) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 189L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2803), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2804) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 190L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2806), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2807) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 192L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2808), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 193L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2811), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 194L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2813), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2814) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 195L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2815), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 196L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2818), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2819) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 197L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2820), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 198L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2823), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2824) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 199L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2825), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2826) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 200L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2828), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 201L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2830), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2831) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 202L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2832), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2833) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 203L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2835), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2836) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 204L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2837), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 205L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2840), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2841) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 206L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2842), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 207L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2845), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 208L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2847), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2848) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 209L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2849), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 210L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2852), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2852) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 211L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2854), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2855) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 212L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2856), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 213L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2859), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 214L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2861), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2862) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 215L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2864), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2865) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 216L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2866), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 217L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2869), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 218L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2871), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 219L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2874), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2875) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 220L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2876), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2877) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 221L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2879), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 222L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2881), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2882) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 223L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2884), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2885) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 224L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2886), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 225L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2889), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 226L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2891), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2892) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 227L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2893), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2894) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 228L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2896), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 229L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2898), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2899) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 230L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2901), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 231L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2903), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2904) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 232L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2906), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2907) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 233L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2908), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2909) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 234L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2911) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 235L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 236L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2942), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 237L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 238L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2947), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2947) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 239L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2949), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 240L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2951), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 241L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2954), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 242L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 243L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2959), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 244L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 245L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2964), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2964) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 246L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2966), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2967) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 247L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2968), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2969) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 248L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2971), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 249L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2973), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 250L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2976), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2977) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 251L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2979), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 252L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2982), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2983) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 253L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2985), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2986) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 254L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2988), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2989) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 255L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2991), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2992) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 256L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2995) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 257L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2997), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2998) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 258L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3002), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3003) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 259L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3005), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3006) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 260L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3008), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3009) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 261L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3055), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 262L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3123), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 263L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3127), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 264L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3130), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3131) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 265L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3133), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3134) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 266L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3135), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3136) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 267L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3138), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3139) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 268L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3141), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3142) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 269L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3143), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 270L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3146), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 271L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3148), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3149) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 272L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3151), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 273L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 610, DateTimeKind.Local).AddTicks(4678), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                schema: "qlhsc07",
                table: "field",
                keyColumn: "id",
                keyValue: 274L,
                columns: new[] { "created_date", "modified_date" },
                values: new object[] { new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2143), new DateTime(2023, 2, 27, 11, 12, 56, 611, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.AddForeignKey(
                name: "FK_so_hoa_thu_tuc_hanh_chinh_field_field_id",
                schema: "qlhsc07",
                table: "so_hoa_thu_tuc_hanh_chinh",
                column: "field_id",
                principalSchema: "qlhsc07",
                principalTable: "field",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
