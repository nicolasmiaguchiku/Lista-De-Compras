using Microsoft.EntityFrameworkCore;
using ListaDeCompras.Models;

namespace ListaDeCompras.Context
{
    public class ListaContext : DbContext
    {
        public ListaContext(DbContextOptions<ListaContext> options) : base (options)
        {

        }

        public DbSet<Product> Products { get; set; }
        
    }
}
