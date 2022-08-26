using Microsoft.EntityFrameworkCore.Migrations;

namespace CA2ArtGallery1.Data.Migrations
{
    public partial class AlterTextAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateText",
                table: "Paintings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateText",
                table: "Paintings");
        }
    }
}
