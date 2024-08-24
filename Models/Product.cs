using System.ComponentModel.DataAnnotations;

namespace ListaDeCompras.Models
{

    public enum ProductCategory
    {
        Nenhum,
        Doméstico,
        Material,
        Móvel
    }

    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome do produto é obrigatório.")]
        public string? Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Valor do produto é obrigatório")]
        public double Price { get; set; }

        [CategoryRequired(ErrorMessage = "Categoria do produto é obrigatório.")]
        public ProductCategory Category { get; set; }

        [Required(ErrorMessage = "Link do produto é obrigatório.")]
        public string? Link { get; set; }

        public bool Bought { get; set; }

    }
}
