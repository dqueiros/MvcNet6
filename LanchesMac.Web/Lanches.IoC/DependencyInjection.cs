using Lanches.Application.Services.Interfaces;
using Lanches.Application.Services;
using LanchesMac.Domain.Repositories;
using LanchesMac.Infra.Data.Context;
using LanchesMac.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                                 options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ILancheRepository, LancheRepository>();

            return services;
        }

        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<ILancheService, LancheService>();
            
            return services;
        }
    }
}
