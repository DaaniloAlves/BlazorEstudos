using BlazorShopAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopAPI.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        public DbSet<Carrinho> Carrinhos { get; set; }
        public DbSet<CarrinhoItem> CarrinhoItens { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 1,
                Nome = "Beleza",
                IconCSS = "fas fa-spa"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 1,
                Nome = "Glossier - Beleza kit",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 2,
                Nome = "Curology - Kit para pele",
                Descricao = "Um kit fornecido pela Curology, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza2.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 3,
                Nome = "Oleo de coco organico",
                Descricao = "Um kit fornecido pela Glossier, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza3.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 4,
                Nome = "Schwarkopf - kit de cuidados com a pele e cabelo",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza4.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 5,
                Nome = "Glossier - Beleza kit",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 6,
                Nome = "Glossier - Beleza kit",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 7,
                Nome = "Glossier - Beleza kit",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 8,
                Nome = "Glossier - Beleza kit",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                Id = 9,
                Nome = "Glossier - Beleza kit",
                Descricao = "Um kit fornecido pela Natura, contendo produtos para cuidados com a pele",
                ImagemUrl = "/Imagens/Beleza/Beleza1.png",
                Preco = 100,
                Qtd = 100,
                CategoriaId = 1
            });
            modelBuilder.Entity<Usuario>().HasData(new Usuario
            {
                Id = 1,
                Nome = "Danilo"
            });
            modelBuilder.Entity<Carrinho>().HasData(new Carrinho
            {
                Id = 1,
                UsuarioId = 1
            });
        }
    }
}
