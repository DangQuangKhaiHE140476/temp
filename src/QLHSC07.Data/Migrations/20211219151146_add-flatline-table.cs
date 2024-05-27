using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class addflatlinetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "flatline",
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
                    RecordId = table.Column<long>(nullable: true),
                    ProjectId = table.Column<long>(nullable: true),
                    RecordNum = table.Column<long>(nullable: true),
                    ProjectName = table.Column<string>(nullable: true),
                    InvestorName = table.Column<string>(nullable: true),
                    RecordTypeName = table.Column<string>(nullable: true),
                    ReceptionForm = table.Column<string>(nullable: true),
                    ReceiveDate = table.Column<DateTime>(nullable: true),
                    ReceiveUserName = table.Column<string>(nullable: true),
                    DatePredictReturn = table.Column<DateTime>(nullable: true),
                    DateRealReturn = table.Column<DateTime>(nullable: true),
                    PC07ReceiveName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CommuneName = table.Column<string>(nullable: true),
                    DistrictName = table.Column<string>(nullable: true),
                    ProvinceName = table.Column<string>(nullable: true),
                    ProjectTypeId = table.Column<long>(nullable: true),
                    ProjectTypeName = table.Column<string>(nullable: true),
                    ReturnDocNumb = table.Column<long>(nullable: true),
                    RecordTypeId = table.Column<long>(nullable: true),
                    IsNewProject = table.Column<bool>(nullable: true),
                    GroupProjectId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flatline", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flatline",
                schema: "qlhsc07");
        }
    }
}
