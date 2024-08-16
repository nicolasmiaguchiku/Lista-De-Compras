using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ListaDeCompras.Models
{

    public enum ProductCategory
    {
        Doméstico = 1,
        Material = 2,
        Móvel = 3
    }

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto obrigatório.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Valor do produto obrigatório.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Categoria do produto obrigatório.")]
        public ProductCategory Category { get; set; } = default(ProductCategory);

        [Required(ErrorMessage = "Link do produto obrigatório.")]
        public string? Link { get; set; }

        public bool Bought { get; set; }

    }
}
