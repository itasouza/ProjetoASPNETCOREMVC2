using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediarioMuitosParaMuitosFluentAPI.Models
{
    public class Empregado
    {
        public int EmpregadoId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int CPF { get; set; }
        public ICollection<EmpregadoTrabalho> EmpregadoTrabalho { get; set; }
    }
}
