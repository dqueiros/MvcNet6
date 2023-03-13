
using LanchesMac.Domain.Entities;

namespace Lanches.Application.Services.Interfaces
{
    public interface ILancheService
    {
        ICollection<Lanche> GetLanches();
        ICollection<Lanche> GetLanchesPreferidos();
        Lanche GetById(int id);
    }
}
