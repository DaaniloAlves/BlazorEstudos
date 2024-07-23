using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop.Models.DTOs
{
    public class CategoriaDto
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty;

        public string IconCSS { get; set; } = string.Empty;

    }
}
