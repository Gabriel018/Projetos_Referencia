using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCompleto.Businnes.Models;

namespace WebAppCompleto.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
            builder.ToTable("Produtos");
        }
    }
}
