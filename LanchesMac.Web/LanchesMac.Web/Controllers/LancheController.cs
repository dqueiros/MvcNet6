using Lanches.Application.Services.Interfaces;
using LanchesMac.Domain.Entities;
using LanchesMac.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Web.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheService _lancheService;

        public LancheController(ILancheService lancheService)
        {
            _lancheService = lancheService;
        }

        public async Task<IActionResult> List(string categoria)
        {
            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                lanches = (await _lancheService.GetLanchesAsync()).OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {
                lanches = (await _lancheService.GetLanchesAsync())
                         .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                         .OrderBy(l => l.Nome);

                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }
    }
}
