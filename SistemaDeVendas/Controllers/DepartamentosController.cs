using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemaDeVendas.Models;
using SistemaDeVendas.Services;


/// <summary>
/// Aqui na Controller a gente injeta as dependencias do serviço para que possamos chamar as funções daquele serviço.
/// </summary>
namespace SistemaDeVendas.Controllers
{
    public class DepartamentosController : Controller
    {
        //Declarar dependencia para o VendedorService
        public readonly DepartamentoService _departamentoService;

        //Criar o construtor para injetar a dependencia
        public DepartamentosController(DepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        public IActionResult Index()
        {
            var lista = _departamentoService.FindAllDepartaments();
            return View(lista);
        }
    }
}
