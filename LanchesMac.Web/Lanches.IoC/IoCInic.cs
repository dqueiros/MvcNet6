
using Microsoft.Extensions.DependencyInjection;

namespace Lanches.IoC
{
    public static class IoCInic
    {
        public static IServiceCollection AdicionaInversaoDeControle(this IServiceCollection servicos)
        {
            ServicosAplicacao.Registra(servicos);
            ServicosData.Registra(servicos);

            return servicos;
        }
    }
}
