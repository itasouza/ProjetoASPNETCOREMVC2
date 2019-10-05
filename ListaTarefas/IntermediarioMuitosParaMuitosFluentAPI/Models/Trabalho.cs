using System.Collections.Generic;

namespace IntermediarioMuitosParaMuitosFluentAPI.Models
{
    public class Trabalho
    {
        public int TrabalhoId { get; set; }
        public string Nome { get; set; }
        public ICollection<EmpregadoTrabalho> EmpregadoTrabalho { get; set; }

    }
}