using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xiao_Hour_ePOS.Migrations
{
    public partial class update_tbl_user_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fullname",
                table: "tbl_user");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fullname",
                table: "tbl_user",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
