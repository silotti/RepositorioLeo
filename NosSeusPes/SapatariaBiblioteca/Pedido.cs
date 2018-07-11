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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoincrement de chave primaria
        public int id_Pedido { get; set; }
        public int id_Cliente { get; set; }
        public int id_Modelo { get; set; }
        public int quantidade { get; set; }
        public int precoTotal { get; set; }
        public virtual ICollection<Pedido> pedido { get; set; } = new List<Pedido>();

    }
}
