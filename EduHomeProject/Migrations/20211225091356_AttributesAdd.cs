using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class AttributesAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails");

            migrationBuilder.DropIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_Teachers_TeacherId",
                table: "TeacherDetails",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
