using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PairCode.GestaoEscolar.Presentations.Web.MudBlazor.Infrastructures.Data.Education.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationEducationDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EducationDb");

            migrationBuilder.CreateTable(
                name: "SchoolGroups",
                schema: "EducationDb",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeName = table.Column<string>(type: "NVARCHAR(128)", nullable: false),
                    CompanyName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    TaxIdentificationNumber = table.Column<string>(type: "NVARCHAR(64)", nullable: false),
                    FoundedAt = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                schema: "EducationDb",
                columns: table => new
                {
                    Id = table.Column<long>(type: "BIGINT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TradeName = table.Column<string>(type: "NVARCHAR(128)", nullable: false),
                    CompanyName = table.Column<string>(type: "NVARCHAR(256)", nullable: false),
                    TaxIdentificationNumber = table.Column<string>(type: "NVARCHAR(64)", nullable: false),
                    FoundedAt = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    SchoolGroupId = table.Column<long>(type: "BIGINT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schools_SchoolGroups_SchoolGroupId",
                        column: x => x.SchoolGroupId,
                        principalSchema: "EducationDb",
                        principalTable: "SchoolGroups",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schools_SchoolGroupId",
                schema: "EducationDb",
                table: "Schools",
                column: "SchoolGroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools",
                schema: "EducationDb");

            migrationBuilder.DropTable(
                name: "SchoolGroups",
                schema: "EducationDb");
        }
    }
}
