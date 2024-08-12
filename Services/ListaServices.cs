using ListaDeCompras.Context;
using ListaDeCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeCompras.Services
{
    public class ListaServices : IListaInterface
    {
        private readonly ListaContext _context;

        public ListaServices(ListaContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            var lista = await _context.Products.ToListAsync();
            return lista;
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteProduct(int id)
        {
            var prd = _context.Products.Find(id);

            _context.Remove(prd);
            await _context.SaveChangesAsync();

        }
    }
}
