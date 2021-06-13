using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteka_WebApplication.Migrations
{
    public partial class InitzialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gatunek",
                columns: table => new
                {
                    GatunekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gatunek", x => x.GatunekId);
                });

            migrationBuilder.CreateTable(
                name: "Książka",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tytul = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nazwisko = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wydawnictwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiczbaStron = table.Column<long>(type: "bigint", nullable: false),
                    Ebook = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Książka", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Użytkownik",
                columns: table => new
                {
                    UzytkownikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hasło = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Użytkownik", x => x.UzytkownikId);
                });

            migrationBuilder.CreateTable(
                name: "GatunekKsiazka",
                columns: table => new
                {
                    GatunekId = table.Column<int>(type: "int", nullable: false),
                    KsiazkiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GatunekKsiazka", x => new { x.GatunekId, x.KsiazkiId });
                    table.ForeignKey(
                        name: "FK_GatunekKsiazka_Gatunek_GatunekId",
                        column: x => x.GatunekId,
                        principalTable: "Gatunek",
                        principalColumn: "GatunekId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GatunekKsiazka_Książka_KsiazkiId",
                        column: x => x.KsiazkiId,
                        principalTable: "Książka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wypozyczenia",
                columns: table => new
                {
                    WypozyczenieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataWypozyczenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataOddania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KsiazkaID = table.Column<int>(type: "int", nullable: false),
                    UzytkownikID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wypozyczenia", x => x.WypozyczenieId);
                    table.ForeignKey(
                        name: "FK_Wypozyczenia_Książka_KsiazkaID",
                        column: x => x.KsiazkaID,
                        principalTable: "Książka",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wypozyczenia_Użytkownik_UzytkownikID",
                        column: x => x.UzytkownikID,
                        principalTable: "Użytkownik",
                        principalColumn: "UzytkownikId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GatunekKsiazka_KsiazkiId",
                table: "GatunekKsiazka",
                column: "KsiazkiId");

            migrationBuilder.CreateIndex(
                name: "IX_Wypozyczenia_KsiazkaID",
                table: "Wypozyczenia",
                column: "KsiazkaID");

            migrationBuilder.CreateIndex(
                name: "IX_Wypozyczenia_UzytkownikID",
                table: "Wypozyczenia",
                column: "UzytkownikID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GatunekKsiazka");

            migrationBuilder.DropTable(
                name: "Wypozyczenia");

            migrationBuilder.DropTable(
                name: "Gatunek");

            migrationBuilder.DropTable(
                name: "Książka");

            migrationBuilder.DropTable(
                name: "Użytkownik");
        }
    }
}
