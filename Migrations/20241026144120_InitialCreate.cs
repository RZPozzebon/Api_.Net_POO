using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api_Venda.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rua = table.Column<string>(type: "TEXT", nullable: true),
                    Bairro = table.Column<string>(type: "TEXT", nullable: true),
                    CEP = table.Column<string>(type: "TEXT", nullable: true),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    pontoReferencia = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoCliente = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    CNPJ = table.Column<string>(type: "TEXT", nullable: true),
                    email = table.Column<string>(type: "TEXT", nullable: true),
                    telefone = table.Column<string>(type: "TEXT", nullable: true),
                    enderecoId = table.Column<int>(type: "INTEGER", nullable: true),
                    sexo = table.Column<char>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.id);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_enderecoId",
                        column: x => x.enderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_enderecoId",
                table: "Cliente",
                column: "enderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
