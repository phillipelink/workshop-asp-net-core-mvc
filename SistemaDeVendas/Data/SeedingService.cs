using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaDeVendas.Models;
using SistemaDeVendas.Models.Enums;

namespace SistemaDeVendas.Data
{
    public class SeedingService
    {
        private SistemaDeVendasContext _context;

        public  SeedingService(SistemaDeVendasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departamento.Any() || _context.Vendedor.Any() || _context.Vendas.Any())
            {
                return; //Já existem dados nessas tabelas
            }

            //Departamentos
            Departamento d1 = new Departamento (1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletronicos");
            Departamento d3 = new Departamento(3, "Babys");
            Departamento d4 = new Departamento(4, "Livros");
            Departamento d5 = new Departamento(5, "Cachorros");

            //Vendedores

            Vendedor v1 = new Vendedor(1, "Phillipe Marinho", "phillipe.marinho@gmail.com", new DateTime(2021, 02, 24), 3500.0, d1);
            Vendedor v2 = new Vendedor(2, "Jackciele Cardoso", "jackciele.cardoso@gmail.com", new DateTime(2021, 01, 01), 3600.0, d2);
            Vendedor v3 = new Vendedor(3, "Pedro Cardoso Marinho Guimarães Pinheiro", "pedrinhodepainho@gmail.com", new DateTime(2021, 03, 24), 4000.0, d3);
            Vendedor v4 = new Vendedor(4, "Lucky", "luckyinhodepainho@gmail.com", new DateTime(2019, 08, 29), 9000.0, d5);

            //Vendas

            RegistroDeVendas r1 = new RegistroDeVendas(1, new DateTime(2021, 04, 12), 230.0, StatusVenda.Faturado, v1);
            RegistroDeVendas r2 = new RegistroDeVendas(2, new DateTime(2021, 03, 14), 245.0, StatusVenda.Cancelado, v2);
            RegistroDeVendas r3 = new RegistroDeVendas(3, new DateTime(2021, 03, 15), 255.0, StatusVenda.Cancelado, v3);
            RegistroDeVendas r4 = new RegistroDeVendas(4, new DateTime(2021, 03, 16), 222.0, StatusVenda.Cancelado, v4);
            RegistroDeVendas r5 = new RegistroDeVendas(5, new DateTime(2021, 03, 17), 233.0, StatusVenda.Cancelado, v1);
            RegistroDeVendas r6 = new RegistroDeVendas(6, new DateTime(2021, 03, 18), 211.0, StatusVenda.Cancelado, v2);
            RegistroDeVendas r7 = new RegistroDeVendas(7, new DateTime(2021, 03, 19), 221.0, StatusVenda.Cancelado, v3);
            RegistroDeVendas r8 = new RegistroDeVendas(8, new DateTime(2021, 03, 10), 244.0, StatusVenda.Cancelado, v4);
            RegistroDeVendas r9 = new RegistroDeVendas(9, new DateTime(2021, 03, 22), 256.0, StatusVenda.Cancelado, v1);
            RegistroDeVendas r10 = new RegistroDeVendas(10, new DateTime(2021, 03, 23), 250.0, StatusVenda.Cancelado, v2);
            RegistroDeVendas r11 = new RegistroDeVendas(11, new DateTime(2021, 03, 26), 251.0, StatusVenda.Cancelado, v3);
            RegistroDeVendas r12 = new RegistroDeVendas(12, new DateTime(2021, 03, 22), 252.0, StatusVenda.Cancelado, v4);
            RegistroDeVendas r13 = new RegistroDeVendas(13, new DateTime(2021, 03, 29), 256.0, StatusVenda.Cancelado, v1);

            _context.Departamento.AddRange(d1,d2,d3,d4,d5);
            _context.Vendedor.AddRange(v1,v2,v3,v4);
            _context.Vendas.AddRange(r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,r11,r12,r13);

            _context.SaveChanges();
        }
    }
}
