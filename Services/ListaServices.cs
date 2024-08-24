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
            var lista = await _context.Products.OrderBy(p => p.Name).ToListAsync();
            return lista;
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(string category)
        {
            IQueryable<Product> consulta = _context.Products;

            if (category == "Todos")
            {
                return await GetAllProductsAsync();
            }

            if (Enum.TryParse(category, out ProductCategory categoryEnum))
            {
                consulta = consulta.Where(p => p.Category == categoryEnum);
            }
            else
            {
                return new List<Product>();
            }

            return await consulta.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteProductAsync(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task EditProductAsync(Product product)
        {
            var prd = await _context.Products.FindAsync(product.Id);
            if(prd is not null)
            {
                prd.Name = product.Name;
                prd.Price = product.Price;
                prd.Category = product.Category;
                prd.Link = product.Link;
                prd.Bought = product.Bought;
                _context.Update(prd);
            }

            await _context.SaveChangesAsync();
            
        }

        public async Task<Product?> GetProductByIdAsync(int? id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
