using Microsoft.EntityFrameworkCore.Migrations;

namespace UETFA.Data.Migrations
{
    public partial class MigRez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idRezultata",
                table: "Utakmica");

            migrationBuilder.AddColumn<int>(
                name: "rezTim1",
                table: "Utakmica",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rezTim2",
                table: "Utakmica",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "rezTim1",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "rezTim2",
                table: "Utakmica");

            migrationBuilder.AddColumn<int>(
                name: "idRezultata",
                table: "Utakmica",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
