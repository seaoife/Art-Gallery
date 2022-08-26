using Microsoft.EntityFrameworkCore.Migrations;

namespace CA2ArtGallery1.Data.Migrations
{
    public partial class AddedInstanceOfArtistToPainting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Artists_ArtistId",
                table: "Paintings",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Artists_ArtistId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings");
        }
    }
}
