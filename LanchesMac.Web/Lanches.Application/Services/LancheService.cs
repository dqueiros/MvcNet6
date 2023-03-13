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

        public Lanche GetById(int id)
        {
            return _lancheRepository.GetById(id);
        }

        public ICollection<Lanche> GetLanches()
        {
            return _lancheRepository.GetLanches();
        }

        public ICollection<Lanche> GetLanchesPreferidos()
        {
            return _lancheRepository.GetLanchesPreferidos();
        }
    }
}
