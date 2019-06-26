using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Models
{
    public class TipoDeDespesa
    {
        public int TipoDeDespesaId { get; set; }
        public string Nome  { get; set; }
        public ICollection<Despesa> Despesa { get; set; }

    }
}
