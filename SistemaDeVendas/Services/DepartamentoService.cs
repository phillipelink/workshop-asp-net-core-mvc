using SistemaDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



/// <summary>
/// Aqui no Service a gente injeta as dependencias do DBContext (banco de dados) para que possamos fazer as consultas pra tabelas no banco (isso poderia ser feito direto na controller, porém não seria uma boa pratica).
/// </summary>
namespace SistemaDeVendas.Services
{
    public class DepartamentoService
    {


        //Declarar dependencia para o dbcontext
        // Boa pratica é colocar o readonly para previnir que essa dependencia não seja alterada.
        private readonly SistemaDeVendasContext _context;

        //Injeção da dependencia
        public DepartamentoService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAllDepartaments()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }


    }


}
