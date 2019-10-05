using System.Collections.Generic;

namespace IntermediarioUmParaVariosFluentAPI.Models
{
    public class Trabalho
    {
        public int TrabalhoId { get; set; }
        public string Nome { get; set; }
        public ICollection<Empregado> Empregado { get; set; }

    }
}