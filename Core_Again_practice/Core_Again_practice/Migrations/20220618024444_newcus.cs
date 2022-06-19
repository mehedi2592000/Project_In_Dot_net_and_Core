using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core_Again_practice.Migrations
{
    public partial class newcus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "num",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "num",
                table: "Customers");
        }
    }
}
