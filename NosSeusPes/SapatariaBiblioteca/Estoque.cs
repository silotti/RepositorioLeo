using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Estoque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Estoque { get; set; }
        public int id_Modelo { get; set; }
        public int quantidade { get; set; }

        //[ForeignKey("id_Modelo")]
        //[InverseProperty("itens1")]
        //public Modelo modelo { get; set; }

        //public int id_Pedido { get; set; }
        //[ForeignKey("id_Pedido")]
        //[InverseProperty("itens2")]
        //public Pedido pedido { get; set; }



        //public List<Pedido> pedidos{ get; set; }
    }
}
