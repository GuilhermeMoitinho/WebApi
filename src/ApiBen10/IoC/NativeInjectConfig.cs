using Application.Services;
using ApiBen10.DataContext;
using ApiBen10.Interfaces;
using Microsoft.EntityFrameworkCore;
using Services;
using Microsoft.AspNetCore.Identity;
using Alien.Application.Interfaces;
using Alien.Infrastructure.DataContext;
using Alien.Application.Auth.AuthService;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class NativeInjectConfig
    {
        public static void AddRegisteredServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>
                (op => op.UseSqlServer(configuration.GetConnectionString("ConexaoPadrao")));

            services.AddDbContext<UserAppDbContext>
                (op => op.UseInMemoryDatabase("UserDb"));


            services.AddScoped<IAlienService, AlienService>();
            services.AddScoped<IAlienApplication, AlienApplication>();
            services.AddScoped<TokenService>();
        }
    }
}
