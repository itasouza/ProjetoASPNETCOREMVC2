using GerenciamentoDeDespesas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeDespesas.Dto
{
    public class DespesaDto
    {
        [Key]
        [Required]
        public int DespesaId { get; set; }

        [Display(Name = "Selecione um mês")]
        [Required(ErrorMessage = "Mês e obrigatório")]
        public int MesId { get; set; }

        public Mes Mes { get; set; }

        [Display(Name = "Selecione um tipo de despesa")]
        [Required(ErrorMessage = "Tipo de despesa é obrigatório")]
        public int TipoDeDespesaId { get; set; }
        public TipoDeDespesa TipoDeDespesa { get; set; }

        public double Valor { get; set; }

        [Display(Name = "Adicionar valor")]
        [Required(ErrorMessage = "Valor é obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "Valor Inválido")]
        public string ValorString { get; set; }
    }
}
