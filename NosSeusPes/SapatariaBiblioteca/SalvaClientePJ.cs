using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class SalvaClientePJ
    {
        public IList<ClientePJ> ObterClientePJ()
        {
            BancosSapataria ctx = new BancosSapataria();
            return ctx.BdClientePJ.ToList();
        }
    }
}
