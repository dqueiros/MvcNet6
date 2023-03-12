using Lanches.Application.Services.Interfaces;
using LanchesMac.Web.Models;
using LanchesMac.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanchesMac.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheService _lancheService;

        public HomeController(ILancheService lancheService)
        {
            _lancheService = lancheService;
        }

        public async Task<IActionResult> Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = await _lancheService.GetLanchesPreferidosAsync()
            };

            return View(homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}