using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Modelo
    {
        [Key]
        public int id_Modelo { get; set; }
        public String nome { get; set; }
        public Boolean cadarco { get; set; }
        public String material { get; set; }
        public String cor { get; set; }
        public float preco { get; set; }
        public String fotografias { get; set; }
    }
}
