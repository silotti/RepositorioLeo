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
        public Modelo id_Modelo { get; set; }
        public String nome { get; set; }
        public int tamanho { get; set; }
        public int quantidade { get; set; }
    }
}
