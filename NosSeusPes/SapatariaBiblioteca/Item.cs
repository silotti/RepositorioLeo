using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    class Item
    {
        [Key]
        public int id_Item { get; set; }

        public Modelo id_Modelo { get; set; }

        public String nome { get; set; }

        public int tamanho { get; set; }

        public int quantidade { get; set; }
    }
}
