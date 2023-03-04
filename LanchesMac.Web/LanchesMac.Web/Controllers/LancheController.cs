using Lanches.Application.Services.Interfaces;
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
            ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            var lanches = await _lancheService.GetLanchesAsync();
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total de lanches : ";
            ViewBag.TotalLanches = totalLanches;


            return View(lanches);
        }
    }
}
