using Microsoft.EntityFrameworkCore.Migrations;

namespace UETFA.Data.Migrations
{
    public partial class IspravkaUtakmice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utakmica_Rezultat_rezultatID",
                table: "Utakmica");

            migrationBuilder.DropForeignKey(
                name: "FK_Utakmica_Sudija_sudijaID",
                table: "Utakmica");

            migrationBuilder.DropForeignKey(
                name: "FK_Utakmica_Tim_tim1ID",
                table: "Utakmica");

            migrationBuilder.DropForeignKey(
                name: "FK_Utakmica_Tim_tim2ID",
                table: "Utakmica");

            migrationBuilder.DropIndex(
                name: "IX_Utakmica_rezultatID",
                table: "Utakmica");

            migrationBuilder.DropIndex(
                name: "IX_Utakmica_sudijaID",
                table: "Utakmica");

            migrationBuilder.DropIndex(
                name: "IX_Utakmica_tim1ID",
                table: "Utakmica");

            migrationBuilder.DropIndex(
                name: "IX_Utakmica_tim2ID",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "rezultatID",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "sudijaID",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "tim1ID",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "tim2ID",
                table: "Utakmica");

            migrationBuilder.AddColumn<int>(
                name: "idRezultata",
                table: "Utakmica",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSudije",
                table: "Utakmica",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTima1",
                table: "Utakmica",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTima2",
                table: "Utakmica",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idRezultata",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "idSudije",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "idTima1",
                table: "Utakmica");

            migrationBuilder.DropColumn(
                name: "idTima2",
                table: "Utakmica");

            migrationBuilder.AddColumn<int>(
                name: "rezultatID",
                table: "Utakmica",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "sudijaID",
                table: "Utakmica",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tim1ID",
                table: "Utakmica",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tim2ID",
                table: "Utakmica",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Utakmica_rezultatID",
                table: "Utakmica",
                column: "rezultatID");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmica_sudijaID",
                table: "Utakmica",
                column: "sudijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmica_tim1ID",
                table: "Utakmica",
                column: "tim1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Utakmica_tim2ID",
                table: "Utakmica",
                column: "tim2ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utakmica_Rezultat_rezultatID",
                table: "Utakmica",
                column: "rezultatID",
                principalTable: "Rezultat",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utakmica_Sudija_sudijaID",
                table: "Utakmica",
                column: "sudijaID",
                principalTable: "Sudija",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utakmica_Tim_tim1ID",
                table: "Utakmica",
                column: "tim1ID",
                principalTable: "Tim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Utakmica_Tim_tim2ID",
                table: "Utakmica",
                column: "tim2ID",
                principalTable: "Tim",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
