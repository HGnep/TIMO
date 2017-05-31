using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace C.Migrations
{
    public partial class RelatiesUren : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Relaties",
                columns: table => new
                {
                    RelatieId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Achternaam = table.Column<string>(nullable: false),
                    Geboortedatum = table.Column<DateTime>(nullable: false),
                    Huisnummer = table.Column<int>(nullable: false),
                    Klas = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: false),
                    Straat = table.Column<string>(nullable: false),
                    Toevoeging = table.Column<string>(nullable: true),
                    Tussenvoegsel = table.Column<string>(nullable: true),
                    Voornaam = table.Column<string>(nullable: true),
                    Woonplaats = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relaties", x => x.RelatieId);
                });

            migrationBuilder.CreateTable(
                name: "Uren",
                columns: table => new
                {
                    UurId = table.Column<int>(nullable: false)
                        .Annotation("Autoincrement", true),
                    Begintijd = table.Column<DateTime>(nullable: false),
                    Eindtijd = table.Column<DateTime>(nullable: false),
                    RelatieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uren", x => x.UurId);
                    table.ForeignKey(
                        name: "FK_Uren_Relaties_RelatieId",
                        column: x => x.RelatieId,
                        principalTable: "Relaties",
                        principalColumn: "RelatieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uren_RelatieId",
                table: "Uren",
                column: "RelatieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uren");

            migrationBuilder.DropTable(
                name: "Relaties");
        }
    }
}
