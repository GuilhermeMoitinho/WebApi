using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Identity.Data
{
    public class IdentityDataContext : IdentityDbContext
    {

        public IdentityDataContext()
        {
            
        }
        public IdentityDataContext(DbContextOptions<IdentityDataContext> options) : base(options) { }
    }
}
