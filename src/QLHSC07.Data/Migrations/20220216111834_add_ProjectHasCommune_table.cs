using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QLHSC07.Data.Migrations
{
    public partial class add_ProjectHasCommune_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "project_has_commune",
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
                    project_id = table.Column<long>(nullable: false),
                    commune_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_has_commune", x => x.id);
                    table.ForeignKey(
                        name: "FK_project_has_commune_commune_commune_id",
                        column: x => x.commune_id,
                        principalSchema: "cms",
                        principalTable: "commune",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_has_commune_project_project_id",
                        column: x => x.project_id,
                        principalSchema: "qlhsc07",
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_project_has_commune_project_id",
                schema: "qlhsc07",
                table: "project_has_commune",
                column: "project_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_has_commune_commune_id_project_id",
                schema: "qlhsc07",
                table: "project_has_commune",
                columns: new[] { "commune_id", "project_id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "project_has_commune",
                schema: "qlhsc07");
        }
    }
}
