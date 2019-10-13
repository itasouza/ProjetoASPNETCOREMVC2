using GerenciamentoDeDespesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Dto
{
    public class MesDto
    {
        [Key]
        [Required]
        [Display(Name = "Selecione um mês")]
        public int MesId { get; set; }

        [Required(ErrorMessage = "Nome do Mês é obrigatório")]
        [StringLength(50, ErrorMessage = "Nome Mês e muito grande, tente um nome menor!")]
        [MinLength(2, ErrorMessage = "Nome do Mês muito pequeno, tente um nome com mais de 2 caracteres!")]
        public string Nome { get; set; }
        public ICollection<Despesa> Despesa { get; set; }
        public Salario Salario { get; set; }
    }
}
