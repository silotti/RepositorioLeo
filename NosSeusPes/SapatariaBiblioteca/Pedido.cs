using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Pedido
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Pedido { get; set; }
        //public int id_Cliente { get; set; }
        //public int quantidade { get; set; }

        //public int precoTotal { get; set; }

        //public List<Estoque> itens2 { get; set; }
        //[ForeignKey("id_Cliente")]
        //[InverseProperty("pedidos2")]
        //public Cliente cliente { get; set; }

        //public int id_Venda { get; set; }
        //[ForeignKey("id_Venda")]
        //[InverseProperty("pedidos1")]
        //public Venda venda { get; set; }

    }
}
