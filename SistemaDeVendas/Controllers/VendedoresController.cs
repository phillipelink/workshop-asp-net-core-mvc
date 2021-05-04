using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaDeVendas.Services;

namespace SistemaDeVendas.Controllers
{
    public class VendedoresController : Controller
    {
        //Declarar dependencia para o VendedorService
        public readonly VendedorService _vendedorService;

        //Criar o construtor para injetar a dependencia

            public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService  = vendedorService;
        }



        public IActionResult Index()
        {
            var lista = _vendedorService.FindAll();
            return View(lista);
        }
    }
}