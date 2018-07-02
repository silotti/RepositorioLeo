using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class ClientePJ : Cliente
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_ClientePJ { get; set; }
        //public String razao { get; set; }
        //public int CNPJ { get; set; }
        //public String endereco { get; set; }
    }
}
