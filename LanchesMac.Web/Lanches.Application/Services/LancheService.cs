using Lanches.Application.Services.Interfaces;
using LanchesMac.Domain.Entities;
using LanchesMac.Domain.Repositories;

namespace Lanches.Application.Services
{
    public class LancheService : ILancheService
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheService(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public async Task<ICollection<Lanche>> GetLanchesAsync()
        {
            return await _lancheRepository.GetLanchesAsync();
        }
    }
}
