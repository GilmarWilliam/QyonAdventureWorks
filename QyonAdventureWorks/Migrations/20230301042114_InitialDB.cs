using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QyonAdventureWorks.Api.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competidores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    TemperaturaMediaCorpo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competidores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PistaCorrida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PistaCorrida", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoCorrida",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetidorId = table.Column<int>(type: "int", nullable: false),
                    PistaCorridaId = table.Column<int>(type: "int", nullable: false),
                    DataCorrida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TempoGasto = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoCorrida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoricoCorrida_Competidores_CompetidorId",
                        column: x => x.CompetidorId,
                        principalTable: "Competidores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoricoCorrida_PistaCorrida_PistaCorridaId",
                        column: x => x.PistaCorridaId,
                        principalTable: "PistaCorrida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCorrida_CompetidorId",
                table: "HistoricoCorrida",
                column: "CompetidorId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoCorrida_PistaCorridaId",
                table: "HistoricoCorrida",
                column: "PistaCorridaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoricoCorrida");

            migrationBuilder.DropTable(
                name: "Competidores");

            migrationBuilder.DropTable(
                name: "PistaCorrida");
        }
    }
}
