using Application.Services;
using ApiBen10.DataContext;
using ApiBen10.Interfaces;
using Identity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Services;

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

            services.AddScoped<IAlienService, AlienService>();
            services.AddScoped<IAlienApplication, AlienApplication>();
        }
    }
}
