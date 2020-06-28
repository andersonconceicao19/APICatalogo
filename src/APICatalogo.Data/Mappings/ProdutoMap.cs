using APICatalogo.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace APICatalogo.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(50)");
            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.HasOne(p => p.Categoria)
                .WithMany(c => c.Produto)
                .HasForeignKey(x => x.CategoriaId);


        }
    }
}
