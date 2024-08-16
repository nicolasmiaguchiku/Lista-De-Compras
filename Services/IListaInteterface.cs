using ListaDeCompras.Models;
using System.Threading.Tasks;

namespace ListaDeCompras.Services
{
    public interface IListaInterface
    {
        Task<List<Product>> GetAllProductsAsync();

        Task AddProductAsync(Product product);

        Task DeleteProductAsync(int id);

    }
}
