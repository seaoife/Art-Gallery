using Microsoft.EntityFrameworkCore.Migrations;

namespace CA2ArtGallery1.Data.Migrations
{
    public partial class ChangeTablePaintingArtistViewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaintingArtistViewModel_Artists_thisArtistId",
                table: "PaintingArtistViewModel");

            migrationBuilder.DropForeignKey(
                name: "FK_PaintingArtistViewModel_Paintings_thisPaintingId",
                table: "PaintingArtistViewModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaintingArtistViewModel",
                table: "PaintingArtistViewModel");

            migrationBuilder.RenameTable(
                name: "PaintingArtistViewModel",
                newName: "PaintingArtistViewModels");

            migrationBuilder.RenameIndex(
                name: "IX_PaintingArtistViewModel_thisPaintingId",
                table: "PaintingArtistViewModels",
                newName: "IX_PaintingArtistViewModels_thisPaintingId");

            migrationBuilder.RenameIndex(
                name: "IX_PaintingArtistViewModel_thisArtistId",
                table: "PaintingArtistViewModels",
                newName: "IX_PaintingArtistViewModels_thisArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaintingArtistViewModels",
                table: "PaintingArtistViewModels",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaintingArtistViewModels_Artists_thisArtistId",
                table: "PaintingArtistViewModels",
                column: "thisArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaintingArtistViewModels_Paintings_thisPaintingId",
                table: "PaintingArtistViewModels",
                column: "thisPaintingId",
                principalTable: "Paintings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaintingArtistViewModels_Artists_thisArtistId",
                table: "PaintingArtistViewModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PaintingArtistViewModels_Paintings_thisPaintingId",
                table: "PaintingArtistViewModels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaintingArtistViewModels",
                table: "PaintingArtistViewModels");

            migrationBuilder.RenameTable(
                name: "PaintingArtistViewModels",
                newName: "PaintingArtistViewModel");

            migrationBuilder.RenameIndex(
                name: "IX_PaintingArtistViewModels_thisPaintingId",
                table: "PaintingArtistViewModel",
                newName: "IX_PaintingArtistViewModel_thisPaintingId");

            migrationBuilder.RenameIndex(
                name: "IX_PaintingArtistViewModels_thisArtistId",
                table: "PaintingArtistViewModel",
                newName: "IX_PaintingArtistViewModel_thisArtistId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaintingArtistViewModel",
                table: "PaintingArtistViewModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaintingArtistViewModel_Artists_thisArtistId",
                table: "PaintingArtistViewModel",
                column: "thisArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaintingArtistViewModel_Paintings_thisPaintingId",
                table: "PaintingArtistViewModel",
                column: "thisPaintingId",
                principalTable: "Paintings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
