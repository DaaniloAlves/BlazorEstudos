

using BlazorShopAPI.Entities;

namespace BlazorShopAPI.Repositorios
{
    public interface IProdutoRepositorio
    {
        Task<IEnumerable<Entities.Produto>> GetItens();
        Task<Produto> GetItem(int id);
        Task<IEnumerable<Produto>> GetItensPorCartegoria(int id);


    }
}
