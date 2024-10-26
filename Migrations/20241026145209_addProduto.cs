using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Venda.Migrations
{
    /// <inheritdoc />
    public partial class addProduto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    usuario = table.Column<string>(type: "TEXT", nullable: false),
                    senha = table.Column<string>(type: "TEXT", nullable: false),
                    sexo = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
