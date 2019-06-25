using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Models
{
    public class Mes
    {
        public int MesId { get; set; }
        public string Nome { get; set; }
        public ICollection<Despesa> Despesa { get; set; }
        public Salario Salario { get; set; }
    }
}
