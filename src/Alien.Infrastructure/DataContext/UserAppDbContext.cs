using Api_Ben10.Domain.Entities;
using ApiBen10.DataContext;
using ApiBen10.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alien.Infrastructure.DataContext
{
    public class UserAppDbContext : DbContext
    {
        public UserAppDbContext(DbContextOptions<UserAppDbContext> options)
           : base(options)
        {
        }

        public DbSet<AlienUser> User { get; set; }
    }
}
