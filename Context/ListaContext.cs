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
        public DbSet<Category> Categories{ get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "Movel", CategoryName = "Movel" },
                new Category { CategoryId = "Material", CategoryName = "Material" },
                new Category { CategoryId = "Domestico", CategoryName = "Doméstico" }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
