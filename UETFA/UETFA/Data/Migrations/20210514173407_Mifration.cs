using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UETFA.Data.Migrations
{
    public partial class Mifration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Igrac",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imePrezime = table.Column<string>(nullable: true),
                    brojGolova = table.Column<int>(nullable: false),
                    brojAsistencija = table.Column<int>(nullable: false),
                    brojCrvenihKartona = table.Column<int>(nullable: false),
                    brojZutihKartona = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Igrac", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LiveStream",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiveStream", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Notifikacija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifikacija", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Premium",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imeVlasnikaKartice = table.Column<string>(nullable: true),
                    brojKartice = table.Column<int>(nullable: false),
                    cvc = table.Column<int>(nullable: false),
                    datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Premium", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rezultat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    domaci = table.Column<int>(nullable: false),
                    gosti = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezultat", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sudija",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sudija", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tim",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ime = table.Column<string>(nullable: true),
                    datiGolovi = table.Column<int>(nullable: false),
                    primljeniGolovi = table.Column<int>(nullable: false),
                    brojOdigranihUtakmica = table.Column<int>(nullable: false),
                    trener = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tim", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Utakmica",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusUtakmice = table.Column<string>(nullable: true),
                    datumUtakmice = table.Column<DateTime>(nullable: false),
                    sudijaID = table.Column<int>(nullable: true),
                    tim1ID = table.Column<int>(nullable: true),
                    tim2ID = table.Column<int>(nullable: true),
                    rezultatID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utakmica", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Utakmica_Rezultat_rezultatID",
                        column: x => x.rezultatID,
                        principalTable: "Rezultat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utakmica_Sudija_sudijaID",
                        column: x => x.sudijaID,
                        principalTable: "Sudija",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utakmica_Tim_tim1ID",
                        column: x => x.tim1ID,
                        principalTable: "Tim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Utakmica_Tim_tim2ID",
                        column: x => x.tim2ID,
                        principalTable: "Tim",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Igrac");

            migrationBuilder.DropTable(
                name: "LiveStream");

            migrationBuilder.DropTable(
                name: "Notifikacija");

            migrationBuilder.DropTable(
                name: "Premium");

            migrationBuilder.DropTable(
                name: "Utakmica");

            migrationBuilder.DropTable(
                name: "Rezultat");

            migrationBuilder.DropTable(
                name: "Sudija");

            migrationBuilder.DropTable(
                name: "Tim");
        }
    }
}
