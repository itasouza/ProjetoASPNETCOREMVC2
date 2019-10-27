using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoAlbumFotos.Migrations
{
    public partial class AtualizaBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Albuns_AlbumId",
                table: "Imagens");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Albuns_AlbumId",
                table: "Imagens",
                column: "AlbumId",
                principalTable: "Albuns",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Albuns_AlbumId",
                table: "Imagens");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Albuns_AlbumId",
                table: "Imagens",
                column: "AlbumId",
                principalTable: "Albuns",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
