using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Venda
    {
        [Key]
        public int id_Venda { get; set; }

        //public int id_Modelo { get; set; }
        //[ForeignKey("id_Modelo")]
        //public Modelo Model { get; set; }

        //public int id_Cliente { get; set; }
        //[ForeignKey("id_Cliente")]
        //public Cliente Client { get; set; }

        public int quantidade { get; set; }
        public DateTime? dt_Venda { get; set; }
        public Decimal precoTotal { get; set; }

    }
}
