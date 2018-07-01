using SapatariaBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            BancosSapataria ctx = new BancosSapataria();
            Modelo modelo = new Modelo();
            ctx.BdModelo.Add(modelo);
            ctx.SaveChanges();
        }
    }
}
