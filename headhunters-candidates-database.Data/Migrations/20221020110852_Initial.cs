using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace headhunters_candidates_database.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpenPositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpenPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CandidateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CandidateCompany",
                columns: table => new
                {
                    CandidatesId = table.Column<int>(type: "int", nullable: false),
                    CompanyAppliedToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateCompany", x => new { x.CandidatesId, x.CompanyAppliedToId });
                    table.ForeignKey(
                        name: "FK_CandidateCompany_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateCompany_Companies_CompanyAppliedToId",
                        column: x => x.CompanyAppliedToId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatePosition",
                columns: table => new
                {
                    CandidatesId = table.Column<int>(type: "int", nullable: false),
                    PositionAppliedToId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatePosition", x => new { x.CandidatesId, x.PositionAppliedToId });
                    table.ForeignKey(
                        name: "FK_CandidatePosition_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatePosition_OpenPositions_PositionAppliedToId",
                        column: x => x.PositionAppliedToId,
                        principalTable: "OpenPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPosition",
                columns: table => new
                {
                    CompaniesId = table.Column<int>(type: "int", nullable: false),
                    OpenPositionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPosition", x => new { x.CompaniesId, x.OpenPositionsId });
                    table.ForeignKey(
                        name: "FK_CompanyPosition_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyPosition_OpenPositions_OpenPositionsId",
                        column: x => x.OpenPositionsId,
                        principalTable: "OpenPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateCompany_CompanyAppliedToId",
                table: "CandidateCompany",
                column: "CompanyAppliedToId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatePosition_PositionAppliedToId",
                table: "CandidatePosition",
                column: "PositionAppliedToId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyPosition_OpenPositionsId",
                table: "CompanyPosition",
                column: "OpenPositionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_CandidateId",
                table: "Skill",
                column: "CandidateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateCompany");

            migrationBuilder.DropTable(
                name: "CandidatePosition");

            migrationBuilder.DropTable(
                name: "CompanyPosition");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "OpenPositions");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
