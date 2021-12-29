using Microsoft.EntityFrameworkCore.Migrations;

namespace EduHomeProject.Migrations
{
    public partial class ChangeAndAddColumntsToFooterContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "FooterContact",
                newName: "SubNumber");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "FooterContact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainMail",
                table: "FooterContact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MainNumber",
                table: "FooterContact",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubMail",
                table: "FooterContact",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "FooterContact");

            migrationBuilder.DropColumn(
                name: "MainMail",
                table: "FooterContact");

            migrationBuilder.DropColumn(
                name: "MainNumber",
                table: "FooterContact");

            migrationBuilder.DropColumn(
                name: "SubMail",
                table: "FooterContact");

            migrationBuilder.RenameColumn(
                name: "SubNumber",
                table: "FooterContact",
                newName: "MyProperty");
        }
    }
}
