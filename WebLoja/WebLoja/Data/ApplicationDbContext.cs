using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebLoja.Models;

namespace WebLoja.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }









        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Venda>()
              .HasOne(v => v.Vendedor)
              .WithMany(v => v.Vendas)
              .HasForeignKey(v => v.VendedorId);

            modelBuilder.Entity<Venda>()
            .HasOne(v => v.Produto)
            .WithMany(p => p.Vendas)
            .HasForeignKey(v => v.ProdutoId);


            base.OnModelCreating(modelBuilder);
        }
    }
}
