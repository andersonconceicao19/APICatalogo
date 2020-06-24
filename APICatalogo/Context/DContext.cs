using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.DataContext
{
    public class DContext : DbContext
    {
        public DContext(DbContextOptions<DContext> options) : base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
