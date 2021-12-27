using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class AddSkillAndTeacherDetailToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeacherDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutMeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobbies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherDetail_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageDegree = table.Column<int>(type: "int", nullable: false),
                    TeamLeaderDegree = table.Column<int>(type: "int", nullable: false),
                    DevelopmentDegree = table.Column<int>(type: "int", nullable: false),
                    DesignDegree = table.Column<int>(type: "int", nullable: false),
                    InnovationDegree = table.Column<int>(type: "int", nullable: false),
                    CommunicationDegree = table.Column<int>(type: "int", nullable: false),
                    TeacherDetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_TeacherDetail_TeacherDetailId",
                        column: x => x.TeacherDetailId,
                        principalTable: "TeacherDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skill_TeacherDetailId",
                table: "Skill",
                column: "TeacherDetailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetail_TeacherId",
                table: "TeacherDetail",
                column: "TeacherId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "TeacherDetail");
        }
    }
}
