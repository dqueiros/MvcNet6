﻿using Lanches.Application.Services.Interfaces;
using LanchesMac.Web.Models;
using LanchesMac.Web.ViewModels;
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
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        public async Task<IActionResult> AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheService.GetLanches().FirstOrDefault(p => p.LancheId == lancheId);

            if (lancheSelecionado != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveItemDoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheService.GetLanches().FirstOrDefault(p => p.LancheId == lancheId);

            if(lancheSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
