using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class SalvaClientePF
    {
        public IList<ClientePF> ObterClientePF()
        {
            BancosSapataria ctx = new BancosSapataria();
            return ctx.BdClientePF.ToList();
        }
    }
}
