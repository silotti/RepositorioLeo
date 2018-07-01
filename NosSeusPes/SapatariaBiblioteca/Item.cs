using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Item { get; set; }
        public int id_Modelo { get; set; }
        [ForeignKey("id_Modelo")]
        [InverseProperty("itens1")]
        public Modelo modelo { get; set; }

        public int id_Pedido { get; set; }
        [ForeignKey("id_Pedido")]
        [InverseProperty("itens2")]
        public Pedido pedido { get; set; }

        public int tamanho { get; set; }
        public int quantidade { get; set; }
    }
}
