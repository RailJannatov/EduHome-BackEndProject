using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class AddAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherDetails_SocialAdresses_SocialAdressId",
                table: "TeacherDetails");

            migrationBuilder.DropIndex(
                name: "IX_TeacherDetails_SocialAdressId",
                table: "TeacherDetails");

            migrationBuilder.DropColumn(
                name: "SocialAdressId",
                table: "TeacherDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SocialAdressId",
                table: "TeacherDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeacherDetails_SocialAdressId",
                table: "TeacherDetails",
                column: "SocialAdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherDetails_SocialAdresses_SocialAdressId",
                table: "TeacherDetails",
                column: "SocialAdressId",
                principalTable: "SocialAdresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
