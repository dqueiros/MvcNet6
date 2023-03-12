
using LanchesMac.Domain.Entities;

namespace Lanches.Application.Services.Interfaces
{
    public interface ILancheService
    {
        Task<ICollection<Lanche>> GetLanchesAsync();
        Task<ICollection<Lanche>> GetLanchesPreferidosAsync();
    }
}
