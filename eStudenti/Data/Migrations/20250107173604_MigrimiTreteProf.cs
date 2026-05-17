using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eStudenti.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrimiTreteProf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profesoret",
                columns: table => new
                {
                    ProfId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfEmri = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfMbiemri = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfGjinia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProfDataLindjes = table.Column<DateTime>(type: "datetime2", maxLength: 15, nullable: false),
                    ProfNumriTelefonit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitulliAkademik = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesoret", x => x.ProfId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profesoret");
        }
    }
}
