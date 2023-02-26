
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

        public async Task<Lanche> GetByIdAsync(int id)
        {
            return await _context.Lanches.FirstOrDefaultAsync(x => x.LancheId == id);
        }

        public async Task<ICollection<Lanche>> GetLanchesAsync()
        {
            return await _context.Lanches
                .Include(c => c.Categoria)
                .ToListAsync();
        }

        public async Task<ICollection<Lanche>> GetLanchesPreferidosAsync()
        {
            return await _context.Lanches
                .Where(p => p.IsLanchePreferido)
                .Include(c => c.Categoria).ToListAsync();
        }
    }
}
