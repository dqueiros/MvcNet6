
using LanchesMac.Domain.Entities;

namespace LanchesMac.Domain.Repositories
{
    public interface ILancheRepository
    {
        Task<ICollection<Lanche>> GetLanchesAsync();
        Task<ICollection<Lanche>> GetLanchesPreferidosAsync();
        Task<Lanche> GetByIdAsync(int id);
    }
}
