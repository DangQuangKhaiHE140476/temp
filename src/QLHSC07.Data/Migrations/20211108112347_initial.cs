using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using QLHSC07.Entity;

namespace QLHSC07.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "cms");

            migrationBuilder.EnsureSchema(
                name: "sys");

            migrationBuilder.EnsureSchema(
                name: "authentication");

            migrationBuilder.EnsureSchema(
                name: "qlhsc07");

            migrationBuilder.CreateTable(
                name: "AspNetRefreshTokens",
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
                    UserName = table.Column<string>(nullable: true),
                    Token = table.Column<string>(nullable: true),
                    Expires = table.Column<DateTime>(nullable: false),
                    RemoteIpAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRefreshTokens", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "authentication",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "file_extension",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    name = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_extension", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "form_template",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    consultant_community_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_form_template", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "log_history",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    user_name = table.Column<string>(nullable: true),
                    action = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_log_history", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "province",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    unsign_name = table.Column<string>(maxLength: 50, nullable: true),
                    administrative_unit_code = table.Column<int>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    default_province = table.Column<bool>(nullable: false),
                    order_number = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "construction_type",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_construction_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "file_type_attachment",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_file_type_attachment", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "formality_recieve_profile",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formality_recieve_profile", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pc07_local",
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
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    address = table.Column<string>(maxLength: 200, nullable: true),
                    province_id = table.Column<int>(nullable: false),
                    commune_id = table.Column<int>(nullable: false),
                    phone = table.Column<string>(maxLength: 20, nullable: true),
                    fax = table.Column<string>(maxLength: 20, nullable: true),
                    email = table.Column<string>(maxLength: 50, nullable: true),
                    note = table.Column<string>(maxLength: 550, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pc07_local", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project_group",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project_status",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "project_type",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ranks",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ranks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "records_status",
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
                    name = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records_status", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "records_type",
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
                    name = table.Column<string>(maxLength: 200, nullable: true),
                    is_approval = table.Column<bool>(nullable: true),
                    maximum_processing_days = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "regency",
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
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regency", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "action",
                schema: "sys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_action", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "email_template",
                schema: "sys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    send_to = table.Column<string>(nullable: true),
                    cc = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email_template", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "reference_type",
                schema: "sys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reference_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "screen",
                schema: "sys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    parent_id = table.Column<int>(nullable: true),
                    code = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screen", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "authentication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "authentication",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "document_upload",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    parent_id = table.Column<long>(nullable: false),
                    type = table.Column<int>(nullable: false),
                    path = table.Column<string>(nullable: true),
                    file_extension_id = table.Column<int>(nullable: true),
                    allowed_modify = table.Column<bool>(nullable: false),
                    multi_size_image_paths = table.Column<List<MultiSizeImagePaths>>(type: "jsonb", nullable: true),
                    is_resize_image = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_document_upload", x => x.id);
                    table.ForeignKey(
                        name: "FK_document_upload_file_extension_file_extension_id",
                        column: x => x.file_extension_id,
                        principalSchema: "cms",
                        principalTable: "file_extension",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "form_template_question",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    form_template_id = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    order = table.Column<int>(nullable: false),
                    have_additional = table.Column<bool>(nullable: false),
                    answer_type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_form_template_question", x => x.id);
                    table.ForeignKey(
                        name: "FK_form_template_question_form_template_form_template_id",
                        column: x => x.form_template_id,
                        principalSchema: "cms",
                        principalTable: "form_template",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "person_info_answer",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    form_template_id = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    phone_no = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    suggestion = table.Column<string>(nullable: true),
                    reply = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person_info_answer", x => x.id);
                    table.ForeignKey(
                        name: "FK_person_info_answer_form_template_form_template_id",
                        column: x => x.form_template_id,
                        principalSchema: "cms",
                        principalTable: "form_template",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "district",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    unsign_name = table.Column<string>(maxLength: 50, nullable: true),
                    administrative_unit_code = table.Column<int>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    province_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_district", x => x.id);
                    table.ForeignKey(
                        name: "FK_district_province_province_id",
                        column: x => x.province_id,
                        principalSchema: "cms",
                        principalTable: "province",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "msg_session",
                schema: "qlhsc07",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    send_pc07_id = table.Column<long>(nullable: false),
                    title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_msg_session", x => x.id);
                    table.ForeignKey(
                        name: "FK_msg_session_pc07_local_send_pc07_id",
                        column: x => x.send_pc07_id,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "records_type_file_type",
                schema: "qlhsc07",
                columns: table => new
                {
                    records_type_id = table.Column<long>(nullable: false),
                    file_type_attachment_id = table.Column<long>(nullable: false),
                    is_required = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records_type_file_type", x => new { x.records_type_id, x.file_type_attachment_id });
                    table.ForeignKey(
                        name: "FK_records_type_file_type_file_type_attachment_file_type_attac~",
                        column: x => x.file_type_attachment_id,
                        principalSchema: "qlhsc07",
                        principalTable: "file_type_attachment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_records_type_file_type_records_type_records_type_id",
                        column: x => x.records_type_id,
                        principalSchema: "qlhsc07",
                        principalTable: "records_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "email_generated",
                schema: "sys",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    email_type = table.Column<string>(nullable: true),
                    status = table.Column<int>(nullable: false),
                    sent_date = table.Column<DateTime>(nullable: false),
                    error_message = table.Column<string>(nullable: true),
                    reference_type = table.Column<int>(nullable: false),
                    reference_number = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    send_to = table.Column<string>(nullable: true),
                    cc = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    subject = table.Column<string>(nullable: true),
                    send_from = table.Column<string>(nullable: true),
                    user_name = table.Column<string>(nullable: true),
                    phone_number = table.Column<string>(nullable: true),
                    message = table.Column<string>(nullable: true),
                    is_replied = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email_generated", x => x.id);
                    table.ForeignKey(
                        name: "FK_email_generated_reference_type_reference_type",
                        column: x => x.reference_type,
                        principalSchema: "sys",
                        principalTable: "reference_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "security_matrix",
                schema: "sys",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    action_id = table.Column<int>(nullable: false),
                    screen_id = table.Column<int>(nullable: false),
                    role_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_security_matrix", x => x.id);
                    table.ForeignKey(
                        name: "FK_security_matrix_action_action_id",
                        column: x => x.action_id,
                        principalSchema: "sys",
                        principalTable: "action",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_security_matrix_AspNetRoles_role_id",
                        column: x => x.role_id,
                        principalSchema: "authentication",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_security_matrix_screen_screen_id",
                        column: x => x.screen_id,
                        principalSchema: "sys",
                        principalTable: "screen",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "authentication",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Sex = table.Column<bool>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(nullable: true),
                    DocumentUploadId = table.Column<long>(nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(maxLength: 15, nullable: true),
                    regency_id = table.Column<long>(nullable: true),
                    rank_id = table.Column<long>(nullable: true),
                    pc07_local_id = table.Column<long>(nullable: false),
                    pc07_local_id1 = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_document_upload_DocumentUploadId",
                        column: x => x.DocumentUploadId,
                        principalSchema: "cms",
                        principalTable: "document_upload",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_ranks_rank_id",
                        column: x => x.rank_id,
                        principalSchema: "qlhsc07",
                        principalTable: "ranks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_regency_regency_id",
                        column: x => x.regency_id,
                        principalSchema: "qlhsc07",
                        principalTable: "regency",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_pc07_local_pc07_local_id1",
                        column: x => x.pc07_local_id1,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "form_template_answer",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    question_id = table.Column<int>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    order = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_form_template_answer", x => x.id);
                    table.ForeignKey(
                        name: "FK_form_template_answer_form_template_question_question_id",
                        column: x => x.question_id,
                        principalSchema: "cms",
                        principalTable: "form_template_question",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "commune",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created_by = table.Column<string>(nullable: true),
                    created_date = table.Column<DateTime>(nullable: false),
                    modified_by = table.Column<string>(nullable: true),
                    modified_date = table.Column<DateTime>(nullable: false),
                    is_delete = table.Column<bool>(nullable: false),
                    name = table.Column<string>(maxLength: 50, nullable: true),
                    unsign_name = table.Column<string>(maxLength: 50, nullable: true),
                    administrative_unit_code = table.Column<int>(nullable: false),
                    longitude = table.Column<double>(nullable: false),
                    latitude = table.Column<double>(nullable: false),
                    district_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_commune", x => x.id);
                    table.ForeignKey(
                        name: "FK_commune_district_district_id",
                        column: x => x.district_id,
                        principalSchema: "cms",
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "has_msg_session",
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
                    pc07_local_id = table.Column<long>(nullable: false),
                    msg_session_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_has_msg_session", x => x.id);
                    table.ForeignKey(
                        name: "FK_has_msg_session_msg_session_msg_session_id",
                        column: x => x.msg_session_id,
                        principalSchema: "qlhsc07",
                        principalTable: "msg_session",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_has_msg_session_pc07_local_pc07_local_id",
                        column: x => x.pc07_local_id,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "message",
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
                    msg_session_id = table.Column<string>(nullable: true),
                    content = table.Column<string>(maxLength: 9999, nullable: true),
                    is_reply = table.Column<bool>(nullable: false),
                    file_attach_ids = table.Column<ICollection<long>>(type: "jsonb", nullable: true),
                    message_date = table.Column<DateTime>(nullable: true),
                    message_by_id = table.Column<long>(nullable: true),
                    is_important = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_message", x => x.id);
                    table.ForeignKey(
                        name: "FK_message_pc07_local_message_by_id",
                        column: x => x.message_by_id,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_message_msg_session_msg_session_id",
                        column: x => x.msg_session_id,
                        principalSchema: "qlhsc07",
                        principalTable: "msg_session",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "msg_receive",
                schema: "qlhsc07",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    msg_session_id = table.Column<string>(nullable: true),
                    receive_pc07_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_msg_receive", x => x.id);
                    table.ForeignKey(
                        name: "FK_msg_receive_msg_session_msg_session_id",
                        column: x => x.msg_session_id,
                        principalSchema: "qlhsc07",
                        principalTable: "msg_session",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_msg_receive_pc07_local_receive_pc07_id",
                        column: x => x.receive_pc07_id,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "authentication",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "authentication",
                columns: table => new
                {
                    ProviderKey = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "authentication",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "authentication",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "authentication",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    ExpiredTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "answer_extension",
                schema: "cms",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    answer_id = table.Column<int>(nullable: true),
                    question_id = table.Column<int>(nullable: false),
                    person_info_id = table.Column<int>(nullable: false),
                    additional = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_answer_extension", x => x.id);
                    table.ForeignKey(
                        name: "FK_answer_extension_form_template_answer_answer_id",
                        column: x => x.answer_id,
                        principalSchema: "cms",
                        principalTable: "form_template_answer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_answer_extension_person_info_answer_person_info_id",
                        column: x => x.person_info_id,
                        principalSchema: "cms",
                        principalTable: "person_info_answer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_answer_extension_form_template_question_question_id",
                        column: x => x.question_id,
                        principalSchema: "cms",
                        principalTable: "form_template_question",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "investor",
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
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    tax_code = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    fax = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    province_id = table.Column<int>(nullable: true),
                    province_id1 = table.Column<int>(nullable: true),
                    district_id = table.Column<int>(nullable: true),
                    district_id1 = table.Column<int>(nullable: true),
                    commune_id = table.Column<int>(nullable: true),
                    commune_id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_investor", x => x.id);
                    table.ForeignKey(
                        name: "FK_investor_commune_commune_id1",
                        column: x => x.commune_id1,
                        principalSchema: "cms",
                        principalTable: "commune",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_investor_district_district_id1",
                        column: x => x.district_id1,
                        principalSchema: "cms",
                        principalTable: "district",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_investor_province_province_id1",
                        column: x => x.province_id1,
                        principalSchema: "cms",
                        principalTable: "province",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "project",
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
                    name = table.Column<string>(nullable: true),
                    investor_id = table.Column<long>(nullable: false),
                    project_type_id = table.Column<long>(nullable: false),
                    project_group_id = table.Column<long>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    commune_id = table.Column<int>(nullable: false),
                    building_site = table.Column<string>(nullable: true),
                    is_edit = table.Column<bool>(nullable: false),
                    project_status_id = table.Column<long>(nullable: false),
                    note = table.Column<string>(nullable: true),
                    construction_type_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.id);
                    table.ForeignKey(
                        name: "FK_project_commune_commune_id",
                        column: x => x.commune_id,
                        principalSchema: "cms",
                        principalTable: "commune",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_construction_type_construction_type_id",
                        column: x => x.construction_type_id,
                        principalSchema: "qlhsc07",
                        principalTable: "construction_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_investor_investor_id",
                        column: x => x.investor_id,
                        principalSchema: "qlhsc07",
                        principalTable: "investor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_project_group_project_group_id",
                        column: x => x.project_group_id,
                        principalSchema: "qlhsc07",
                        principalTable: "project_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_project_status_project_status_id",
                        column: x => x.project_status_id,
                        principalSchema: "qlhsc07",
                        principalTable: "project_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_project_project_type_project_type_id",
                        column: x => x.project_type_id,
                        principalSchema: "qlhsc07",
                        principalTable: "project_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "records",
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
                    project_id = table.Column<long>(nullable: true),
                    project_id1 = table.Column<long>(nullable: true),
                    records_types_id = table.Column<long>(nullable: true),
                    records_types_id1 = table.Column<long>(nullable: true),
                    record_num = table.Column<long>(nullable: true),
                    receive_type_id = table.Column<long>(nullable: true),
                    receive_date = table.Column<DateTime>(nullable: true),
                    receive_user_Id = table.Column<string>(nullable: true),
                    pc07_receive_id = table.Column<long>(nullable: true),
                    pc07_manage_id = table.Column<long>(nullable: true),
                    predict_return_date = table.Column<DateTime>(nullable: true),
                    date_real_return = table.Column<DateTime>(nullable: true),
                    result = table.Column<bool>(nullable: true),
                    return_doc_numb = table.Column<long>(nullable: true),
                    records_status_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records", x => x.id);
                    table.ForeignKey(
                        name: "FK_records_pc07_local_pc07_manage_id",
                        column: x => x.pc07_manage_id,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_records_pc07_local_pc07_receive_id",
                        column: x => x.pc07_receive_id,
                        principalSchema: "qlhsc07",
                        principalTable: "pc07_local",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_records_formality_recieve_profile_receive_type_id",
                        column: x => x.receive_type_id,
                        principalSchema: "qlhsc07",
                        principalTable: "formality_recieve_profile",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_records_AspNetUsers_receive_user_Id",
                        column: x => x.receive_user_Id,
                        principalSchema: "authentication",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_records_records_status_records_status_id",
                        column: x => x.records_status_id,
                        principalSchema: "qlhsc07",
                        principalTable: "records_status",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_records_project_project_id1",
                        column: x => x.project_id1,
                        principalSchema: "qlhsc07",
                        principalTable: "project",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_records_records_type_records_types_id1",
                        column: x => x.records_types_id1,
                        principalSchema: "qlhsc07",
                        principalTable: "records_type",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "records_file",
                schema: "qlhsc07",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    records_id = table.Column<long>(nullable: false),
                    file_type_attachment_id = table.Column<long>(nullable: false),
                    document_upload_id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_records_file", x => x.id);
                    table.ForeignKey(
                        name: "FK_records_file_document_upload_document_upload_id",
                        column: x => x.document_upload_id,
                        principalSchema: "cms",
                        principalTable: "document_upload",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_records_file_file_type_attachment_file_type_attachment_id",
                        column: x => x.file_type_attachment_id,
                        principalSchema: "qlhsc07",
                        principalTable: "file_type_attachment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_records_file_records_records_id",
                        column: x => x.records_id,
                        principalSchema: "qlhsc07",
                        principalTable: "records",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "authentication",
                table: "AspNetRoles",
                columns: new[] { "Id", "Code", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "NormalizedName" },
                values: new object[] { "20f52440-0318-401f-9ca6-4bc5980e393e", "ADMIN", "399d0f8a-9cb5-4374-a78a-86a7349970e6", null, null, null, null, "ADMIN", null });

            migrationBuilder.InsertData(
                schema: "authentication",
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "CreatedBy", "CreatedDate", "DateOfBirth", "Description", "DocumentUploadId", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "ModifiedBy", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "pc07_local_id", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "rank_id", "regency_id", "SecurityStamp", "Sex", "Status", "TwoFactorEnabled", "UserName", "UserType", "pc07_local_id1" },
                values: new object[] { "a7cd6c60-cea7-4aae-a750-514e1d74d1e8", 0, "Hà Nội", "96405b20-bbfe-4c3a-a2bc-063564bb087b", "Administrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Administrator", null, "admin@gmail.com", true, "Administrator", false, null, "Administrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", 0L, "AQAAAAEAACcQAAAAEIwpHgrYjpij2oKnyfSjRuvmxiEK9ItWF2UjGWCHuJ9iyqMNd3ymn4XrRs5dqRRSMQ==", "0968883898", true, null, null, "ce58ce2d-d3bf-45ab-86f2-15ac96b88104", true, true, false, "admin@gmail.com", null, null });

            migrationBuilder.InsertData(
                schema: "authentication",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a7cd6c60-cea7-4aae-a750-514e1d74d1e8", "20f52440-0318-401f-9ca6-4bc5980e393e" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "authentication",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "authentication",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "authentication",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "authentication",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId1",
                schema: "authentication",
                table: "AspNetUserLogins",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "authentication",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DocumentUploadId",
                schema: "authentication",
                table: "AspNetUsers",
                column: "DocumentUploadId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "authentication",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "authentication",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_rank_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "rank_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_regency_id",
                schema: "authentication",
                table: "AspNetUsers",
                column: "regency_id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_pc07_local_id1",
                schema: "authentication",
                table: "AspNetUsers",
                column: "pc07_local_id1");

            migrationBuilder.CreateIndex(
                name: "IX_answer_extension_answer_id",
                schema: "cms",
                table: "answer_extension",
                column: "answer_id");

            migrationBuilder.CreateIndex(
                name: "IX_answer_extension_person_info_id",
                schema: "cms",
                table: "answer_extension",
                column: "person_info_id");

            migrationBuilder.CreateIndex(
                name: "IX_answer_extension_question_id",
                schema: "cms",
                table: "answer_extension",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_commune_district_id",
                schema: "cms",
                table: "commune",
                column: "district_id");

            migrationBuilder.CreateIndex(
                name: "IX_district_province_id",
                schema: "cms",
                table: "district",
                column: "province_id");

            migrationBuilder.CreateIndex(
                name: "IX_document_upload_file_extension_id",
                schema: "cms",
                table: "document_upload",
                column: "file_extension_id");

            migrationBuilder.CreateIndex(
                name: "IX_form_template_answer_question_id",
                schema: "cms",
                table: "form_template_answer",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "IX_form_template_question_form_template_id",
                schema: "cms",
                table: "form_template_question",
                column: "form_template_id");

            migrationBuilder.CreateIndex(
                name: "IX_person_info_answer_form_template_id",
                schema: "cms",
                table: "person_info_answer",
                column: "form_template_id");

            migrationBuilder.CreateIndex(
                name: "IX_has_msg_session_msg_session_id",
                schema: "qlhsc07",
                table: "has_msg_session",
                column: "msg_session_id");

            migrationBuilder.CreateIndex(
                name: "IX_has_msg_session_pc07_local_id",
                schema: "qlhsc07",
                table: "has_msg_session",
                column: "pc07_local_id");

            migrationBuilder.CreateIndex(
                name: "IX_investor_commune_id1",
                schema: "qlhsc07",
                table: "investor",
                column: "commune_id1");

            migrationBuilder.CreateIndex(
                name: "IX_investor_district_id1",
                schema: "qlhsc07",
                table: "investor",
                column: "district_id1");

            migrationBuilder.CreateIndex(
                name: "IX_investor_province_id1",
                schema: "qlhsc07",
                table: "investor",
                column: "province_id1");

            migrationBuilder.CreateIndex(
                name: "IX_message_message_by_id",
                schema: "qlhsc07",
                table: "message",
                column: "message_by_id");

            migrationBuilder.CreateIndex(
                name: "IX_message_msg_session_id",
                schema: "qlhsc07",
                table: "message",
                column: "msg_session_id");

            migrationBuilder.CreateIndex(
                name: "IX_msg_receive_msg_session_id",
                schema: "qlhsc07",
                table: "msg_receive",
                column: "msg_session_id");

            migrationBuilder.CreateIndex(
                name: "IX_msg_receive_receive_pc07_id",
                schema: "qlhsc07",
                table: "msg_receive",
                column: "receive_pc07_id");

            migrationBuilder.CreateIndex(
                name: "IX_msg_session_send_pc07_id",
                schema: "qlhsc07",
                table: "msg_session",
                column: "send_pc07_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_commune_id",
                schema: "qlhsc07",
                table: "project",
                column: "commune_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_construction_type_id",
                schema: "qlhsc07",
                table: "project",
                column: "construction_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_investor_id",
                schema: "qlhsc07",
                table: "project",
                column: "investor_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_project_group_id",
                schema: "qlhsc07",
                table: "project",
                column: "project_group_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_project_status_id",
                schema: "qlhsc07",
                table: "project",
                column: "project_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_project_project_type_id",
                schema: "qlhsc07",
                table: "project",
                column: "project_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_pc07_manage_id",
                schema: "qlhsc07",
                table: "records",
                column: "pc07_manage_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_pc07_receive_id",
                schema: "qlhsc07",
                table: "records",
                column: "pc07_receive_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_receive_type_id",
                schema: "qlhsc07",
                table: "records",
                column: "receive_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_receive_user_Id",
                schema: "qlhsc07",
                table: "records",
                column: "receive_user_Id");

            migrationBuilder.CreateIndex(
                name: "IX_records_records_status_id",
                schema: "qlhsc07",
                table: "records",
                column: "records_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_project_id1",
                schema: "qlhsc07",
                table: "records",
                column: "project_id1");

            migrationBuilder.CreateIndex(
                name: "IX_records_records_types_id1",
                schema: "qlhsc07",
                table: "records",
                column: "records_types_id1");

            migrationBuilder.CreateIndex(
                name: "IX_records_file_document_upload_id",
                schema: "qlhsc07",
                table: "records_file",
                column: "document_upload_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_file_file_type_attachment_id",
                schema: "qlhsc07",
                table: "records_file",
                column: "file_type_attachment_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_file_records_id",
                schema: "qlhsc07",
                table: "records_file",
                column: "records_id");

            migrationBuilder.CreateIndex(
                name: "IX_records_type_file_type_file_type_attachment_id",
                schema: "qlhsc07",
                table: "records_type_file_type",
                column: "file_type_attachment_id");

            migrationBuilder.CreateIndex(
                name: "IX_email_generated_reference_type",
                schema: "sys",
                table: "email_generated",
                column: "reference_type");

            migrationBuilder.CreateIndex(
                name: "IX_security_matrix_action_id",
                schema: "sys",
                table: "security_matrix",
                column: "action_id");

            migrationBuilder.CreateIndex(
                name: "IX_security_matrix_role_id",
                schema: "sys",
                table: "security_matrix",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_security_matrix_screen_id",
                schema: "sys",
                table: "security_matrix",
                column: "screen_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRefreshTokens",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "answer_extension",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "log_history",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "has_msg_session",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "message",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "msg_receive",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "records_file",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "records_type_file_type",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "email_generated",
                schema: "sys");

            migrationBuilder.DropTable(
                name: "email_template",
                schema: "sys");

            migrationBuilder.DropTable(
                name: "security_matrix",
                schema: "sys");

            migrationBuilder.DropTable(
                name: "form_template_answer",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "person_info_answer",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "msg_session",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "records",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "file_type_attachment",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "reference_type",
                schema: "sys");

            migrationBuilder.DropTable(
                name: "action",
                schema: "sys");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "screen",
                schema: "sys");

            migrationBuilder.DropTable(
                name: "form_template_question",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "formality_recieve_profile",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "authentication");

            migrationBuilder.DropTable(
                name: "records_status",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "project",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "records_type",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "form_template",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "document_upload",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "ranks",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "regency",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "pc07_local",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "construction_type",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "investor",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "project_group",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "project_status",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "project_type",
                schema: "qlhsc07");

            migrationBuilder.DropTable(
                name: "file_extension",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "commune",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "district",
                schema: "cms");

            migrationBuilder.DropTable(
                name: "province",
                schema: "cms");
        }
    }
}
