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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Pedido { get; set; }
        public Cliente id_Cliente { get; set; }
        public Item id_Item { get; set; }
        public Modelo id_Modelo { get; set; }
        public int quantidade { get; set; }
        public Item tamanho { get; set; }
        public Modelo preco { get; set; }
        public int precoTotal { get; set; }
    }
}
