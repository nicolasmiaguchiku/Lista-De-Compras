
namespace ListaDeCompras.Models
{
    public enum FilterCategory
    {
        Todos,
        Doméstico,
        Material,
        Móvel
    }
    public class Filter
    {
        public string FilterString { get; set; } = string.Empty;
    }
}
