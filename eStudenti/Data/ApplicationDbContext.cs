using eStudenti.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eStudenti.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Studentet> Studentet
        {
            get; set;
        }

        public DbSet<Kurset> Kurset
        {
            get; set;
        }

        public DbSet<Profesoret> Profesoret 
        {
            get; set; 
        }

    }
}
