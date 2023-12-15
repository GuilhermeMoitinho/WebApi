using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<Alien> Aliens { get; set; }
    }
}