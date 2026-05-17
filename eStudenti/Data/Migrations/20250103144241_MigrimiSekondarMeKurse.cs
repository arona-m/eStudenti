using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eStudenti.Data.Migrations
{
    /// <inheritdoc />
    public partial class MigrimiSekondarMeKurse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurset",
                columns: table => new
                {
                    KursiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmriKursit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ligjerusi = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Kredit = table.Column<int>(type: "int", precision: 3, scale: 6, nullable: false),
                    Statusi = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurset", x => x.KursiId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kurset");
        }
    }
}
