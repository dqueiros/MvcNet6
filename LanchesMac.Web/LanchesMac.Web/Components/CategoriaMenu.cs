using Lanches.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Web.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaMenu(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaService.GetCategoriesAsync().OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}
