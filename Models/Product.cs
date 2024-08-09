using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ListaDeCompras.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto obrigatório.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Valor do produto obrigatório.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Categoria do produto obrigatório.")]
        public string? CategoryId { get; set; }

        [ValidateNever]
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Link do produto obrigatório.")]
        public string? Link { get; set; }

        public bool Bought { get; set; }

    }
}
