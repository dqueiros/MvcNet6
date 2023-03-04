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
            var lanches = await _lancheService.GetLanchesAsync();
            return View(lanches);
        }
    }
}
