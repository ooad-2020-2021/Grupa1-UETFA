using Microsoft.EntityFrameworkCore.Migrations;

namespace UETFA.Data.Migrations
{
    public partial class migracija3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idSudije",
                table: "Utakmica");

            migrationBuilder.AddColumn<int>(
                name: "brojNerjesenih",
                table: "Tim",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "brojPobjeda",
                table: "Tim",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "brojPoraza",
                table: "Tim",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "brojNerjesenih",
                table: "Tim");

            migrationBuilder.DropColumn(
                name: "brojPobjeda",
                table: "Tim");

            migrationBuilder.DropColumn(
                name: "brojPoraza",
                table: "Tim");

            migrationBuilder.AddColumn<int>(
                name: "idSudije",
                table: "Utakmica",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
