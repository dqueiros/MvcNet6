using Microsoft.Extensions.DependencyInjection;

namespace Lanches.IoC
{
    internal static class ServicosAplicacao
    {
        internal static void Registra(IServiceCollection servCol)
        {
            //TODO: registrar aqui as interfaces de serviço da camada de aplicação 
            //Exemplo:
            //servCol.AddScoped<IAimAplServico, AimAplServico>();
        }
    }
}
