﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PesquisaCrypto.Models
{
    public class Moeda
    {
        public int MoedaId { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        [NotMapped]
        public bool CheckBoxMarcado { get; set; }
    }
}
