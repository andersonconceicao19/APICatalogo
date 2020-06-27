using APICatalogo.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Data.Context
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
