using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace King.AbpVnextPro.Migrations
{
    public partial class addnoticeissend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSend",
                table: "Notification",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSend",
                table: "Notification");
        }
    }
}
