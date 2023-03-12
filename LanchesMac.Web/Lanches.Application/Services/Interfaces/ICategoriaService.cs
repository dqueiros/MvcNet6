
using LanchesMac.Domain.Entities;

namespace Lanches.Application.Services.Interfaces
{
    public interface ICategoriaService
    {
        ICollection<Categoria> GetCategoriesAsync();
    }
}
