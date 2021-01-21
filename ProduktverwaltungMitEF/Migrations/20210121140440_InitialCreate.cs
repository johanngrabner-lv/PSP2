using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduktverwaltungMitEF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeineProdukte",
                columns: table => new
                {
                    ProduktId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bezeichnung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preis = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeineProdukte", x => x.ProduktId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeineProdukte");
        }
    }
}
