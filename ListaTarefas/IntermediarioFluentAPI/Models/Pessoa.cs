using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediarioFluentAPI.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public int? Idade { get; set; }
        public double? Peso { get; set; }

        //relacionamento 0 para 1 porque o id pode receber null
        public int? EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
