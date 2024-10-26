using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Venda.Migrations
{
    /// <inheritdoc />
    public partial class addProduto2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nomeProduto = table.Column<string>(type: "TEXT", nullable: false),
                    tipoProduto = table.Column<string>(type: "TEXT", nullable: true),
                    valorProduto = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
