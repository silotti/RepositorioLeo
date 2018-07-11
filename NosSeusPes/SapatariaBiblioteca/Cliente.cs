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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoincrement de chave primaria
        public int id_Cliente { get; set; }
        public String nome { get; set; }

        public List<Venda> pedidos { get; set; }
        //public Boolean revenda { get; set; }
        //public virtual ICollection<Venda> VendasCliente { get; set; } = new List<Venda>();
    }
}
