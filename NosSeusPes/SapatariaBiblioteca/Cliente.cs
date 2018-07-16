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
        [Key] //chave primaria
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoincrement de chave primaria
        public int id_Cliente { get; set; }
        public String nome { get; set; }
        public Boolean revenda { get; set; }
        //public List<Venda> pedidos { get; set; }

        //public virtual ICollection<Venda> VendasCliente { get; set; } = new List<Venda>();



        /// <summary>
        /// Este método é essencial para algumas comparações funcionarem.
        /// Caso contrário os combobox e outras seleções na interface gráfica
        /// não conseguiram visualizar que dois objetos que foram 
        /// carregados do banco de dados são iguais.
        /// </summary>
        /// <param name="obj">Objeto a ser comparado com o atual</param>
        /// <returns></returns>
        /// 

        // acrescentar arquivo de foto
        public byte[] foto { get; set; }
        public override bool Equals(object obj)
        {
            if (obj is Cliente)
            {
                return this.id_Cliente == ((Cliente)(obj)).id_Cliente;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.id_Cliente.GetHashCode();
        }


    }
}
