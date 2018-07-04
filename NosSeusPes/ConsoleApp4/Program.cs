using SapatariaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            BancosSapataria ctx = new BancosSapataria();
            Cliente cliente = new Cliente();
            //Modelo modelo = new Modelo();
            ctx.BdCliente.Add(cliente);
            //ctx.BdModelo.Add(modelo);
            ctx.SaveChanges();

        }
    }
}
