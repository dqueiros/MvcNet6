using LanchesMac.Domain.Entities;

namespace LanchesMac.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<ICollection<Categoria>> GetCategoriesAsync();
    }
}
