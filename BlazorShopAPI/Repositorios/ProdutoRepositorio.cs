using BlazorShop.Models.DTOs;
using BlazorShopAPI.Contexto;
using Microsoft.EntityFrameworkCore;

namespace BlazorShopAPI.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {

        private readonly BancoContexto bancoContexto;

        public ProdutoRepositorio(BancoContexto b)
        {
            bancoContexto = b;
        }

        public async Task<Entities.Produto> GetItem(int id)
        {
            // var produtos = await bancoContexto.Produtos.FirstAsync(p => p.Id == id);
            var produtos = await bancoContexto.Produtos.Include(x => x.Categoria).SingleOrDefaultAsync(p => p.Id == id);

            return produtos;
        }

        public async Task<IEnumerable<Entities.Produto>> GetItens()
        {
            var produtos = await bancoContexto.Produtos.Include(x => x.Categoria).ToListAsync();
            return produtos;
        }

        public async Task<IEnumerable<Entities.Produto>> GetItensPorCartegoria(int id)
        {
            var produtos = await bancoContexto.Produtos.Include(x => x.Categoria).Where(x => x.Categoria.Id == id).ToListAsync();
            return produtos;
        }
    }
}
