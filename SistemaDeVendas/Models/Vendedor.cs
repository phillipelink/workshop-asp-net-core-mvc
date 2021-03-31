
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaDeVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double BaseSalarial { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double baseSalarial, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseSalarial = baseSalarial;
            Departamento = departamento;
        }

        public void AdicionarVendas(RegistroDeVendas rv)
        {
            Vendas.Add(rv);
        }

        public void RemoverVendas(RegistroDeVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(x => x.Data >= inicio && x.Data <= final).Sum(x => x.Quantidade);
        }
    }
}
