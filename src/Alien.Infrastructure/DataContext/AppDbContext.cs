using ApiBen10.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBen10.DataContext
{
    public class AppDbContext : DbContext
    {
         public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { 
        }

        public DbSet<AlienModel> Aliens { get; set; }
    }
}