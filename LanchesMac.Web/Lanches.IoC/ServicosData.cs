
using LanchesMac.Domain.Repositories;
using LanchesMac.Infra.Data.Context;
using LanchesMac.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.IoC
{
    internal static class ServicosData
    {
        internal static void Registra(IServiceCollection servCol)
        { 
            #region SQL Server
            servCol.AddDbContext<AppDbContext>(ServiceLifetime.Scoped);
            #endregion

            //TODO: registrar aqui as interfaces de repositório e DAO
            //Exemplo:
            servCol.AddScoped<ICategoriaRepository, CategoriaRepository>();
            servCol.AddScoped<ILancheRepository, LancheRepository>();

        }
    }
}
