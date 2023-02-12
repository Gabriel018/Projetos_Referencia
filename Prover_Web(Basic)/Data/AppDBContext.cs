using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Prover_Web.Models;

namespace Prover_Web.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
            public DbSet<Adm> Adm { get; set; }
            public DbSet<Vendedor> Vendedor { get; set; }
            public DbSet<Cliente> Cliente { get; set; }
        }
    }


