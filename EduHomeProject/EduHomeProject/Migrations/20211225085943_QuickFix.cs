using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class QuickFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.AddColumn<int>(
                name: "TeacherDetails",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherDetails",
                table: "Teachers",
                column: "TeacherDetails",
                unique: true,
                filter: "[TeacherDetails] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeacherDetails_TeacherDetails",
                table: "Teachers",
                column: "TeacherDetails",
                principalTable: "TeacherDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeacherDetails_TeacherDetails",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_TeacherDetails",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.DropColumn(
                name: "TeacherDetails",
                table: "Teachers");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                unique: true);
        }
    }
}
