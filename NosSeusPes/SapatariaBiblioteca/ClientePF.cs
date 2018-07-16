using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class ClientePF : Cliente
    {
        //Classe herdada não precisa de ID 
        public String CPF { get; set; }
        public DateTime dt_Nasc { get; set; } = DateTime.Now;
        public String enderecoPF { get; set; }




    }
}
