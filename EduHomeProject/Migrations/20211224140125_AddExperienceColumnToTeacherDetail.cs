using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class AddExperienceColumnToTeacherDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformation_TeacherDetail_TeacherDetailId",
                table: "ContactInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_Skill_TeacherDetail_TeacherDetailId",
                table: "Skill");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetail_Teachers_TeacherId",
                table: "TeacherDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherDetail",
                table: "TeacherDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skill",
                table: "Skill");

            migrationBuilder.RenameTable(
                name: "TeacherDetail",
                newName: "TeacherDetails");

            migrationBuilder.RenameTable(
                name: "Skill",
                newName: "Skills");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherDetail_TeacherId",
                table: "TeacherDetails",
                newName: "IX_TeacherDetails_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Skill_TeacherDetailId",
                table: "Skills",
                newName: "IX_Skills_TeacherDetailId");

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "TeacherDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocialAdressId",
                table: "TeacherDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherDetails",
                table: "TeacherDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SocialAdresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialAdresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialAdresses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_SocialAdressId",
                table: "TeacherDetails",
                column: "SocialAdressId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialAdresses_TeacherId",
                table: "SocialAdresses",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformation_TeacherDetails_TeacherDetailId",
                table: "ContactInformation",
                column: "TeacherDetailId",
                principalTable: "TeacherDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_TeacherDetails_TeacherDetailId",
                table: "Skills",
                column: "TeacherDetailId",
                principalTable: "TeacherDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_SocialAdresses_SocialAdressId",
                table: "TeacherDetails",
                column: "SocialAdressId",
                principalTable: "SocialAdresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactInformation_TeacherDetails_TeacherDetailId",
                table: "ContactInformation");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_TeacherDetails_TeacherDetailId",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_SocialAdresses_SocialAdressId",
                table: "TeacherDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.DropTable(
                name: "SocialAdresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherDetails",
                table: "TeacherDetails");

            migrationBuilder.DropIndex(
                name: "IX_TeacherDetails_SocialAdressId",
                table: "TeacherDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "TeacherDetails");

            migrationBuilder.DropColumn(
                name: "SocialAdressId",
                table: "TeacherDetails");

            migrationBuilder.RenameTable(
                name: "TeacherDetails",
                newName: "TeacherDetail");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "Skill");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetail",
                newName: "IX_TeacherDetail_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Skills_TeacherDetailId",
                table: "Skill",
                newName: "IX_Skill_TeacherDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherDetail",
                table: "TeacherDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skill",
                table: "Skill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactInformation_TeacherDetail_TeacherDetailId",
                table: "ContactInformation",
                column: "TeacherDetailId",
                principalTable: "TeacherDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_TeacherDetail_TeacherDetailId",
                table: "Skill",
                column: "TeacherDetailId",
                principalTable: "TeacherDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetail_Teachers_TeacherId",
                table: "TeacherDetail",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
