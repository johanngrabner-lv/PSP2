using Microsoft.EntityFrameworkCore.Migrations;

namespace ProduktverwaltungMitEF.Migrations
{
    public partial class InitialCreateV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kategorie",
                table: "MeineProdukte",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kategorie",
                table: "MeineProdukte");
        }
    }
}
