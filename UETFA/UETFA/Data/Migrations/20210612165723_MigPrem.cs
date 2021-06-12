using Microsoft.EntityFrameworkCore.Migrations;

namespace UETFA.Data.Migrations
{
    public partial class MigPrem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDKor",
                table: "Premium",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IDKor",
                table: "Premium");
        }
    }
}
