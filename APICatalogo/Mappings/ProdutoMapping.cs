using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace APICatalogo.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(pk => pk.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(40)");
            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(200)");
            builder.Property(p => p.Estoque)
                .IsRequired()
                .HasColumnType("varchar(4)");
            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produto)
                .HasForeignKey(x => x.CategoriaId);
        }
    }
}


