using Microsoft.EntityFrameworkCore.Migrations;

namespace CA2ArtGallery1.Data.Migrations
{
    public partial class AddingComboTablePaintArtist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PaintingArtistViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    thisPaintingId = table.Column<int>(type: "int", nullable: true),
                    thisArtistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaintingArtistViewModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaintingArtistViewModel_Artists_thisArtistId",
                        column: x => x.thisArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PaintingArtistViewModel_Paintings_thisPaintingId",
                        column: x => x.thisPaintingId,
                        principalTable: "Paintings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaintingArtistViewModel_thisArtistId",
                table: "PaintingArtistViewModel",
                column: "thisArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingArtistViewModel_thisPaintingId",
                table: "PaintingArtistViewModel",
                column: "thisPaintingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaintingArtistViewModel");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Paintings");
        }
    }
}
