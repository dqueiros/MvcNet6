
using LanchesMac.Domain.Entities;
using LanchesMac.Domain.Repositories;
using LanchesMac.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Infra.Data.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository (AppDbContext context)
        {
            _context = context;
        }

        public Lanche GetById(int id)
        {
            return _context.Lanches.FirstOrDefault(x => x.LancheId == id);
        }

        public ICollection<Lanche> GetLanches()
        {
            return _context.Lanches
                .Include(c => c.Categoria)
                .ToList();
        }

        public ICollection<Lanche> GetLanchesPreferidos()
        {
            return _context.Lanches
                .Where(p => p.IsLanchePreferido)
                .Include(c => c.Categoria).ToList();
        }
    }
}
