using SistemaDeVendas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeVendas.Services
{
    public class VendedorService
    {

        //Declarar dependencia para o dbcontext
        // Boa pratica é colocar o readonly para previnir que essa dependencia não seja alterada.

        private readonly SistemaDeVendasContext _context;

        public VendedorService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }






    }
}
