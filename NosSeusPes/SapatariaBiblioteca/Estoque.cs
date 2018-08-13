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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoincrement de chave primaria
        public int id_Estoque { get; set; }
        public int id_Modelo { get; set; }
        public int quantidade { get; set; }

        //[ForeignKey("id_Modelo")]
        //[InverseProperty("id_Modelo")]
        //public Modelo modelo { get; set; }

        //public int id_Pedido { get; set; }
        //[ForeignKey("id_Pedido")]
        //[InverseProperty("id_Pedido")]
        //public Pedido pedido { get; set; }

        //public List<Pedido> ped{ get; set; }
    }
}
