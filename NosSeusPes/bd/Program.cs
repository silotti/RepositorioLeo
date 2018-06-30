using SapatariaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelSapato ctx = new ModelSapato();
            Cliente cliente = new Cliente();
            cliente.nome = "Primeiro Cliente";
            ctx.BdClientes.Add(cliente);
            ctx.SaveChanges();
        }
    }
}
