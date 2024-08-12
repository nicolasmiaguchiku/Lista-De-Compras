using ListaDeCompras.Models;
using System.Threading.Tasks;

namespace ListaDeCompras.Services
{
    public interface IListaInterface
    {
        public Task<List<Product>> GetAllProductsAsync();

        public Task AddProductAsync(Product product);

        public Task DeleteProduct(int id);

    }
}
