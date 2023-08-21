using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyName.ProjectName.Migrations
{
    public partial class userpropnotice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AbpUsers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Introduction",
                table: "AbpUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AbpUsers");

            migrationBuilder.DropColumn(
                name: "Introduction",
                table: "AbpUsers");
        }
    }
}
