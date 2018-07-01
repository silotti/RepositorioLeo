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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Venda { get; set; }
        public Pedido id_Cliente { get; set; }
        public Pedido id_Pedido { get; set; }
        public Pedido id_Modelo { get; set; }
        public Pedido quantidade { get; set; }
        public Pedido tamanho { get; set; }
        public Pedido preco { get; set; }
        public Pedido precoTotal { get; set; }
        public List<Pedido> pedidos1 { get; set; }
    }
}
