using Application.Services;
using ApiBen10.DataContext;
using ApiBen10.Interfaces;
using Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Services;
using Microsoft.AspNetCore.Identity;
using Alien.Application.Interfaces;
using Alien.Identity.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NativeInjectConfig
    {
        public static void AddRegisteredServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<IdentityDataContext>
                (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<IdentityDataContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IAlienService, AlienService>();
            services.AddScoped<IAlienApplication, AlienApplication>();
        }
    }
}
