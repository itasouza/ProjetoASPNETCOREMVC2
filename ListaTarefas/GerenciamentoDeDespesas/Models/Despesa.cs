using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Models
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public int MesId { get; set; }
        public Mes Mes { get; set; }
        public int TipoDeDespesaId { get; set; }
        public TipoDeDespesa TipoDeDespesa { get; set; }
        public double Valor { get; set; }
    }
}
