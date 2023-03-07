using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppCompleto.Businnes.Models;

namespace WebAppCompleto.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
            builder.Property(p => p.Endereço)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
            builder.Property(p => p.Telefene)
                .IsRequired()
                .HasColumnType("nvarchar(100)");
            builder.ToTable("Clientes");
        }

        
    }
}
