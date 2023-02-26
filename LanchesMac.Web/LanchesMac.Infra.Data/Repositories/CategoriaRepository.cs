
using LanchesMac.Domain.Entities;
using LanchesMac.Domain.Repositories;
using LanchesMac.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Infra.Data.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Categoria>> GetCategoriesAsync()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
