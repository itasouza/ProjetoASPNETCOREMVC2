using Microsoft.EntityFrameworkCore.Migrations;

namespace IntermediarioUmParaVariosFluentAPI.Migrations
{
    public partial class AjusteBancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Empregados",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Empregados");
        }
    }
}
