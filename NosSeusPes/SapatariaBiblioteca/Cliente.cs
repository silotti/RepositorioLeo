using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Cliente { get; set; }
        public String nome { get; set; }
        public Boolean revenda { get; set; }




        //manda lista de cliente pra pedido
        //public List<Pedido> listaCliente { get; set; }

        //public int id_ClientePF { get; set; }
        //public int id_ClientePJ { get; set; }
        //public List<Pedido> pedidos2 { get; set; }

    }
}
