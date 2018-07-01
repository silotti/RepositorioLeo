using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class ClientePJ
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Cliente id_Cliente { get; set; }
        public String razao { get; set; }
        public int CNPJ { get; set; }
        public String endereco { get; set; }
    }
}
