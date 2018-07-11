using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Modelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoincrement de chave primaria
        public int id_Modelo { get; set; }
        public String nome { get; set; }
        public Boolean cadarco { get; set; }
        public String material { get; set; }
        public String cor { get; set; }
        public int tamanho { get; set; }
        public Decimal preco { get; set; }
        public virtual ICollection<Modelo> EstoqueModelo { get; set; } = new List<Modelo>();
    }
}
