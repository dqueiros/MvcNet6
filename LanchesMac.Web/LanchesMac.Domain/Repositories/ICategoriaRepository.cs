using LanchesMac.Domain.Entities;

namespace LanchesMac.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        ICollection<Categoria> GetCategoriesAsync();
    }
}
