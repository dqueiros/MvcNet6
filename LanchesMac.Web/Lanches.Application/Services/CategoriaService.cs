using Lanches.Application.Services.Interfaces;
using LanchesMac.Domain.Entities;
using LanchesMac.Domain.Repositories;

namespace Lanches.Application.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public ICollection<Categoria> GetCategoriesAsync()
        {
            return _categoriaRepository.GetCategoriesAsync();
        }
    }
}
