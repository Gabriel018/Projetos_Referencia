using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prover_Web.Models;

namespace Login.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Adm> Adm { get; set; } 
        public DbSet<Cliente> Cliente  { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
    }
}