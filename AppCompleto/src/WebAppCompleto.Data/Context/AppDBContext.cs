using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCompleto.Businnes.Models;

namespace WebAppCompleto.Data.Context
{
   public class AppDBContext: DbContext
    {

        public AppDBContext(DbContextOptions options) : base(options)
        {

        }

        public  DbSet<Cliente> Clientes { get; set; }
        public  DbSet<Produto> Produtos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDBContext).Assembly);


            base.OnModelCreating (modelBuilder);
        }
    }
}
