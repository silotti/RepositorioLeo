using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class Cliente
    {

        [Key]
        public int id_Cliente { get; set; }

        public String nome { get; set; }

        public Boolean revenda { get; set; }

    }
}
