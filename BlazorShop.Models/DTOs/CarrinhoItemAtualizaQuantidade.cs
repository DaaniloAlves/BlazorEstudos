using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    internal class CarrinhoItemAtualizaQuantidade
    {
        public int CarrinhoItemId { get; set; }
        public int Qtd {  get; set; }
    }
}
