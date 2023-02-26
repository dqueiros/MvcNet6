using Lanches.Application.Services;
using Lanches.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.IoC
{
    internal static class ServicosAplicacao
    {
        internal static void Registra(IServiceCollection servCol)
        {
            //TODO: registrar aqui as interfaces de serviço da camada de aplicação 
            //Exemplo:
            servCol.AddScoped<ICategoriaService, CategoriaService>();
            servCol.AddScoped<ILancheService, LancheService>();
        }
    }
}
