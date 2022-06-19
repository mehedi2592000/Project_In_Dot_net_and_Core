using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Again_practice.Migrations
{
    public partial class newfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgname",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgname",
                table: "Products");
        }
    }
}
