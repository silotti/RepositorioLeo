﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaBiblioteca
{
    public class ClientePF //: Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_ClientePF { get; set; }
        public int CPF { get; set; }
        public DateTime data_Nasc { get; set; }
    }
}
