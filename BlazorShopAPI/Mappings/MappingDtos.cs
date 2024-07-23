using BlazorShop.Models.DTOs;
using BlazorShopAPI.Entities;

namespace BlazorShopAPI.Mappings
{
    public static class MappingDtos
    {
        public static IEnumerable<CategoriaDto> ConverterCategoriasParaDto(this IEnumerable<Categoria> categoriaDto)
        {
            return (from c in categoriaDto
                    select new CategoriaDto
                    {
                        Id = c.Id,
                        Nome = c.Nome,
                        IconCSS = c.IconCSS,

                    }).ToList();
        }
        public static IEnumerable<ProdutoDto> ConverterProdutosParaDto(this IEnumerable<Produto> produtoDto)
        {
            return (from p in produtoDto
                    select new ProdutoDto
                    {
                        Id = p.Id,
                        Nome = p.Nome,
                        Descricao = p.Descricao,
                        ImagemUrl = p.ImagemUrl,
                        Preco = p.Preco,
                        Qtd = p.Qtd,
                        CategoriaId = p.CategoriaId,
                        CategoriaNome = p.CategoriaNome,
                    }).ToList();
        }
        public static IEnumerable<CarrinhoItemDto> ConverterCarrinhoItensParaDto(this IEnumerable<CarrinhoItem> carrinhoItemDto, IEnumerable<Produto> produtos)
        {
            return (from c in carrinhoItemDto
                    join produto in produtos
                    on c.ProdutoId equals produto.Id
                    select new CarrinhoItemDto
                    {
                        Id = c.Id,
                        CarrinhoId = c.CarrinhoId,
                        ProdutoId = produto.Id,
                        Qtd = c.Qtd,
                        ProdutoNome = produto.Nome,
                        ProdutoDescricao = produto.Descricao,
                        ProdutoImagemUrl = produto.ImagemUrl,
                        Preco = produto.Preco,
                        PrecoTotal = c.Qtd * produto.Preco,
                    }).ToList();
        }
        public static CarrinhoItemDto ConverterCarrinhoItemParaDto(this CarrinhoItem carrinhoItem, Produto produto)
        {
            return (new CarrinhoItemDto
            {
                Id = carrinhoItem.Id,
                CarrinhoId = carrinhoItem.CarrinhoId,
                ProdutoId = carrinhoItem.ProdutoId,
                Qtd = carrinhoItem.Qtd,
                ProdutoNome = produto.Nome,
                ProdutoDescricao = produto.Descricao,
                ProdutoImagemUrl= produto.ImagemUrl,
                Preco = produto.Preco,
                PrecoTotal = carrinhoItem.Qtd * produto.Preco,
            });
        }
        public static ProdutoDto ConverterProdutoParaDto(this Produto produtoDto)
        {
            return (new ProdutoDto
            {
                Id = produtoDto.Id,
                Nome = produtoDto.Nome,
                Descricao = produtoDto.Descricao,
                ImagemUrl = produtoDto.ImagemUrl,
                Preco = produtoDto.Preco,
                Qtd = produtoDto.Qtd,
                CategoriaId = produtoDto.CategoriaId,
                CategoriaNome = produtoDto.CategoriaNome,
            });
        }
    }
}
