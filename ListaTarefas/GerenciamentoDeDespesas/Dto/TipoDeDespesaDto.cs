using GerenciamentoDeDespesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Dto
{
    public class TipoDeDespesaDto
    {
        [Key]
        [Required]
        public int TipoDeDespesaId { get; set; }

        [Required(ErrorMessage = "Nome do tipo de Despesa é obrigatório")]
        [StringLength(50, ErrorMessage = "Nome do Tipo de despesa e muito grande, tente um nome menor!")]
        [MinLength(2, ErrorMessage = "Nome do Tipo de despesa muito pequeno, tente um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Selecione uma despesa")]
        public ICollection<Despesa> Despesa { get; set; }
    }
}
