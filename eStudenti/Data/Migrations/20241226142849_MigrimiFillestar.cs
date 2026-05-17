using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eStudenti.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrimiFillestar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studentet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emri = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Mbiemri = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Gjinia = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Vendlindja = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Vendbanimi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Shteti = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DataLindjes = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumriTelefonit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biografia = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentet");
        }
    }
}
