using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShopAPI.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qtd = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Qtd = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IconCSS", "Nome" },
                values: new object[] { 1, "fas fa-spa", "Beleza" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Danilo" });

            migrationBuilder.InsertData(
                table: "Carrinhos",
                columns: new[] { "Id", "UsuarioId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemUrl", "Nome", "Preco", "Qtd" },
                values: new object[,]
                {
                    { 1, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza kit", 100m, 100 },
                    { 2, 1, "Um kit fornecido pela Curology, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza2.png", "Curology - Kit para pele", 100m, 100 },
                    { 3, 1, "Um kit fornecido pela Glossier, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza3.png", "Oleo de coco organico", 100m, 100 },
                    { 4, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza4.png", "Schwarkopf - kit de cuidados com a pele e cabelo", 100m, 100 },
                    { 5, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza kit", 100m, 100 },
                    { 6, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza kit", 100m, 100 },
                    { 7, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza kit", 100m, 100 },
                    { 8, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza kit", 100m, 100 },
                    { 9, 1, "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele", "/Imagens/Beleza/Beleza1.png", "Glossier - Beleza kit", 100m, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_CarrinhoId",
                table: "CarrinhoItens",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ProdutoId",
                table: "CarrinhoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
