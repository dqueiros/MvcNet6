using Lanches.Application.Services.Interfaces;
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

        public async Task<IActionResult> List()
        {
            //var lanches = await _lancheService.GetLanchesAsync();
            //return View(lanches);

            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = await _lancheService.GetLanchesAsync();
            lancheListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheListViewModel);
        }
    }
}
