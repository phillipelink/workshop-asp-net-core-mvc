using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Models;
using SistemaDeVendas.Models.ViewModels;
using SistemaDeVendas.Services;

namespace SistemaDeVendas.Controllers
{
    public class VendedoresController : Controller
    {
        //Declarar dependencia para o VendedorService
        public readonly VendedorService _vendedorService;
        public readonly DepartamentoService _departamentoService;

        //Criar o construtor para injetar a dependencia
        public VendedoresController(VendedorService vendedorService, DepartamentoService departamentoService)
        {
            _vendedorService  = vendedorService;
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var lista = _vendedorService.FindAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            var departamentos = _departamentoService.FindAllDepartaments();
            var viewModel = new VendedorFormViewModel { Departamentos = departamentos };
            return View(viewModel);
        }

        [HttpPost]
        //Previne ataque CSRF
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vendedor vendedor)
        {
            _vendedorService.Inserir(vendedor);
            return RedirectToAction(nameof(Index));
        }    
        
    }
}