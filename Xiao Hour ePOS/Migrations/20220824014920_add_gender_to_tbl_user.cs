using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Xiao_Hour_ePOS.Migrations
{
    public partial class add_gender_to_tbl_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "tbl_user",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "tbl_user");
        }
    }
}
