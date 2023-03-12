using Lanches.Application.Services.Interfaces;
using LanchesMac.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Web.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheService _lancheService;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(ILancheService lancheService, CarrinhoCompra carrinhoCompra)
        {
            _lancheService = lancheService;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
