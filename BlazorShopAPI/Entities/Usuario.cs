﻿using System.ComponentModel.DataAnnotations;

namespace BlazorShopAPI.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        public Carrinho? Carrinho { get; set; }
    }
}
