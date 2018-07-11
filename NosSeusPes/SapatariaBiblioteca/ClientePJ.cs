using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class ClientePJ : Cliente
    {
        //Classe herdada não precisa de ID 
        public String CNPJ { get; set; }
        public String razao { get; set; }
        public String enderecoPJ { get; set; }
    }
}
