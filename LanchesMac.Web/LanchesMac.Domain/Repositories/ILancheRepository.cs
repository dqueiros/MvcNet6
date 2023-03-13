
using LanchesMac.Domain.Entities;

namespace LanchesMac.Domain.Repositories
{
    public interface ILancheRepository
    {
        ICollection<Lanche> GetLanches();
        ICollection<Lanche> GetLanchesPreferidos();
        Lanche GetById(int id);
    }
}
