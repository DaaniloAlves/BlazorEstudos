using BlazorShop.Models.DTOs;
using BlazorShopAPI.Mappings;
using BlazorShopAPI.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShopAPI.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutosController(IProdutoRepositorio p)
        {
            _produtoRepositorio = p;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItems()
        {
            try
            {
                var produtos = await _produtoRepositorio.GetItens();
                if (produtos == null)
                {
                    return NotFound("Produto não localizado");
                }
                var produtoDtos = produtos.ConverterProdutosParaDto();
                return Ok(produtoDtos);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItem(int id)
        {
            try
            {
                var produto = await _produtoRepositorio.GetItem(id);
                if (produto == null)
                {
                    return NotFound("Produto não localizado");
                }
                var produtoDto = produto.ConverterProdutoParaDto();
                return Ok(produtoDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetItensPorCategoria(int categoriaId)
        {
            try
            {
                var produtos = await _produtoRepositorio.GetItensPorCartegoria(categoriaId);
                if(produtos == null)
                {
                    return NotFound("Produto não localizado");
                }
                var produtosDto = produtos.ConverterProdutosParaDto();
                return Ok(produtosDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao acessar a base de dados");
            }
        }


    }
}
